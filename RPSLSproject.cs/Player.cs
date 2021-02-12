using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSproject.cs
{
	class Player
	{
		//parentclass
		//member Variables
		public string rock;
		public string paper;
		public string scissors;
		public string lizard;
		public string spock;
		public List<string> gestures;



		//Constructor
		public Player()
		{
			gestures = new List<string>();
			rock = "rock";
			paper = "paper";
			scissors = "scissors";
			lizard = "lizard";
			spock = "spock";

			gestures.Add(rock);
			gestures.Add(paper);
			gestures.Add(scissors);
			gestures.Add(lizard);
			gestures.Add(spock);
		}



		//member Methods



	}
}
