using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model.GameOptions
{
	/// <summary>
	/// Опции коровы
	/// </summary>
	[DataContract]
	public class CowOptions
	{
		/// <summary>
		/// Базовый запас энергии
		/// </summary>
		[DataMember(Name="BasicEnergyValue")]
		public int BasicEnergyValue { get; set; }

		/// <summary>
		/// Расход энергии за один ход
		/// </summary>
		[DataMember(Name="EnergyConsumption")]
		public int EnergyConsumption { get; set; }

		/// <summary>
		/// Начальная скорость
		/// </summary>
		[DataMember(Name="StartingSpeed")]
		public int StartingSpeed { get; set; }
	}
}
