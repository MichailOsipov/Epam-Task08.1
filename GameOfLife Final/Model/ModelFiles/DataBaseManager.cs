using Model.GameSaves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFiles
{
	public class DataBaseManager
	{
		public void AddSaveToDataBase()
		{
			using (var temp = new SavedGames())
			{
				try
				{
					SaveData k = new SaveData { Width = 10,Height=10,SaveTime=DateTime.Now };
					temp.MySaves.Add(k);
					temp.SaveChanges();
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine("!");
				}
			}
		}
		public void RemoveSaveFromDataBase()
		{

		}

		public List<string> ShowAllSaves()
		{

			return null;
		}

	}
}
