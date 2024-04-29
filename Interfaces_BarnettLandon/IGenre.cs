using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_BarnettLandon
{
    internal interface IGenre
    {
        //defines the gets and sets for the other classes to inherit
        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        public string Describe();

    }
}
