﻿using System.IO;
using Newtonsoft.Json;

namespace LearningMonogameOpenGL
{
	/// <summary>Static class that stores all JSON data used in the game.</summary>
	internal static class GameData
	{
		static GameData()
		{
			Config = JsonConvert.DeserializeObject<ConfigStruct>(File.ReadAllText(@"GameData\Config.json"));
		}

		/// <summary>General configurable game settings.</summary>
		public static ConfigStruct Config { get; }

		internal struct ConfigStruct
		{
			// ReSharper disable once UnassignedGetOnlyAutoProperty
			/// <summary>Number of pixels the cursor moves per second.</summary>
			public float CursorSpeed { get; set; }
		}
	}
}