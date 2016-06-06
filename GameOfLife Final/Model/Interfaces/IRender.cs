using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
	public interface IRender
	{
		void DrawField(HashSet<IObjectGame>[,]Field,bool testflag);
		void DrawSaves(List<string> saves);
	}
}
