using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model.GameOptions
{
	/// <summary>
	/// Параметры поля (игры)
	/// </summary>
	[DataContract]
	public class MapOptions
	{
		/// <summary>
		/// Ширина поля
		/// </summary>
		[DataMember(Name="Width")]
		public int Width { get; set; }

		/// <summary>
		/// Высота поля
		/// </summary>
		[DataMember(Name="Height")]
		public int Height { get; set; }
	}
}
