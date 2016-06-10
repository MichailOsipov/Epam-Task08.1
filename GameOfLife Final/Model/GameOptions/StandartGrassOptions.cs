using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model.GameOptions
{
	/// <summary>
	/// Опции стандартного поведения травы
	/// </summary>
	[DataContract]
	public class StandartGrassOptions
	{
		/// <summary>
		/// Начиная с какого количества соседних объектов, трава погибает
		/// </summary>
		[DataMember(Name="MinNeighboorsToDie")]
		public int MinNeighboorsToDie { get; set; }
	}
}
