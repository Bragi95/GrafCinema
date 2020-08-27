using NUnit.Framework;

namespace Cinema.tests
{
    public class CinemaTest
    {
        Cinema cinema = new Cinema();
        int quantityHall;
        [SetUp]
        public void Setup()
        {
            cinema.films.Add(new Film() { NameFilm = "������", TimeFilm = 60 });
            cinema.films.Add(new Film() { NameFilm = "������ 2", TimeFilm = 120 });
            cinema.films.Add(new Film() { NameFilm = "������ 3", TimeFilm = 180 });

            cinema.QuantityHall = 3;
            quantityHall = cinema.QuantityHall;
        }

        [Test]
        public void VeryOptimalHallTest()
        {
            cinema.AllKindsOfHalls();

            for (int i = 0; i < quantityHall; i++)
            {
                Assert.AreEqual(cinema.CinemaHalls[i].RemainingTime, 0);
            }            
        }
    }
}