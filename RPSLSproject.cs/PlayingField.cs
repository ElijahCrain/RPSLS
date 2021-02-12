using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSproject.cs
{
	class PlayingField
	{
		//member Variables
		//# of players 
		public Player playerone;
		public Player playertwo;
		//Constructor
		//, I want the game of RPSLS to be at minimum a ‘best of three’ to decide a winner. 

		//member Methods
		public void Welcome()
		{
			Console.WriteLine("welcome to Rock,paper,scissars,lizard,spock!!!");
		}
		public void DisplayRules()
		{
			Console.WriteLine("you will have the opertunity to choose your method of attack and best out of three wins");
		}
		public void ChoosePlayer()
		{
			playerone = new Human();

			Console.WriteLine("Enter 1 for single player enter 2 for multiplayer.");
			int userInput = Convert.ToInt32(Console.ReadLine());
			if (userInput == 1)
			{
				Console.WriteLine("You have chosen single player!!");
				playertwo = new Computer();
			}
			else if (userInput == 2)
			{
				Console.WriteLine("You have chosen multiplayer!!");
				playertwo = new Human();
			}
			else 
			{

			}

		}
		






	}
}
