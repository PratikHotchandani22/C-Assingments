using MusicFilmsComputer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicFilmsComputer.Models
{
    public class Films : Computer,IMusicMovies
    {
        public string director, mainActor, mainActress;

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void RetrieveInformation()
        {
            throw new NotImplementedException();
        }
    }
}
    