using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMM2
{
    class Genre
    {
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public Genre()
        {
            code = "";
            name = "";
            description = "";
        }

    }
}
