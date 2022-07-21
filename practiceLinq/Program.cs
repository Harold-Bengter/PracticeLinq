using System;
using System.Collections.Generic;
using System.Linq;

//created list
List<String> VideoGames = new List<String>();

//Added video game name using Add
VideoGames.Add("Skyrim");
VideoGames.Add("MW2");
VideoGames.Add("Brute Force");
VideoGames.Add("Cod4");
VideoGames.Add("The Witcher 3");
VideoGames.Add("Borderlands 3");
VideoGames.Add("Cod2");


//Used each linq method
VideoGames.OrderBy(Game => Game.Length).ToList().ForEach(Game => Console.WriteLine(Game));