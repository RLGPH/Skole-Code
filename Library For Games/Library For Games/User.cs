using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Library_For_Games
{
    public class User
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string UserRank {  get; set; }
        
        public User(int id, string name, string password, string userrank)
        {
            ID = id;
            Name = name;
            Password = password;
            UserRank = userrank;
        }
    }
}
