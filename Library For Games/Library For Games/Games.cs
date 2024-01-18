using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_For_Games
{
    public class Games
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hours {  get; set; }
        
        public Games(string gamename, string description,int hours)
        {
            Name = gamename;
            Description = description;
            Hours = hours;
        }
    }
}
