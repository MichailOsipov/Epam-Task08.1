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
		/// DefaultGrass - обычная трава
		/// WildGrass - дикая трава, по алгоритму 4.2
		Dictionary<string, Bitmap> myImages = new Dictionary<string, Bitmap>();
		System.Windows.Forms.PictureBox[] imgArray;
		TextBox textBoxSaves;
		Panel panelField;
		Form myForm;
		///Параметры поля
		int width = -1;
		int height = -1;
		int imageSize = 36;//Размер картинки 36 пикселей
		public FormRender(TextBox textBoxSaves, Panel panelField, Form form)
		{
			LoadImages();
			this.textBoxSaves = textBoxSaves;
			this.panelField = panelField;
			this.myForm = form;
		}
		/// <summary>
		/// Загрузка картинок, там какая-то трабла
		/// </summary>
		private void LoadImages()
		{
			//Почему-то видит файлы только в Debug
			Bitmap cowImage = new Bitmap(Path.GetFullPath("Cow.png"));
			Bitmap cowDeadImage = new Bitmap(Path.GetFullPath("CowDead.png"));
			Bitmap grassDefaultImage = new Bitmap(Path.GetFullPath("GrassDefault.png"));
			Bitmap grassWildImage = new Bitmap(Path.GetFullPath("GrassWild.png"));

			myImages.Add("Cow", cowImage);
			myImages.Add("DeadCow", cowDeadImage);
			myImages.Add("DefaultGrass", grassDefaultImage);
			myImages.Add("WildGrass", grassWildImage);
		}
		/// <summary>
		/// Инициализация поля, запускается первый раз или если размеры поля изменились(например если начата новая игра)
		/// </summary>
		/// <param name="Field"></param>
		private void InitializeField(int newHeight, int newWidth)
		{
			height = newHeight;
			width = newWidth;
			panelField.Size = new Size(width * imageSize, height * imageSize);
			imgArray = new PictureBox[width * height];
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

		private void DrawEverything(HashSet<IObjectGame>[,] field)
		{
			if (myForm.InvokeRequired)
				myForm.Invoke((Action)delegate() { DrawEverything(field); });
			else
			{
				for (int j = 0; j < height; j++)
					for (int i = 0; i < width; i++)
							imgArray[j * width + i].Image = myImages["WildGrass"];
			}
		}
		public void DrawField(HashSet<IObjectGame>[,] field)
		{
			if (height != field.GetLength(0) || width != field.GetLength(1))
				InitializeField(field.GetLength(0), field.GetLength(1));
			DrawEverything(field);			
		}
		public void DrawSaves(List<string> saves)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("Сохранения:\r\n");
			foreach (var temp in saves)
			{
				sb.Append(temp);
				sb.Append("\r\n");
			}
			textBoxSaves.Text = sb.ToString();
		}
	}
}
