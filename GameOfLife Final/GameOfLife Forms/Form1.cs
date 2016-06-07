using Model.Interfaces;
using Model.ModelFiles;
using ModelFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife_Forms
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// Контроллера тут у меня нет
		/// </summary>
		FormRender render;
		MyModel model;
		public Form1()
		{
			InitializeComponent();
			render = new FormRender(textBoxSaveMessager,textBoxLog, panelGameField,this);			
			model = new MyModel(render);
		}

		private void стандартныйРежимToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.NewGameStandart);
		}

		private void режимПоАлгоритму42ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.NewGameAlgorithm42);
		}

		private void смешанныйРежимToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.NewGameMixed);
		}

		private void режимСЖивотнымиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.NewGameAnimals);
		}

		private void посмотретьСохраненияToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.ShowSaves);
		}

		private void сохранитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.SaveGame);
		}

		private void загрузитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.LoadGame);
		}

		private void удалитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.RemoveGame);
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.Exit);
			this.Close();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			model.AddActionToEvent(ActionType.Exit);
		}

		//private void Form1_Closed(object sender,EventArgs e)
		//{
		//	//model.AddActionToEvent(ActionType.Exit);
		//}
		//private void Form1_Load(object sender, EventArgs e)
		//{
		//	model.AddActionToEvent(ActionType.Exit);
		//}

	}
}
