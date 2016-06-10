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
			OptionsStorage temp = new OptionsStorage();
			render = new FormRender(textBoxSaveMessager,textBoxLog, panelGameField,this);
			//Field field = new Field(6,5);

			//ObjectGame temp = new ObjectGame { objectType = ObjectType.Cow };
			//field.myField[2, 2].Add(temp);
			//render.DrawField(field);
			model = new MyModel(render);
		}

		private void standartModeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.NewGameStandart);
		}

		private void algorithm42ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.NewGameAlgorithm42);
		}

		private void mixedModeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.NewGameMixed);
		}

		private void animalsModeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.NewGameAnimals);
		}

		private void viewSavesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.ShowSaves);
		}

		private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.SaveGame);
		}

		private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.LoadGame);
		}

		private void removeGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.RemoveGame);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			model.AddActionToEvent(ActionType.Exit);
			this.Close();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			model.AddActionToEvent(ActionType.Exit);
		}

		private void buttonInput_Click(object sender, EventArgs e)
		{

		}
	}
}
