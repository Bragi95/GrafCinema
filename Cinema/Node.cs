using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema
{
    public class Node
    {
        public List<Node> _nexts = new List<Node>();
        public int RemaningTimeWorkCinema { get; set; }

        public List<Film> CinemaSessions { get; set; }
       

        public void Create(List<Film> numbers, List<Film> segments = null)
        {
            CinemaSessions = segments;
            foreach (var i in numbers)
            {
                if (RemaningTimeWorkCinema >= i.TimeFilm)
                {
                    Node node = new Node() { RemaningTimeWorkCinema = RemaningTimeWorkCinema - i.TimeFilm };
                    _nexts.Add(node);
                    List<Film> newSegments = Copy(segments);
                    newSegments.Add(i);
                    node.Create(numbers, newSegments);
                }
            }
        }

        private List<Film> Copy(List<Film> segments)
        {
            List<Film> newSegments = new List<Film>();
            if (segments != null)
            {
                foreach (var i in segments)
                {
                    newSegments.Add(i);
                }
            }
            return newSegments;
        }

    }
}
