using Model.ModelFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
	public interface IRender
	{
		/// <summary>
		/// Нарисовать игровое поле
		/// </summary>
		/// <param name="field"></param>
		void DrawField(Field field);
		/// <summary>
		/// Отобразить сохранения
		/// </summary>
		/// <param name="saves"></param>
		void DrawSaves(List<string> saves);
		/// <summary>
		/// Вывести какое-то сообщение
		/// </summary>
		/// <param name="message"></param>
		void DisplayMessageToLog(string message);
	}
}
