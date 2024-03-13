using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_For_Games
{
    public class Library
    {
        //not used for a lot
        public int ID { get; set; }

        //everything from here is used a lot more
        public bool Epic {  get; set; }
        public bool Steam { get; set; }
        public bool Other {  get; set; }
        public Library(int id,bool epic, bool steam,bool other) 
        { 
            ID = id;
            Epic = epic;
            Steam = steam;
            Other = other;
        }
    }
}