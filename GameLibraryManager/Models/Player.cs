using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibraryManager.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public GameStats Stats { get; set; }

        public Player()
        {
            Stats = new GameStats();
        }
    }
}
