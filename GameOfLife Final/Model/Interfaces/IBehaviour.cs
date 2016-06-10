using Model.ModelFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
	public interface IBehaviour
	{
		void Live(Field oldField, Field newField, List<ObjectGame> myObjects);
	}
}
