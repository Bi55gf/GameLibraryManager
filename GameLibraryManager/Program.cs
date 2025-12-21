using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibraryManager.Models;
using GameLibraryManager.Services;

class program
{
    // Entry point
    static void main()
    {
        var service = new PlayerService();
        var storage = new PlayerStorage();

        service.LoadPlayers(storage.Load());

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n1. Add player");
            Console.WriteLine("2. Search player");
            Console.WriteLine("3. Sort by hours played");
            Console.WriteLine("4. Save and exit");
            Console.WriteLine("Choice: ");

            if (!int.TryParse(Console.ReadLine(), out int option))
                continue;

            switch (option)
            {
                case 1:
                    AddPlayer(service);
                    break;
                case 2:
                    SearchPlayer(service);
                    break;
                case 3:
                    service.SortByHoursPlayed();
                    Console.WriteLine("Players Sorted.");
                    break;
                case 4:
                    storage.Save(service.GetAllPlayers());
                    exit = true;
                    break;
            }
        }
    }

    // Add a new player
    static void AddPlayer(PlayerService service)
    {
        Console.WriteLine("ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Hours Played: ");
        int hoursPlayed = int.Parse(Console.ReadLine());

        Console.WriteLine("High score: ");
        int score = int.Parse(Console.ReadLine());

        var player = new Player
        {
            PlayerId = id,
            Username = username,
            Stats =
            {
                HoursPlayed = hoursPlayed,
                HighestScore = score
            }    
        };

        service.AddPlayer(player);
    }

    // Search for a player by ID
    static void SearchPlayer(PlayerService service)
    {
        Console.WriteLine("Enter ID: ");
        int id = int.Parse(Console.ReadLine());

        var player = service.SearchById(id);

        if (player == null)
        {
            Console.WriteLine("Player not found.");
            return;
        }

        Console.WriteLine($"{player.UserName} | Hours: {player.Stats.HoursPlayed} | Score: {player.Stats.HighestScore}");
    } 
}