using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSproject.cs
{
	class Program
	{
		static void Main(string[] args)
		{
			//PlayingField playingField = new PlayingField();
			//playingField.DisplayRules();
			Player player = new Player();
			player.ChooseGesture();

			Console.ReadLine();
		}
	}
}
