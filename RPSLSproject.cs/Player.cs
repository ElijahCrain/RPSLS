using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSproject.cs
{
	// Make this class an abstract  class
	class Player
	{
		//parentclass
		//member Variables
		
		
		public List<string> gestures;
		public int score;
		public string chosenGesture;


		//Constructor
		public Player()
		{
			gestures = new List<string>();
			string rock = "rock";
			string paper = "paper";
			string scissors = "scissors";
			string lizard = "lizard";
			string spock = "spock";

			gestures.Add(rock);
			gestures.Add(paper);
			gestures.Add(scissors);
			gestures.Add(lizard);
			gestures.Add(spock);

		
		}



		//member Methods

		// Make this method an abstract method signature
		// Now the below method will only be a method signature
		// Each child class will override and implement the method themselves
		public virtual int ChooseGesture()
		{
			Console.WriteLine("chose the gester you would like");
			for (int i = 0; i < gestures.Count; i++)
			{
				Console.WriteLine("press " + i + " for " + gestures[i] );
			}
			string response = Console.ReadLine();
			int convertResponse = Int32.Parse(response);
			return convertResponse;
			//give a value to chosenGesture member varaible
		}


	}
}
