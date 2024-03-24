using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageHomeWork5
{
    internal class NotDigit
    {
        public void Digit(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                bool var = false;
                //int   x  =    0
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        // x eger artsa deyer 0 dan boyu olur o dan boyu eded true demekdi
                        // yenii x++
                        var = true;
                        break;
                    }
                }
                //if (x == 0)
                //{
                //    Console.WriteLine(numbers1[i]);

                //}
                if (!(var))
                {
                    Console.WriteLine(arr1[i]);
                }
            }
        }
    }
}
