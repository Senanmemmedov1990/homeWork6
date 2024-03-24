using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageHomeWork5
{
    internal class HiperMarket
    {
        public double Market(double deyer1, double deyer2, double deyer3)
        {
            double[] array = {deyer1, deyer2, deyer3 };
            Array.Sort(array);
            return array[1] + array[2];
        }
    }
}
