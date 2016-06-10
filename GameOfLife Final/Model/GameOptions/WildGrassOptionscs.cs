using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model.GameOptions
{
	/// <summary>
	/// Опции Трава 1
	/// </summary>
	[DataContract]
	public class WildGrassOptionscs
	{
		/// <summary>
		/// Начиная с какого количества соседних объектов, трава погибает
		/// </summary>
		[DataMember(Name="MinNeighboorsToDie")]
		public int MinNeighboorsToDie { get; set; }

		/// <summary>
		/// Левая (нижняя) граница для размножения)
		/// </summary>
		[DataMember(Name="LeftBorderToMultiply")]
		public int LeftBorderToMultiply { get; set; }

		/// <summary>
		/// Правая(верхняя) граница для размножения
		/// </summary>
		[DataMember(Name="RightBorderToMultiply")]
		public int RightBorderToMultiply { get; set; }
	}
}
