﻿using System;

namespace Battleplan
{
	public static class Program
	{
		[STAThread] static void Main()
		{
			using (var game = new GameManager()) { game.Run(); }
		}
	}
}