using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibraryManager.Models
{
    // Class representing a player
    public class Player
    {
       public int PlayerId { get; set; }
       public string UserName { get; set; }
       public GameStats Stats { get; set; }

        public Player()
        {
            Stats = new GameStats();
        }
    }
}
