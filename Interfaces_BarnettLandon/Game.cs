using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_BarnettLandon
{
    internal class Game : IGenre
    {
        //gets and sets for genre esrb and title
        public string Esrb { get ; set ; }
        public string Genre { get ; set ; }
        public string Title { get ; set ; }
        //Constructor for game class
        public Game(string esrbParam, string genreParam, string TitleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = TitleParam;
        }
        //plays game when started
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting! Game ON!");
        }
        //returns the title genre and rating
        public string Describe()
        {
            return $"{Title} is a(n) {Genre} game, rated {Esrb}";
        }
    }
}
