using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 鲜花信息
    /// </summary>
    [SugarTable("xianhuaxinxi")]
	public class XianhuaxinxiDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 鲜花名称
		/// </summary>
		[SugarColumn(ColumnName = "xianhuamingcheng")]
		public string Xianhuamingcheng { get; set; }

		/// <summary>
		/// Desc: 鲜花分类
		/// </summary>
		[SugarColumn(ColumnName = "xianhuafenlei")]
		public string Xianhuafenlei { get; set; }

		/// <summary>
		/// Desc: 鲜花图片
		/// </summary>
		[SugarColumn(ColumnName = "xianhuatupian")]
		public string Xianhuatupian { get; set; }

		/// <summary>
		/// Desc: 鲜花规格
		/// </summary>
		[SugarColumn(ColumnName = "xianhuaguige")]
		public string Xianhuaguige { get; set; }

		/// <summary>
		/// Desc: 鲜花产地
		/// </summary>
		[SugarColumn(ColumnName = "xianhuachandi")]
		public string Xianhuachandi { get; set; }

		/// <summary>
		/// Desc: 鲜花花语
		/// </summary>
		[SugarColumn(ColumnName = "xianhuahuayu")]
		public string Xianhuahuayu { get; set; }

		/// <summary>
		/// Desc: 适用场景
		/// </summary>
		[SugarColumn(ColumnName = "shiyongchangjing")]
		public string Shiyongchangjing { get; set; }

		/// <summary>
		/// Desc: 送礼对象
		/// </summary>
		[SugarColumn(ColumnName = "songliduixiang")]
		public string Songliduixiang { get; set; }

		/// <summary>
		/// Desc: 单限
		/// </summary>
        [SugarColumn(ColumnName = "onelimittimes")]
		public int? Onelimittimes { get; set; } = 0;

		/// <summary>
		/// Desc: 库存
		/// </summary>
        [SugarColumn(ColumnName = "alllimittimes")]
		public int? Alllimittimes { get; set; } = 0;

		/// <summary>
		/// Desc: 鲜花详情
		/// </summary>
		[SugarColumn(ColumnName = "xianhuaxiangqing")]
		public string Xianhuaxiangqing { get; set; }

		/// <summary>
		/// Desc: 最近点击时间
		/// </summary>
        [SugarColumn(ColumnName = "clicktime")]
		public DateTime? Clicktime { get; set; }

		/// <summary>
		/// Desc: 评论数
		/// </summary>
        [SugarColumn(ColumnName = "discussnum")]
		public int? Discussnum { get; set; } = 0;

		/// <summary>
		/// Desc: 积分
		/// </summary>
        [SugarColumn(ColumnName = "jf")]
		public int? Jf { get; set; } = 0;

		/// <summary>
		/// Desc: 价格
		/// </summary>
        [SugarColumn(ColumnName = "price")]
		public double? Price { get; set; } = 0;

		/// <summary>
		/// Desc: 会员价
		/// </summary>
        [SugarColumn(ColumnName = "vipprice")]
		public double? Vipprice { get; set; } = 0;

		/// <summary>
		/// Desc: 收藏数
		/// </summary>
        [SugarColumn(ColumnName = "storeupnum")]
		public int? Storeupnum { get; set; } = 0;

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
