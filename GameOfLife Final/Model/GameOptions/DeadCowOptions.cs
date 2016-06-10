using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model.GameOptions
{
	/// <summary>
	/// Опции трупа коровы
	/// </summary>
	[DataContract]
	public class DeadCowOptions
	{
		/// <summary>
		/// Сколько итераций труп находится на поле
		/// </summary>
		[DataMember(Name="IterationsToLive")]
		public int IterationsToLive { get; set; }
	}
}
