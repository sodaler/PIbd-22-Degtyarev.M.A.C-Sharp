using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegtyarevBus
{
    public class BusComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.GetType().Name != y.GetType().Name)
            {
                return x.GetType().Name.CompareTo(y.GetType().Name);
            }
            if (x is Bus && y is DoubleDecker)
            {
                return 1;
            }
            if (x is DoubleDecker && y is Bus)
            {
                return -1;
            }
            if (x is Bus && y is Bus)
            {
                return ComparerBus(x as Bus, y as Bus);
            }
            if (x is DoubleDecker && y is DoubleDecker)
            {
                return ComparerDoubleDecker(x as DoubleDecker, y as DoubleDecker);
            }
            return 0;
        }

        private int ComparerBus(Bus x, Bus y)
       {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
       }

        private int ComparerDoubleDecker(DoubleDecker x, DoubleDecker y)
        {
            var res = ComparerBus(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.HeadLight != y.HeadLight)
            {
                return x.HeadLight.CompareTo(y.HeadLight);
            }
            if (x.SecondFloor != y.SecondFloor)
            {
                return x.SecondFloor.CompareTo(y.SecondFloor);
            }
            return 0;
        }
    }
}
