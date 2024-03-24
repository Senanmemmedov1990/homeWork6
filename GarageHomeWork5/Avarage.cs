using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageHomeWork5;

public class Avarage
{
    public int CalcAvg()
    {
        Console.WriteLine("Imtahanlarin sayini yazin:");
        int num1 = int.Parse(Console.ReadLine());
        int[] arr = new int[num1];
        Console.WriteLine("Imtahanalarin neticelerini yazin:");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"{i + 1}) Imtahanin neticesi:");
            int num2 = int.Parse(Console.ReadLine());
            arr[i] = num2;
        }
        int deyer = 0;
        for (int i = 0;i < arr.Length; i++)
        {
            deyer += arr[i];
        }
        deyer /= arr.Length;
        return deyer;
    }
}
