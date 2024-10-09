using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xiezn.Core.Common.Helpers;
using Xiezn.Core.Models;
using Xiezn.Core.Models.DbModel;


namespace Xiezn.Core.Business.Services
{
    public class XianhuaxinxiService : BaseService<XianhuaxinxiDbModel>
    {
        private readonly long _uid;
        private readonly string _role;
        private readonly string _tablename;

        public XianhuaxinxiService()
        {
            try
            {
                if (CacheHelper.TokenModel != null)
                {
                    _uid = CacheHelper.TokenModel.Uid;
                    _role = CacheHelper.TokenModel.Role;
                    _tablename = CacheHelper.TokenModel.Tablename;
                }
            }
            catch
            {
                _uid = 0;
                _role = "游客";
            }
        }






        public PageModel<XianhuaxinxiDbModel> GetPageList(int page, int limit, string sort, string order, List<IConditionalModel> conModels)
        {
            PageModel pageModel = new PageModel() { PageIndex = page, PageSize = limit };

            int totalNumber = 0;
            int totalPage = 0;
            string[] sortFields = sort.Split(',');
            string[] orderFields = order.Split(',');
            string mysort = "";
            for (int i = 0; i < sortFields.Length; i++)
            {
                if (i == sortFields.Length - 1)
                {
                    mysort += sortFields[i] + " " + orderFields[i];
                }
                else
                {
                    mysort += sortFields[i] + " " + orderFields[i] + ",";

                }

            }
            List<XianhuaxinxiDbModel> ts = Db.Queryable<XianhuaxinxiDbModel>().Where(conModels).OrderBy(mysort).ToPageList(page, limit, ref totalNumber, ref totalPage);


            PageModel<XianhuaxinxiDbModel> t = new PageModel<XianhuaxinxiDbModel>()
            {
                Code = ResponseCodeEnum.Success,
                Data = new Page<XianhuaxinxiDbModel>()
                {
                    Total = totalNumber,
                    PageSize = limit,
                    TotalPage = totalPage,
                    CurrPage = page,
                    List = ts
                }
            };

            return t;
        }






        private double CosineSimilarity(Dictionary<string, double> a, Dictionary<string, double> b)
        {
            var numerator = a.Where(pair => b.ContainsKey(pair.Key)).Sum(pair => pair.Value * b[pair.Key]);
            var denominator = Math.Sqrt(a.Values.Sum(value => value * value)) * Math.Sqrt(b.Values.Sum(value => value * value));
            return numerator / denominator;
        }

        public PageModel<XianhuaxinxiDbModel> AutoSort2(int page, int limit, Dictionary<string, string> filterPairs =null)
        {
            List<OrdersDbModel> orderList = Db.Ado.SqlQuery<OrdersDbModel>(@"select * from orders order by addtime desc").ToList();
            ///用户-订单矩阵
            Dictionary<string, Dictionary<string,double>> userRatings = new Dictionary<string, Dictionary<string,double>>();

            foreach (OrdersDbModel orderModel in orderList)
            {
                var userId = orderModel.Userid.ToString();
                var goodId = orderModel.Goodid.ToString();

                if (userRatings.ContainsKey(userId))
                {
                    var ratingsDict = userRatings[userId];
                    if (ratingsDict.ContainsKey(goodId))
                    {
                        ratingsDict[goodId]++;
                    }
                    else
                    {
                        ratingsDict[goodId] = 1;
                    }
                }
                else
                {
                    userRatings[userId] = new Dictionary<string, double>
                    {
                        { goodId, 1 }
                    };
                }
            }
            var sortedRecommendedGoods = new List<string>();
            try
            {
                var targetUserId = _uid.ToString();
                ///计算目标用户与其他用户的相似度
                var similarities = userRatings.Where(pair => pair.Key != targetUserId)
                    .ToDictionary(pair => pair.Key, pair => CosineSimilarity(userRatings[targetUserId], pair.Value));
                ///找到与目标用户最相似的用户
                var mostSimilarUser = similarities.OrderByDescending(pair => pair.Value).First().Key;
                ///找到最相似但目标用户未购买过的商品
                var recommendedGoods = userRatings[mostSimilarUser].Where(pair => !userRatings[targetUserId].ContainsKey(pair.Key))
                    .ToDictionary(pair => pair.Key, pair => pair.Value);
                ///按评分降序排列推荐
                sortedRecommendedGoods = recommendedGoods.OrderByDescending(pair => pair.Value).Select(pair => pair.Key).ToList();
            }
            catch
            {
            }

            string filtervalues = "";
            foreach (var queryString in filterPairs)
            {
                var key = queryString.Key;
                var values = queryString.Value;

                filtervalues += "AND " + key + "='" + values+"'";
            }

            string sql = @"select * from xianhuaxinxi where id in ('{0}') "+ filtervalues + " union all select * from xianhuaxinxi where id not in ('{0}') "+ filtervalues;

            sql = string.Format(sql, string.Join("','", sortedRecommendedGoods.ToArray()));

            List<XianhuaxinxiDbModel> ts = Db.Ado.SqlQuery<XianhuaxinxiDbModel>(sql).ToList();
            PageModel<XianhuaxinxiDbModel> t = new PageModel<XianhuaxinxiDbModel>()
            {
                Code = ResponseCodeEnum.Success,
                Data = new Page<XianhuaxinxiDbModel>()
                {
                    Total = limit,
                    PageSize = limit,
                    TotalPage = 1,
                    CurrPage = page,
                    List = ts
                }
            };

            return t;
        }


    }
}
