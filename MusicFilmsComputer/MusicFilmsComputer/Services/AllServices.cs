using MusicFilmsComputer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicFilmsComputer.Services
{
    public class AllServices 
    {
        //public List<T> ResultList { get; set; }
        public List<Computer> computersList = new List<Computer>();
        public List<Films> filmsList = new List<Films>();
        public List<Music> musicList = new List<Music>();

        Music music = new Music();
        Computer computer = new Computer();
        Films films = new Films();

        public AllServices()
        {
            InitData();
        }

        private void InitData()
        {
            computersList = new List<Computer>
            {
                new Computer{name="West",code="0101",category="c#",size="2mb"}
            };

            filmsList = new List<Films>
            {
                new Films{name="Interstellar",category="Sci-fi",code="00",size="2hrs",director="Nolan",mainActor="Matthew",mainActress="Anne"}
            };

            musicList = new List<Music>
            {
                new Music{name="hello",category="music",code="01",seconds=231,size="2mb",singer="me"}
            };

        }

        public void GetDetails<T>()
        {
            //printing details of coputer
            if(typeof(T) == typeof(Computer))
            {
                foreach (var item in computersList)
                {
                    int count = 1;
                    Console.WriteLine(count +". NAME: " + item.name + " Code: " + item.code + " Category: " + item.category + " size: " + item.size);
                }
                //return computersList as List<T>;
            }

            //printing details of films
            if (typeof(T) == typeof(Films))
            {
                foreach (var item in filmsList)
                {
                    int count = 1;
                    Console.WriteLine(count + ". NAME: " + item.name + " Code: " + item.code + " Category: " + item.category + " size: " + item.size + " director: " + item.director + " main actor: " + item.mainActor + " main actress: " + item.mainActress);
                }
               
            }

            //printing details of music
            if (typeof(T) == typeof(Music))
            {
                foreach (var item in musicList)
                {
                    int count = 1;
                    Console.WriteLine(count + ". NAME: " + item.name + " Code: " + item.code + " Category: " + item.category + " size: " + item.size + " singer: " + item.singer + " seconds: " + item.seconds);
                    count++;
                }
                
            }


        }


        public void AddDetails<T>(T obj)
        {

            if (typeof(T) == typeof(Computer))
            {
                Computer comp = (Computer)Convert.ChangeType(obj, typeof(Computer));
                computersList.Add(comp);
            }

            if (typeof(T) == typeof(Music))
            {
                Music musc = (Music)Convert.ChangeType(obj, typeof(Music));
                musicList.Add(musc);
            }

            if (typeof(T) == typeof(Films))
            {
                Films films = (Films)Convert.ChangeType(obj, typeof(Films));
                filmsList.Add(films);
            }

        }

    }
}
