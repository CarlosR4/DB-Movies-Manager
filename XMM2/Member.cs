using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMM2
{
    class Member
    {

        public int id { get; set; }
        public string name {get;set;}
        public DateTime dob { get; set; }
        public int memberType { get; set; }
        public string imagepath { get; set; }

        public Member()
        {
            id = 0;
            name = "";
            dob = new DateTime();
            memberType = 0;
            imagepath = "";
        }
    }
}
