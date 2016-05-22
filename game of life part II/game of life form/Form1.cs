using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace game_of_life_form
{
	public partial class Form1 : Form
	{
		private int k;
		bool flag = false;
		bool superflag = true;
		private Thread temp;
		//Массив picturebox
		private System.Windows.Forms.PictureBox[] imgArray;
		//Bitmapp для получения шестеренки
		private Bitmap bitmaper;
		//Bitmapp для получения зачеркнутой шестеренки
		private Bitmap bitmaper2;
		private void SetImage(Bitmap temp)
		{
			imgArray[0].Image = temp;			
		}
		//функция потока, чередовать картинки шестеренку и зачеркн. шестеренку
		private void Function()
		{
			Bitmap temp1 = new Bitmap("../../gear.png");
			Bitmap temp2 = new Bitmap("../../gear2.png");
			while (flag)
			{
				if (superflag)
					SetImage(temp1);
				else
					SetImage(temp2);
				superflag = !superflag;
			}
			imgArray[0].Image = temp2;
		}
		//инициализация картинок и picture box
		public Form1()
		{
			bitmaper = new Bitmap("../../gear.png");
			bitmaper2 = new Bitmap("../../gear2.png");
			k = 0;
			InitializeComponent();
			panel1.Size = new Size(500, 500);
			imgArray = new PictureBox[5];
			for (int i = 0; i < 5; i++)
			{
				imgArray[i] = new PictureBox();
				imgArray[i].Margin = new Padding(0);
				imgArray[i].Size = new Size(100, 100);
				imgArray[i].Image = bitmaper;
				panel1.Controls.Add(imgArray[i]);
				panel1.Controls[i].Location = new Point(100 * i, 0);
				imgArray[i].SizeMode = PictureBoxSizeMode.Zoom;
				imgArray[i].BorderStyle = BorderStyle.Fixed3D;
			}
		}
		//здесь запускается чередование
		private void button1_Click(object sender, EventArgs e)
		{
			flag = !flag;
			if (flag)
			{
				temp = new Thread(Function);
				temp.IsBackground = false;
				temp.Start();
			}
			textBoxTest.Text = k.ToString();
			k++;
		}
	}
}
