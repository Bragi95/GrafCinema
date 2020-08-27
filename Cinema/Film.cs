using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema
{
    public class Film
    {
        public string NameFilm { get; set; }
        public int TimeFilm { get; set; }        
        

        public Film()
        {

        }

        private Film(string nameFilm, int timeFilm)
        {
            NameFilm = nameFilm;
            TimeFilm = timeFilm;
        }

        

    }
}
