using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Model.Interfaces;
using Model.ModelFiles;



namespace ModelFiles
{
	public delegate void MyDelegate();
	public class MyModel
	{
		/// <summary>
		/// Делегат, отвечающий за выполнение игровых команд
		/// </summary>
		private event MyDelegate DoSmth;
		/// <summary>
		/// Локер
		/// </summary>
		private object threadlock = new object();
		/// <summary>
		/// Поток модели
		/// </summary>
		private Thread modelThread;
		/// <summary>
		/// Флаг, идет ли игра(открыто ли окошко)
		/// </summary>
		private bool gameIsRunning;
		/// <summary>
		/// Рендер
		/// </summary>
		IRender render;
		/// <summary>
		/// Флаг, приостановлена ли игра
		/// </summary>
		private bool gameIsNotPaused;
		/// <summary>
		/// Флаг, началась ли игра, нужно ли делать ее итерации
		/// </summary>
		private bool gameIsBeginOrNotFinished;
		/// <summary>
		/// Игровое поле
		/// </summary>
		private HashSet<IObjectGame>[,] field;
		private Dictionary<ActionType, MyDelegate> myActions;
		/// <summary>
		/// Конструктор
		/// </summary>
		public MyModel(IRender render)
		{
			InitializeProperties();
			this.render = render;
			modelThread = new Thread(Waiter);
			modelThread.Start();
		}
		/// <summary>
		/// Инициализация некоторых начальных параметров
		/// </summary>
		private void InitializeProperties()
		{
			gameIsRunning = true;
			gameIsNotPaused = true;
			gameIsBeginOrNotFinished = false;

			myActions = new Dictionary<ActionType, MyDelegate>();
			myActions.Add(ActionType.NewGameStandart, this.NewGameStandart);
			myActions.Add(ActionType.NewGameAlgorithm42, this.NewGameAlgorithm42);
			myActions.Add(ActionType.NewGameMixed, this.NewGameMixed);
			myActions.Add(ActionType.NewGameAnimals, this.NewGameWithAnimals);
			myActions.Add(ActionType.ShowSaves, this.ShowSaves);
			myActions.Add(ActionType.SaveGame, this.SaveGame);
			myActions.Add(ActionType.LoadGame, this.LoadGame);
			myActions.Add(ActionType.RemoveGame, this.RemoveGame);
			myActions.Add(ActionType.Exit, this.Exit);
		}
		private void NewGameStandart()
		{

		}
		private void NewGameAlgorithm42()
		{

		}
		private void NewGameMixed()
		{

		}
		private void NewGameWithAnimals()
		{

		}
		private void ShowSaves()
		{

		}
		private void SaveGame()
		{

		}
		private void LoadGame()
		{

		}
		private void RemoveGame()
		{

		}
		private void Exit()
		{
			gameIsRunning = false;
		}
		public void AddActionToEvent(ActionType action)
		{
			lock (threadlock)
			{
				DoSmth += myActions[action];
			}
		}
		/// <summary>
		/// Функция, которая обновляет поле
		/// </summary>
		private void Update()
		{

		}
		private void Waiter()
		{
			while (gameIsRunning)
			{
				lock (threadlock)
				{
					if (DoSmth != null)
						DoSmth();
				}
				//Нужна ли DoSmth==null?
				while (DoSmth == null && gameIsNotPaused && gameIsBeginOrNotFinished)
				{
					Update();
					render.DrawField(field);
				}
			}
		}
	}
}
