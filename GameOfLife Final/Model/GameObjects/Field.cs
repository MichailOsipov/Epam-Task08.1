using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelFiles
{
	/// <summary>
	/// Обертка для HashSet<ObjectGame>[,]field - для удобства работы
	/// </summary>
	public class Field
	{
		public HashSet<ObjectGame>[,] myField;
		public int Height
		{
			get
			{
				return myField.GetLength(0);
			}
		}
		public int Width
		{
			get
			{
				return myField.GetLength(1);
			}
		}

		public Field(int height, int width)
		{
			myField = new HashSet<ObjectGame>[height, width];
			for (int i = 0; i < height; i++)
				for (int j = 0; j < width; j++)
					myField[i, j] = new HashSet<ObjectGame>();
		}
		public bool Contains(int x,int y,ObjectType objectType)
		{
			if (myField[x, y] == null)
				return false;

			foreach(var temp in myField[x,y])			
				if (temp.objectType == objectType)
					return true;
			
			return false;
		}
		public bool IsEmpty(int x,int y)
		{
			if (myField[x, y] == null)
				return true;
			return false;
		}
	}
}
