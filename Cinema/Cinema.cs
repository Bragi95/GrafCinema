using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema
{
    public class Cinema 
    {
        public int QuantityHall { get; set; }
        public int RemainingTime { get; set; }
        public List<Film> films = new List<Film>();
        public List<CinemaHall> CinemaHalls = new List<CinemaHall>();

        int TimeWorkCinema = 720;

        Film film;

        public void NumberOfHall()
        {
            Console.Write("Введите кол-во залов : ");
            QuantityHall = Convert.ToInt32(Console.ReadLine());

            if(QuantityHall < 2)
            {
                Console.WriteLine("Фильмов должно быть больше 2х, добавте фильм!");
                NumberOfHall();
            }

        }

        public void AddFilm()
        {
            film = new Film();        
        
            try
            {
                Console.Write("Введите продолжительность фильма: ");
                film.TimeFilm = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Продолжительность фильма в минутах от 1 ");
                AddFilm();
            }

                Console.Write("Введите название фильма: ");
                film.NameFilm = Console.ReadLine();          

            if (film.NameFilm != null && film.TimeFilm > 0)
            {
                films.Add(film);
            }
            else
            {
                Console.WriteLine("Введите название фильма и продолжительность фильма в минутах");
                AddFilm();
            }
        }
        public void AllKindsOfHalls()
        {            
            Node node = new Node() { RemaningTimeWorkCinema = TimeWorkCinema };
            node.Create(films);
            FindAllPossibleSeas(node);

           CinemaHalls.Sort(new CinemaHallComparer());
        }

        public void ShowTableTime()
        {
            
            AllKindsOfHalls();
           
            for (int i = 1; i <= QuantityHall; i++)
            {
               
                Console.WriteLine();
                Console.WriteLine($"Зал {i}: ");
                CinemaHalls[i].ShowAllSessionsTheHall();
                Console.WriteLine();

            }
            Console.WriteLine();
        }

        public void FindAllPossibleSeas(Node node)
        {
            if (node._nexts.Count != 0)
            {
                foreach (Node n in node._nexts)
                {
                    FindAllPossibleSeas(n);
                }
            }
            else
            {
                CinemaHall cinemaHall = new CinemaHall(node.RemaningTimeWorkCinema, node.CinemaSessions);
                CinemaHalls.Add(cinemaHall);
            }
        }
    }
}
