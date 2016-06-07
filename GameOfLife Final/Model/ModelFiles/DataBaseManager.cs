using Model.GameSaves;
using Model.ModelFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFiles
{
	public class DataBaseManager
	{
		/// <summary>
		/// Нужно переделать
		/// </summary>
		public void AddSaveToDataBase()
		{
			using (var db = new SavedGames())
			{
				try
				{
					SaveData k = new SaveData { Width = 10, Height = 10, SaveTime = DateTime.Now };
					db.MySaves.Add(k);
					db.SaveChanges();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}
		public void RemoveSaveFromDataBase()
		{

		}
		/// <summary>
		/// Вернуть список сохранений в виде: Height X, Width Y, Time Z
		/// </summary>
		/// <returns></returns>
		public List<string> GetAllSaves()
		{
			List<string> result = new List<string>();
			using (var db = new SavedGames())
			{
				try
				{
					var saves = db.MySaves;
					if (saves.Count() == 0)
						return null;

					StringBuilder sb = new StringBuilder();

					foreach (var temp in saves)
					{						
						sb.Append("Height: ");
						sb.Append(temp.Height);
						sb.Append(", ");
						sb.Append("Width: ");
						sb.Append(temp.Width);
						sb.Append(", ");
						sb.Append("Time: ");
						sb.Append(temp.SaveTime.ToString());
						result.Add(sb.ToString());
						sb.Clear();
					}
					return result;
				}
				catch (Exception ex)
				{
					LoggerWorker exceptionWorker = new LoggerWorker();
					exceptionWorker.Log(ex.Message);
				}
			}



			return null;
		}
	}
}
