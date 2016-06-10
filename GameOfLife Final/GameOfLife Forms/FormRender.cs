using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using Model.ModelFiles;

namespace ModelFiles
{
	public class FormRender : IRender
	{
		/// <summary>
		/// Словарь картинок, где в качестве ключа у нас название объекта, например "cow","grass"
		/// </summary>
		/// Ключевые слова:
		/// Cow - просто корова
		/// DeadCow - корова умерла
		/// StandartGrass - обычная трава
		/// WildGrass - дикая трава, по алгоритму 4.2
		Dictionary<ObjectType, Bitmap> myImages = new Dictionary<ObjectType, Bitmap>();
		System.Windows.Forms.PictureBox[] imgArray;
		TextBox textBoxSaves;
		TextBox textBoxLog;
		Panel panelField;
		Form myForm;
		///Параметры поля
		int width = -1;
		int height = -1;
		int imageSize = 64;//Размер картинки 36 пикселей
		/// <summary>
		/// Отступы для панели
		/// </summary>
		int dx = 100;
		int dy = 100;
		public FormRender(TextBox textBoxSaves, TextBox textBoxLog, Panel panelField, Form form)
		{
			LoadImages();
			this.textBoxSaves = textBoxSaves;
			this.textBoxLog = textBoxLog;
			this.panelField = panelField;
			this.myForm = form;
		}
		/// <summary>
		/// Загрузка картинок, там какая-то трабла
		/// </summary>
		private void LoadImages()
		{
			Bitmap cowImage = new Bitmap(GameOfLife_Forms.Properties.Resources.Cow);
			Bitmap cowDeadImage = new Bitmap(GameOfLife_Forms.Properties.Resources.CowDead);
			Bitmap grassDefaultImage = new Bitmap(GameOfLife_Forms.Properties.Resources.GrassDefault);
			Bitmap grassWildImage = new Bitmap(GameOfLife_Forms.Properties.Resources.GrassWild);
			Bitmap grassSuperMultiplyImage = new Bitmap(GameOfLife_Forms.Properties.Resources.SuperMultyGrass);

			myImages.Add(ObjectType.Cow, cowImage);
			myImages.Add(ObjectType.DeadCow, cowDeadImage);
			myImages.Add(ObjectType.StandartGrass, grassDefaultImage);
			myImages.Add(ObjectType.WildGrass, grassWildImage);
			myImages.Add(ObjectType.SuperMultiplyGrass, grassSuperMultiplyImage);
		}
		/// <summary>
		/// Инициализация поля, запускается первый раз или если размеры поля изменились(например если начата новая игра)
		/// </summary>
		/// <param name="Field"></param>
		private void InitializeField(int newHeight, int newWidth)
		{
			if (myForm.InvokeRequired)
				myForm.Invoke((Action)delegate() { InitializeField(newHeight, newWidth); });
			else
			{
				height = newHeight;
				width = newWidth;

				panelField.Size = new Size(width * imageSize, height * imageSize);
				imgArray = new PictureBox[width * height];

				myForm.MinimumSize = new Size(width * imageSize + panelField.Location.X + dx, height * imageSize + panelField.Location.Y + dy);

				for (int j = 0; j < height; j++)
					for (int i = 0; i < width; i++)
					{
						imgArray[j * width + i] = new PictureBox();
						imgArray[j * width + i].Margin = new Padding(0);
						imgArray[j * width + i].Size = new Size(imageSize, imageSize);
						imgArray[j * width + i].Image = null;
						panelField.Controls.Add(imgArray[j * width + i]);
						panelField.Controls[j * width + i].Location = new Point(imageSize * i, j * imageSize);
						imgArray[j * width + i].SizeMode = PictureBoxSizeMode.Zoom;
						imgArray[j * width + i].BorderStyle = BorderStyle.Fixed3D;
						imgArray[j * width + i].BackColor = Color.White;
					}
			}
		}
		/// <summary>
		/// Получение картинки в зависимости от объектов на клетке поля (определяем, что нарисовать в ячейке поля)
		/// </summary>
		/// <param name="objects"></param>
		/// <returns></returns>
		private Bitmap GetImage(Field field, int x, int y)
		{
			///Приходится делать из-за приоритета печати ( например, если в одной клетке трава и корова, мы печатаем корову)

			if (field.IsEmpty(x, y))
				return null;

			if (field.Contains(x, y, ObjectType.Cow))
				return myImages[ObjectType.Cow];

			if (field.Contains(x, y, ObjectType.DeadCow))
				return myImages[ObjectType.DeadCow];

			if (field.Contains(x, y, ObjectType.StandartGrass))
				return myImages[ObjectType.StandartGrass];

			if (field.Contains(x, y, ObjectType.WildGrass))
				return myImages[ObjectType.WildGrass];

			if (field.Contains(x, y, ObjectType.SuperMultiplyGrass))
				return myImages[ObjectType.SuperMultiplyGrass];
			//if (objects == null)
			//	return null;
			//foreach (var temp in objects)
			//	if (temp.objectType == ObjectType.Cow)
			//		return myImages[ObjectType.Cow];
			//foreach (var temp in objects)
			//	if (temp.objectType == ObjectType.DeadCow)
			//		return myImages[ObjectType.DeadCow];
			//foreach (var temp in objects)
			//	if (temp.objectType == ObjectType.StandartGrass)
			//		return myImages[ObjectType.StandartGrass];
			//foreach (var temp in objects)
			//	if (temp.objectType == ObjectType.WildGrass)
			//		return myImages[ObjectType.WildGrass];

			return null;
		}
		/// <summary>
		/// Рисуем поле
		/// </summary>
		/// <param name="field"></param>
		private void DrawEverything(Field field)
		{
			if (myForm.InvokeRequired)
				myForm.Invoke((Action)delegate() { DrawEverything(field); });
			else
			{
				for (int i = 0; i < height; i++)
					for (int j = 0; j < width; j++)
						imgArray[i * width + j].Image = GetImage(field, i, j);
			}
		}
		/// <summary>
		/// Начинаем рисовать поле, если работаем с новым поле, пересоздаем поле
		/// </summary>
		/// <param name="field"></param>
		public void DrawField(Field field)
		{
			if (height != field.Height || width != field.Width)
				InitializeField(field.Height, field.Width);
			DrawEverything(field);
		}
		/// <summary>
		/// Отображаем сохранения
		/// </summary>
		/// <param name="saves"></param>
		public void DrawSaves(List<string> saves)
		{
			if (myForm.InvokeRequired)
				myForm.Invoke((Action)delegate() { DrawSaves(saves); });
			else
			{
				if (saves == null)
					textBoxSaves.Text = "Нет сохранений :(\r\n";
				StringBuilder sb = new StringBuilder();
				sb.Append("Сохранения:\r\n");
				int i = 1;
				foreach (var temp in saves)
				{
					sb.Append(i.ToString());
					sb.Append(". ");
					sb.Append(temp);
					sb.Append("\r\n");
					i++;
				}
				textBoxSaves.Text = sb.ToString();
			}
		}
		/// <summary>
		/// Отобразить какое то сообщение в окошечке Log
		/// </summary>
		/// <param name="message"></param>
		public void DisplayMessageToLog(string message)
		{
			if (myForm.InvokeRequired)
				myForm.Invoke((Action)delegate() { DisplayMessageToLog(message); });
			else
			{
				textBoxLog.Text = message;
			}
		}
	}
}
