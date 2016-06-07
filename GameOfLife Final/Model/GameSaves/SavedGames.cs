namespace Model.GameSaves
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class SavedGames : DbContext
	{
		// Your context has been configured to use a 'SavedGames' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'Model.GameSaves.SavedGames' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'SavedGames' 
		// connection string in the application configuration file.
		public SavedGames()
			: base("name=SavedGames")
		{
		}
		public virtual DbSet<SaveData> MySaves { get; set; }
		public virtual DbSet<ObjectGameData> MyObjects { get; set; }
		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

		// public virtual DbSet<MyEntity> MyEntities { get; set; }
	}

	public class SaveData
	{
		public int Id { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public DateTime SaveTime { get; set; }
	}

	public class ObjectGameData
	{
		public int Id { get; set; }
		public string ObjectType { get; set; }
		public string ObjectSerializedParameters { get; set; }
		public SaveData SaveIdentificator { get; set; }
	}
}