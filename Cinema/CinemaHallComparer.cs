using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Cinema
{
    class CinemaHallComparer : IComparer<CinemaHall>
    {
        public int Compare([AllowNull] CinemaHall x, [AllowNull] CinemaHall y)
        {
            if(x.RemainingTime > y.RemainingTime)
            {
                return 1;
            }

            if(x.RemainingTime == y.RemainingTime)
            {
                return 0;
            }
            return -1;
        }
    }
}
