using System;
using System.Collections.Generic;
using System.Text;

namespace assignment5
{
    internal class Spotify
    {
        static List<Song> songs = new List<Song>();
        static  void Main()
        {
        Start:
            Console.Write("please Enter \t1. Add Song \r\n\r\n2. Display All Songs \r\n\r\n3. Search Song \r\n\r\n4. Remove Song \r\n\r\n5. Display Song Count \r\n\r\n6. Exit   ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    string choice1;

                    do
                    {
                        Song song = new Song();

                        Console.Write("Enter Song ID: ");
                        song.SongID = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Song Name: ");
                        song.SongName = Console.ReadLine();

                        Console.Write("Enter Genre: ");
                        song.Genre = Console.ReadLine();

                        Console.Write("Enter Artist Name: ");
                        song.ArtistName = Console.ReadLine();

                        Console.Write("Enter Duration (Min): ");
                        song.DurationInMIn = Convert.ToInt32(Console.ReadLine());

                        AddSong(song);

                        Console.Write("Add another song? (Y/N): ");
                        choice1 = Console.ReadLine();

                    } while (choice1.ToUpper() == "Y");

                    DisplaySongs();
                    break;
                case 2:
                    DisplaySongs();
                    break;
                case 3:
                    Console.Write("Please enter \t 1. seach song my id \t 2. seacrh song by Name");
                    int SearchChoice = Convert.ToInt32(Console.ReadLine());
                    if (SearchChoice == 1)
                    {
                        Console.Write("Please Enter Song id to Search:");
                        int songCodeToSearch = Convert.ToInt32(Console.ReadLine());
                        SearchSongById(songCodeToSearch);
                        break;

                    }
                    else if (SearchChoice == 2)
                    {
                        Console.Write("Please Enter Song Name to Search:");
                        var songNameToSearch = Console.ReadLine();
                        SearchSongByName(songNameToSearch);
                        break;

                    }
                    else
                    {
                        Console.WriteLine("invalid choice");
                    }
                    break;
                case 4:
                    Console.Write("Please Enter SongCode to Remove:");
                    int songCOdetoRemove = Convert.ToInt32(Console.ReadLine());
                    RemoveSong(songCOdetoRemove);
                    DisplaySongs();
                    break;
                case 5:
                    DisplaySongCount();
                    break;
                case 6:
     
                    break;
                default: Console.WriteLine("invalid cjhioce");
                    break;

                 
            }
            Console.Write("Do you want to continue (yes/no):");
            string ans = Console.ReadLine();
            if (ans is "yes")
            {
                goto Start;
            }


        }
        static void AddSong(Song newSong) { 
            songs.Add(newSong);
        }

        static void DisplaySongs() { 
            Console.WriteLine($"total song are {songs.Count} songs");

            foreach (var s in songs)
            {
                Console.WriteLine($"{s.SongName} \t {s.ArtistName}\t {s.Genre}\t {s.DurationInMIn}");
            }
        }

        static void SearchSongById(int code) {
            var songBYid = songs.Where(s => s.SongID == code).FirstOrDefault();
            if (songBYid != null) {
                Console.WriteLine($"{songBYid.SongName} \t {songBYid.ArtistName}\t {songBYid.Genre}\t {songBYid.DurationInMIn}");
            }
            else
            {
                Console.WriteLine("not found");
            }
        }

        static void SearchSongByName(String Name) { 
            var songByName = songs.Where(s => s.SongName==Name).FirstOrDefault();

            if (songByName != null)
            {
                Console.WriteLine($"{songByName.SongName} \t {songByName.ArtistName}\t {songByName.Genre}\t {songByName.DurationInMIn}");

            }
            else {
                Console.WriteLine("song is not there");
            }
        }

        static void RemoveSong(int code) { 
            var removeSong = songs.Where(s=>s.SongID==code).FirstOrDefault();
            if (removeSong != null)
            {
                songs.Remove(removeSong);
            }
        }

        static void DisplaySongCount() {
            Console.WriteLine($"the total number of song { songs.Count} songs");
        }
    }
}
