using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegtyarevBus
{
    public class BusStationOverflowException : Exception
    {
        public BusStationOverflowException() : base("На стоянке нет свободных мест")
        { }
    }
}
