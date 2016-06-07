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
		private HashSet<IObjectGame>[,] field1;
		/// <summary>
		/// Список игровых объектов, учавствующих в игре
		/// </summary>
		private List<IObjectGame> myGameObjects;
		/// <summary>
		/// Словарь событий, которые нужно выполнить (Новая игра, сохранить, и т.д.)
		/// </summary>
		private Dictionary<ActionType, MyDelegate> myActions;
		/// <summary>
		/// Класс для работы с базой данных
		/// </summary>
		private DataBaseManager dataBaseManager;
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

			dataBaseManager = new DataBaseManager();

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
		/// <summary>
		/// Новая игра, стандартный режим
		/// </summary>
		private void NewGameStandart()
		{

		}
		/// <summary>
		/// Новая игра, режим по алгоритму 4.2
		/// </summary>
		private void NewGameAlgorithm42()
		{

		}
		/// <summary>
		/// Новая игра, смешанный режим
		/// </summary>
		private void NewGameMixed()
		{

		}
		/// <summary>
		/// Новая игра, режим с животными
		/// </summary>
		private void NewGameWithAnimals()
		{

		}
		/// <summary>
		/// Посмотреть сохранения
		/// </summary>
		private void ShowSaves()
		{
			render.DisplayMessageToLog("Сохранения загружаются");
			render.DrawSaves(dataBaseManager.GetAllSaves());
			render.DisplayMessageToLog("Сохранения загрузились");
		}
		/// <summary>
		/// Сохранить игру
		/// </summary>
		private void SaveGame()
		{

		}
		/// <summary>
		/// Загрузить игру
		/// </summary>
		private void LoadGame()
		{

		}
		/// <summary>
		/// Удалить игру
		/// </summary>
		private void RemoveGame()
		{

		}
		/// <summary>
		/// Выход
		/// </summary>
		private void Exit()
		{
			gameIsRunning = false;
		}
		/// <summary>
		/// Добавить какое то действие к событию
		/// </summary>
		/// <param name="action">Событие</param>
		public void AddActionToEvent(ActionType action)
		{
			lock (threadlock)
			{
				DoSmth += myActions[action];
			}
		}
		/// <summary>
		/// Удалить все события
		/// </summary>
		private void ClearDoSmth()
		{
			foreach(var eh in myActions)
			{
				DoSmth -= eh.Value;
			}
		}
		/// <summary>
		/// Функция, которая обновляет поле
		/// </summary>
		private void Update()
		{
		}
		/// <summary>
		/// Игровой поток
		/// </summary>
		private void Waiter()
		{
			while (gameIsRunning)
			{
				lock (threadlock)
				{
					if (DoSmth != null)
					{
						DoSmth();
						ClearDoSmth();
					}
				}
				while (DoSmth == null && gameIsNotPaused && gameIsBeginOrNotFinished)
				{
					Update();
					render.DrawField(field1);
					Thread.Sleep(1000);
				}
			}
		}
	}
}
