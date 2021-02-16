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
		public string Name;


		//Constructor
		public Human()
		{
			score = 0;
		}



		
		public override void ChooseGesture()
		{
			Console.WriteLine("Choose the gesture you would like");
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
