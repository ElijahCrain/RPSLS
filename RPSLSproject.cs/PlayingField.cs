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
		public int playerOneScore;
		public int playerTwoScore;
		public string name;
		//Constructor
		//, I want the game of RPSLS to be at minimum a ‘best of three’ to decide a winner. 
		public PlayingField()
		{
			playerOneScore = 0;
			playerTwoScore = 0;
			
		}
		
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
				 ChoosePlayer();
			}

		}  
		
		public void CompareGestureInput()
		{
			playerone.ChooseGesture();
			playertwo.ChooseGesture();

			if(playerone.chosenGesture == "rock" && playertwo.chosenGesture == "rock")
			{
				Console.WriteLine("it was a tie");
			}
			if (playerone.chosenGesture == "rock" && playertwo.chosenGesture == "paper")
			{
				Console.WriteLine("Player two won with paper!");
				playerTwoScore++;

			}
			if (playerone.chosenGesture == "rock" && playertwo.chosenGesture == "scissors")
			{
				Console.WriteLine("Player one won with rock!");
				playerOneScore++;
			}
			if (playerone.chosenGesture == "rock" && playertwo.chosenGesture == "lizard")
			{
				Console.WriteLine("Player one won with rock!");
				playerOneScore++;
			}
			if (playerone.chosenGesture == "rock" && playertwo.chosenGesture == "spock")
			{
				Console.WriteLine("Player two won with spock!");
				playerTwoScore++;
			}
			if (playerone.chosenGesture == "paper" && playertwo.chosenGesture == "paper")
			{
				Console.WriteLine("it was a tie");

			}
			if (playerone.chosenGesture == "paper" && playertwo.chosenGesture == "rock")
			{
				Console.WriteLine("Player one won with paper!");
				playerOneScore++;
			}
			if (playerone.chosenGesture == "paper" && playertwo.chosenGesture == "scissors")
			{
				Console.WriteLine("Player two won with scissors!");
				playerTwoScore++;
			}
			if (playerone.chosenGesture == "paper" && playertwo.chosenGesture == "lizard")
			{
				Console.WriteLine("Player two one with lizard!");
				playerTwoScore++;
			}
			if (playerone.chosenGesture == "paper" && playertwo.chosenGesture == "spock")
			{
				Console.WriteLine("Player one won with paper!");
				playerOneScore++;
			}
			if (playerone.chosenGesture == "scissors" && playertwo.chosenGesture == "scissors")
			{
				Console.WriteLine("it was a tie");

			}
			if (playerone.chosenGesture == "scissors" && playertwo.chosenGesture == "rock")
			{
				Console.WriteLine("Player two has won with rock!");
				playerTwoScore++;
			}
			if (playerone.chosenGesture == "scissors" && playertwo.chosenGesture == "paper")
			{
				Console.WriteLine("Player one won with scissors!");
				playerOneScore++;
			}
			if (playerone.chosenGesture == "scissors" && playertwo.chosenGesture == "lizard")
			{
				Console.WriteLine("Player one won with scissors!");
				playerOneScore++;
			}
			if (playerone.chosenGesture == "scissors" && playertwo.chosenGesture == "spock")
			{
				Console.WriteLine("Player two won with spock!");
				playerTwoScore++;
			}
			if (playerone.chosenGesture == "lizard" && playertwo.chosenGesture == "lizard")
			{
				Console.WriteLine("it was a tie");
			}
			if (playerone.chosenGesture == "lizard" && playertwo.chosenGesture == "rock")
			{
				Console.WriteLine("Player two won with rock!");
				playerTwoScore++;
			}
			if (playerone.chosenGesture == "lizard" && playertwo.chosenGesture == "paper")
			{
				Console.WriteLine("Player one won with lizard!");
				playerOneScore++;
			}
			if (playerone.chosenGesture == "lizard" && playertwo.chosenGesture == "scissors")
			{
				Console.WriteLine("Player two won with scissors!");
				playerTwoScore++;
			}
			if (playerone.chosenGesture == "lizard" && playertwo.chosenGesture == "spock")
			{
				Console.WriteLine("Player one won with lizard!");
				playerOneScore++;
			}
			if (playerone.chosenGesture == "spock" && playertwo.chosenGesture == "spock")
			{
				Console.WriteLine("it was a tie");
			}
			if (playerone.chosenGesture == "spock" && playertwo.chosenGesture == "rock")
			{
				Console.WriteLine("Player one won with spock!");
				playerOneScore++;
			}
			if (playerone.chosenGesture == "spock" && playertwo.chosenGesture == "paper")
			{
				Console.WriteLine("Player two won with paper!");
				playerTwoScore++;
			}
			if (playerone.chosenGesture == "spock" && playertwo.chosenGesture == "scissors")
			{
				Console.WriteLine("Player one won with spock!");
				playerOneScore++;
			}
			if (playerone.chosenGesture == "spock" && playertwo.chosenGesture == "lizard")
			{
				Console.WriteLine("Player two won with lizard!");
				playerTwoScore++;
			}

		}
		public void DisplayWinner()
		{
			if (playerOneScore >= 3)
			{
				Console.WriteLine($"player one has won the game!!!");
			}
			else if (playerTwoScore >= 3)
			{
				Console.WriteLine($"player two has won the game!!!");
			}
		}
		public void RunGame()
		{
			//order of method calls
			Welcome();
			DisplayRules();
			ChoosePlayer();
			while (playerOneScore <3 && playerTwoScore < 3)
			{
				CompareGestureInput();
			}
			DisplayWinner();
			PlayAgain();
			Console.ReadLine();
		}
		public void PlayAgain()
		{
			Console.WriteLine("Would you like to play again?? press 1 for yes 2 for no");
			int userInput = Convert.ToInt32(Console.ReadLine());
			if (userInput == 1)
			{
				RunGame();
				
			}
			else if (userInput == 2)
			{
				Console.WriteLine("Thank you for playing!!!!");
				Console.ReadLine();
				
			}
		}





	}
}
