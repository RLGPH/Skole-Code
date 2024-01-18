using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_For_Games
{
    public class Library
    {
        public int ID { get; set; }
        public int Epic {  get; set; }
        public int Steam { get; set; }
        public int Other {  get; set; }
        public Library(int id,int epic, int steam,int other) 
        { 
            ID = id;
            Epic = epic;
            Steam = steam;
            Other = other;
        }
    }
}
