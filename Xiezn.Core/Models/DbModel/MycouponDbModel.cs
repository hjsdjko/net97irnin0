using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 我的优惠券
    /// </summary>
    [SugarTable("mycoupon")]
	public class MycouponDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 用户id
		/// </summary>
        [SugarColumn(ColumnName = "userid")]
		public long? Userid { get; set; } = 0;

		/// <summary>
		/// Desc: 优惠券id
		/// </summary>
        [SugarColumn(ColumnName = "couponid")]
		public long? Couponid { get; set; } = 0;

		/// <summary>
		/// Desc: 名称
		/// </summary>
		[SugarColumn(ColumnName = "name")]
		public string Name { get; set; }

		/// <summary>
		/// Desc: 券编号
		/// </summary>
		[SugarColumn(ColumnName = "couponnumber")]
		public string Couponnumber { get; set; }

		/// <summary>
		/// Desc: 满额
		/// </summary>
        [SugarColumn(ColumnName = "fullamount")]
		public double? Fullamount { get; set; } = 0;

		/// <summary>
		/// Desc: 优惠额
		/// </summary>
        [SugarColumn(ColumnName = "discountamount")]
		public double? Discountamount { get; set; } = 0;

		/// <summary>
		/// Desc: 生效时间
		/// </summary>
        [SugarColumn(ColumnName = "startime")]
		public DateTime? Startime { get; set; }

		/// <summary>
		/// Desc: 过期时间
		/// </summary>
        [SugarColumn(ColumnName = "endtime")]
		public DateTime? Endtime { get; set; }

		/// <summary>
		/// Desc: 优惠券类型
		/// </summary>
		[SugarColumn(ColumnName = "type")]
		public string Type { get; set; }

		/// <summary>
		/// Desc: 备注
		/// </summary>
		[SugarColumn(ColumnName = "remark")]
		public string Remark { get; set; }

		/// <summary>
		/// Desc: 状态
		/// </summary>
		[SugarColumn(ColumnName = "status")]
		public string Status { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
