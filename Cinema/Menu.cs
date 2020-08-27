using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema
{
    public class Menu
    {
     
        Cinema cinema = new Cinema();
    
        public void MainMenu()
        {
            Console.Write("Введите действие: 1- Добавить фильм, 2- Указать кол-во залов, 3- показать расписание  ");
            int action = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case 1:
                    {
                        cinema.AddFilm();
                        break;
                    }
                case 2:
                    {
                        cinema.NumberOfHall();
                        break;
                    }
                case 3:
                    {
                        cinema.ShowTableTime();
                        break;
                    }
            }
           
        }

       
    }
}
