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
		public string playerOne;
		public string playerTwo;


		//Constructor




		//member Methods

		public void ChooseName()
		{
			Console.WriteLine("Player one please in put your name");
			string player1InPut = Console.ReadLine();
			Console.WriteLine("Player one please in put your name");
			string player2InPut = Console.ReadLine();

			player1InPut = playerOne;
			player2InPut = playerTwo;

		}
		



				


	}
}
