﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_For_Games
{
    public class Game_S
    {
        //no where in the code the ID can be changed any how
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hours { get; set; }
        //not really used for anything
        public int ForignkeyID { get; set; }
        public Game_S(int id,string name,string description,int hours,int Fkey) 
        {
            ID = id;
            Name = name;
            Description = description;
            Hours = hours;
            ForignkeyID = Fkey;
        }
    }
}