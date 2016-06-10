using Model.GameOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace Model.ModelFiles
{
	/// <summary>
	/// Класс для хранения/загрузки опций животных/игры 
	/// </summary>
	public class OptionsStorage
	{
		public CowOptions cowOptions { get; set; }
		public DeadCowOptions deadCowOptions { get; set; }
		public MapOptions mapOptions { get; set; }
		public StandartGrassOptions standartGrassOptions { get; set; }
		public SuperMultiplyGrassOptions superMultiplyGrassOptions { get; set; }
		public WildGrassOptionscs wildGrassOptions { get; set; }
		public OptionsStorage()
		{
			InitializeOptions();
		}
		private void InitializeOptions()
		{
			LoadCowOptions();
			LoadDeadCowOptions();
			LoadMapOptions();
			LoadStandartGrassOptions();
			LoadSuperMultiplyGrassOptions();
			LoadWildGrassOptions();
		}
		private void LoadCowOptions()
		{		
			DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(CowOptions));
			cowOptions = (CowOptions)json.ReadObject(new System.IO.MemoryStream(Model.Properties.Resources.CowOptions));
		}
		private void LoadDeadCowOptions()
		{
			DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(DeadCowOptions));
			deadCowOptions = (DeadCowOptions)json.ReadObject(new System.IO.MemoryStream(Model.Properties.Resources.DeadCowOptions));
		}
		private void LoadMapOptions()
		{
			DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(MapOptions));
			mapOptions = (MapOptions)json.ReadObject(new System.IO.MemoryStream(Model.Properties.Resources.MapOptions));

		}
		private void LoadStandartGrassOptions()
		{
			DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(StandartGrassOptions));
			standartGrassOptions = (StandartGrassOptions)json.ReadObject(new System.IO.MemoryStream(Model.Properties.Resources.StandartGrassOptions));

		}
		private void LoadSuperMultiplyGrassOptions()
		{
			DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(SuperMultiplyGrassOptions));
			superMultiplyGrassOptions = (SuperMultiplyGrassOptions)json.ReadObject(new System.IO.MemoryStream(Model.Properties.Resources.SuperMultiplyrassOptions));

		}
		private void LoadWildGrassOptions()
		{
			DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(WildGrassOptionscs));
			wildGrassOptions = (WildGrassOptionscs)json.ReadObject(new System.IO.MemoryStream(Model.Properties.Resources.WildGrassOptions));

		}
	}
}
