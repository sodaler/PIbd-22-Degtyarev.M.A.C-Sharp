using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegtyarevBus
{
    class BusStationAlreadyHaveException : Exception
    {
        public BusStationAlreadyHaveException() : base("На стоянке уже есть такой автобус")
        { }
    }
}
