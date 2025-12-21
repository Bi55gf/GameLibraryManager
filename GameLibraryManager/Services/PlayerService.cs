using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GameLibraryManager.Interfaces;
using GameLibraryManager.Models;
using GameLibraryManager.Utilities;

namespace GameLibraryManager.Services
{
    // Service class for managing players
    public class PlayerService : ISearchable, ISortable
    {
        private readonly List<Player> playerlist = new();

        public void AddPlayer(Player player)
        {
            playerlist.Add(player);
            AppLogger.Instance.Log($"Player added: {player.Name}");
        }

        // Search player by ID
        public Player SearchById(int id)
        {
            foreach (var player in playerlist)
            {
                if (player.PlayerId == id)
                {
                    return player;
                }
            }
            return null;
        }

        // Sort players by hours played in descending order
        public void SortByHoursPlayer()
        {
            for (int i = 0; i < playerlist.Count - 1; i++)
            {
                int maxIndex = i;

                for (int j = i + 1; j < playerlist.Count; j++)
                {
                    if (playerlist[j].Stats.HoursPlayed > playerlist[maxIndex].Stats.HoursPlayed)
                    {
                        maxIndex = j;
                    }
                }

                var temp = playerlist[i];
                playerlist[i] = playerlist[maxIndex];
                playerlist[maxIndex] = temp;
            }
        }

        // Get all players
        public List<Player> GetAllPlayers()
        {
            return playerlist;
        }

        // Load players from a given list
        public void LoadPlayers(List<Player> players)
        {
            playerlist.Clear();
            playerlist.AddRange(players);
        }
    }
}





