using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema
{
    public class CinemaHall
    {
        public int RemainingTime { get; set; }
        public List<Film> Sessions { get; set; }
        public CinemaHall() { }


        public CinemaHall(int remainingTime, List<Film> sessions)
        {
            RemainingTime = remainingTime;
            Sessions = sessions;            
        }

     
        public void ShowAllSessionsTheHall()
        {
            DateTime time = new DateTime(2020, 8, 20, 10, 00, 00);
            foreach (var i in Sessions)
            {                
                DateTime time2 = time.AddMinutes(i.TimeFilm);
                Console.WriteLine();
                Console.Write($"{time.ToShortTimeString()} - {time2.ToShortTimeString()} {i.NameFilm}");
                

                time = time2;
            }
        }
    }  
}
