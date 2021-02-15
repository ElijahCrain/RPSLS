using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSproject.cs
{
	class Human : Player
	{
		//child class
		//member Variables



		//Constructor
		public Human()
		{
			score = 0;
		}



		//member Methods

		//public void ChooseName()
		//{
		//	Console.WriteLine("Player one please in put your name");
		//	string player1InPut = Console.ReadLine();
		//	Console.WriteLine("Player one please in put your name");
		//	string player2InPut = Console.ReadLine();

		//	player1InPut = playerOne;
		//	player2InPut = playerTwo;

		//}
		public override void ChooseGesture()
		{
			Console.WriteLine("chose the gester you would like");
			for (int i = 0; i < gestures.Count; i++)
			{
				Console.WriteLine("press " + i + " for " + gestures[i]);
			}
			string response = Console.ReadLine();
			int convertResponse = Int32.Parse(response);
			chosenGesture = gestures[convertResponse];
			//give a value to chosenGesture member varaible
		}






	}
}
