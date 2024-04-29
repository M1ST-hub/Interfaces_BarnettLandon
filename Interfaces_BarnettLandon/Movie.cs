using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_BarnettLandon
{
    internal class Movie : IGenre
    {
        //gets and sets for genre title and esrb
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Movie(string esrbParam, string genreParam, string TitleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = TitleParam;
        }
        //Quick message to say the method was called and to hush
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting! be quiet.");
        }
        //will return the title genre and esrb
        public string Describe()
        {
            return $"{Title} is a(n) {Genre} movie, rated {Esrb}";
        }
    }
}
