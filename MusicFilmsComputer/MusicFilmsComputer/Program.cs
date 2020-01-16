using MusicFilmsComputer.Models;
using MusicFilmsComputer.Services;
using System;

namespace MusicFilmsComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer musicObj = new Music();
            Computer computer = new Computer();
            Computer filmsObj = new Films();

            AllServices allServices = new AllServices();
            bool more = true;
            while(more)
            {
                Console.WriteLine("hello user, What do you want to have fun with today?");
                Console.WriteLine("1. Computers");
                Console.WriteLine("2. Films");
                Console.WriteLine("3. Music");
                Console.WriteLine("4. Exit");

                int x = Convert.ToInt32(Console.ReadLine());
                switch(x)
                {
                    case 1:
                        bool compMore = true;
                        while(compMore)
                        {
                            Console.WriteLine("Entering to computer");
                            Console.WriteLine("1. Display all computer files");
                            Console.WriteLine("2. Add new computer file");
                            Console.WriteLine("3. Exit");

                            int compX = Convert.ToInt32(Console.ReadLine());
                            switch(compX)
                            {
                                case 1:
                                    allServices.GetDetails<Computer>();
                                    break;

                                case 2:
                                    
                                    allServices.AddDetails<Computer>(GettingDetailsFromUser(computer));
                                    
                                    break;

                                case 3:
                                    Console.WriteLine("Exiting..");
                                    compMore = false;
                                    break;
   
                            }
                        }
                        
                        break;

                    case 2:
                        bool filmsMore = true;
                        while (filmsMore)
                        {
                            Console.WriteLine("Entering to films");
                            Console.WriteLine("1. Display all films files");
                            Console.WriteLine("2. Add new films file");
                            Console.WriteLine("3. Exit");

                            int filmsX = Convert.ToInt32(Console.ReadLine());
                            switch (filmsX)
                            {
                                case 1:
                                    allServices.GetDetails<Films>();

                                    break;

                                case 2:
                                    allServices.AddDetails(GettingDataForFilms(GettingDetailsFromUser(computer)));
                                    break;

                                case 3:
                                    Console.WriteLine("Exiting..");
                                    filmsMore = false;
                                    break;

                            }

                        }

                        break;

                    case 3:
                        bool musicMore = true;
                        while (musicMore)
                        {
                            Console.WriteLine("Entering to music");
                            Console.WriteLine("1. Display all music files");
                            Console.WriteLine("2. Add new music file");
                            Console.WriteLine("3. Exit");

                            int musicX = Convert.ToInt32(Console.ReadLine());
                            switch (musicX)
                            {
                                case 1:
                                    allServices.GetDetails<Music>();

                                    break;

                                case 2:
                                    allServices.AddDetails(GettingDataForMusic(GettingDetailsFromUser(computer)));

                                    break;

                                case 3:
                                    Console.WriteLine("Exiting..");
                                    musicMore = false;
                                    break;

                            }

                        }

                        break;

                    case 4:
                        Console.WriteLine("Exiting..");
                        more = false;
                        break;
                }
            }
           
        }

        private static object GettingDataForMusic(Computer computer)
        {
            Music music = new Music();
            music.name = computer.name;
            music.size = computer.size;
            music.category = computer.category;
            music.code = computer.code;

            Console.WriteLine("enter name of singer");
            music.singer = Console.ReadLine();

            Console.WriteLine("Enter length of music file");
            music.seconds = Convert.ToInt32(Console.ReadLine());
            return music;
        }

        private static Films GettingDataForFilms(Computer computer)
        {
            Films films = new Films();
           // films = (Films)computer;
            films.name = computer.name;
            films.size = computer.size;
            films.category = computer.category;
            films.code = computer.code;
            //films.director = "Damyant";
            //films.mainActor = "Damyant";
            //films.mainActress = "Damyanti";
            Console.WriteLine("Enter name of director");
            films.director = Console.ReadLine();

            Console.WriteLine("Enter name of Main Actor");
            films.mainActor = Console.ReadLine();

            Console.WriteLine("Enter name of main Actress");
            films.mainActress = Console.ReadLine();

            return films;
        }

        private static Computer GettingDetailsFromUser(Computer computer)
        {
            Console.WriteLine("Enter name");
            computer.name = Console.ReadLine();

            Console.WriteLine("Enter size");
            computer.size = Console.ReadLine();

            Console.WriteLine("Enter category");
            computer.category = Console.ReadLine();

            Console.WriteLine("Enter code");
            computer.code = Console.ReadLine();

            return computer;
        }
    }
}
