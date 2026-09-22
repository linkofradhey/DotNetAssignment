using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CricketTeam
{
 

    internal class cricket
    {
        static List<TeamPlayer> team = new List<TeamPlayer>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Add Player");
                Console.WriteLine("2. Display All Players");
                Console.WriteLine("3. Search Player");
                Console.WriteLine("4. Remove Player");
                Console.WriteLine("5. Display Player Count");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        TeamPlayer player = new TeamPlayer();

                        Console.Write("Enter Player ID: ");
                        player.PlayerId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Player Name: ");
                        player.PlayerName = Console.ReadLine();

                        Console.Write("Enter Age: ");
                        player.Age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Role: ");
                        player.Role = Console.ReadLine();

                        Console.Write("Enter Jersey Number: ");
                        player.JerseyNumber = Convert.ToInt32(Console.ReadLine());

                        AddPlayer(player);
                        break;

                    case 2:
                        DisplayPlayers();
                        break;

                    case 3:
                        Console.Write("Enter Player ID to Search: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        SearchPlayer(searchId);
                        break;

                    case 4:
                        Console.Write("Enter Player ID to Remove: ");
                        int removeId = Convert.ToInt32(Console.ReadLine());
                        RemovePlayer(removeId);
                        break;

                    case 5:
                        DisplayPlayerCount();
                        break;

                    case 6:
                        Console.WriteLine("Thank you for using Cricket Team Management System!");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        static void AddPlayer(TeamPlayer player)
        {
            team.Add(player);
            Console.WriteLine("Player added successfully.");
        }

        static void DisplayPlayers()
        {
            if (team.Count == 0)
            {
                Console.WriteLine("No players available.");
                return;
            }

            Console.WriteLine("\n--------------- CRICKET TEAM ----------------");
            Console.WriteLine("ID\tName\tAge\tRole\tJersey");

            foreach (var p in team)
            {
                Console.WriteLine($"{p.PlayerId}\t{p.PlayerName}\t{p.Age}\t{p.Role}\t{p.JerseyNumber}");
            }
        }

        static void SearchPlayer(int id)
        {
            TeamPlayer player = team.Where(p => p.PlayerId == id).FirstOrDefault();

            if (player != null)
            {
                Console.WriteLine("\nPlayer Found!");
                Console.WriteLine($"Player ID      : {player.PlayerId}");
                Console.WriteLine($"Player Name    : {player.PlayerName}");
                Console.WriteLine($"Age            : {player.Age}");
                Console.WriteLine($"Role           : {player.Role}");
                Console.WriteLine($"Jersey Number  : {player.JerseyNumber}");
            }
            else
            {
                Console.WriteLine("Player not found.");
            }
        }

        static void RemovePlayer(int id)
        {
            TeamPlayer player = team.Where(p => p.PlayerId == id).FirstOrDefault();

            if (player != null)
            {
                team.Remove(player);
                Console.WriteLine("Player removed successfully.");
            }
            else
            {
                Console.WriteLine("Player not found.");
            }
        }

        static void DisplayPlayerCount()
        {
            Console.WriteLine($"Total Players in Team: {team.Count}");
        }
    }
}