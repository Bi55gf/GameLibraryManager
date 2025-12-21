using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GameLibraryManager.Models;
using GameLibraryManager.Utilities;
using System.Text.Json;

namespace GameLibraryManager.Services
{
    // Service for saving and loading player data
    public class PlayerStorage
    {
        private const string FileName = "players.json";

        public void Save(List<Player> players)
        {
            try
            {
                var json = JsonSerializer.Serialize(players, new JsonSerializerOptions 
                { 
                    WriteIndented = true 
                });

                File.WriteAllText(FileName, json);
                AppLogger.Instance.Log("Player data saved successfully.");
            }
            catch
            {
                AppLogger.Instance.Log("Error saving player data.");
            }
        }

        // Load player data from file
        public List<Player> Load()
        {
            try
            {
                if (!File.Exists(FileName))
                    return new List<Player>();

                var json = File.ReadAllText(FileName);
                return JsonSerializer.Deserialize<List<Player>>(json) ?? new List<Player>();
            }
            catch
            {
                AppLogger.Instance.Log("Error loading player data.");
                return new List<Player>();
            }
        }
    }
}
