using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMM2
{
    class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public TimeSpan length { get; set; }
        public string director { get; set; }
        public double rating { get; set; }
        public string imagePath { get; set; }

        public Movie()
        {
            id = 0;
            title = "";
            year = 0;
            length = new TimeSpan(0);
            director = "";
            rating = 0;
            imagePath = "";

        }
    }
}
