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
        // Internal list to store players
        private readonly List<Player> playerList = new();

        public void AddPlayer(Player player)
        {
            playerList.Add(player);
            AppLogger.Instance.Log($"Player added: {player.UserName}");
        }

        // Search player by ID
        public Player SearchById(int id)
        {
            foreach (var player in playerList)
            {
                if (player.PlayerId == id)
                {
                    return player;
                }
            }
            return null;
        }

        // Sort players by hours played in descending order
        public void SortByHoursPlayed()
        {
            for (int i = 0; i < playerList.Count - 1; i++)
            {
                int maxIndex = i;

                for (int j = i + 1; j < playerList.Count; j++)
                {
                    if (playerList[j].Stats.HoursPlayed > playerList[maxIndex].Stats.HoursPlayed)
                    {
                        maxIndex = j;
                    }
                }

                var temp = playerList[i];
                playerList[i] = playerList[maxIndex];
                playerList[maxIndex] = temp;
            }
        }

        // Get all players
        public List<Player> GetAllPlayers()
        {
            return playerList;
        }

        // Load players from a given list
        public void LoadPlayers(List<Player> players)
        {
            playerList.Clear();
            playerList.AddRange(players);
        }
    }
}





