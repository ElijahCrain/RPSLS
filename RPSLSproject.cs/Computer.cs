using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSproject.cs
{
	class Computer : Player
	{
		//child class


		//member Variables
		public string playersName;
		public string cortona;
		public Random rand;
		public int gestor;

		//Constructor


		public Computer()
		{
			score = 0;
			rand = new Random();
			
			

		}


		//member Methods
		
		
		public override void ChooseGesture()
		{//create a method for choosing a gesture that doesn't require input from a user

			gestor = rand.Next(5);
			chosenGesture = gestures[gestor];
		}

	}
}
