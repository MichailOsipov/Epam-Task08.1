using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model.GameOptions
{
	/// <summary>
	/// Опции Трава 2
	/// </summary>
	[DataContract]
	public class SuperMultiplyGrassOptions
	{
		/// <summary>
		/// Количество итераций для репродуцирования
		/// </summary>
		[DataMember(Name="IterationsNeedToMultiply")]
		public int IterationsNeedToMultiply { get; set; }
	}
}
