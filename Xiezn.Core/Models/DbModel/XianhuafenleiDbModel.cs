using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 鲜花分类
    /// </summary>
    [SugarTable("xianhuafenlei")]
	public class XianhuafenleiDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 鲜花分类
		/// </summary>
		[SugarColumn(ColumnName = "xianhuafenlei")]
		public string Xianhuafenlei { get; set; }

		/// <summary>
		/// Desc: image
		/// </summary>
		[SugarColumn(ColumnName = "image")]
		public string Image { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
