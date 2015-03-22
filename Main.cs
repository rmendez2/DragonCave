using System;

namespace DragonCave
{
	class MainClass
	{
		public static string command;

		public static void Main (string[] args)
		{
			DCBoard board = new DCBoard ();
            DCPlayer player = new DCPlayer();
			Console.WriteLine (DCMessages.NewGame);
			Console.WriteLine (DCMessages.Direction + "EAST");

			while (true) {
				Console.WriteLine("Enter Command!");
				command = Console.ReadLine();

				if (command == "X")
				{
					Console.WriteLine("Here's the Map, you cheater");
					Console.WriteLine("'P' is a pit, 'D' is a Dragon, and 'G' is the gold!");
				}
				if(command == "F"){
					player.MoveForward();
				}
				if(command == "L"){
					player.TurnLeft();
				}
				if(command == "R"){
					player.TurnRight();
				}
				if(command == "Q")
				{
					Console.WriteLine("QUITTER!");
					Environment.Exit(0);
				}
			}

		}
	}
}

