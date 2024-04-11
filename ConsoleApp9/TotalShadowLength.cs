using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class TotalShadowLength
    {
        private int totalShadowLength;
        public void start()
        {
            Console.WriteLine("Введите количество отрезков:");
            int numSegments = int.Parse(Console.ReadLine());
            Otrezki[] otrezkis = new Otrezki[numSegments];
            for (int i = 0; i < numSegments; i++)
            {
                Console.WriteLine($"Введите начальную и конечную абсциссы отрезка {i + 1}:");
                int start = int.Parse(Console.ReadLine());
                int end = int.Parse(Console.ReadLine());
                if(start > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
                otrezkis[i] = new Otrezki(start, end);
            }
           
            for (int i = 0; i < otrezkis.Length; i++)
            {
                for (int j = i + 1; j < otrezkis.Length; j++)
                {
                    if (otrezkis[i].start > otrezkis[j].start)
                    {
                        var otrezk = otrezkis[i];
                        otrezkis[i] = otrezkis[j];
                        otrezkis[j] = otrezk;
                    }
                }
            }
            for (int i = 0; i < otrezkis.Length; i++)
            {
                Console.WriteLine($"{otrezkis[i].start},{otrezkis[i].end} ");
            }
            totalShadowLength = otrezkis[0].end - otrezkis[0].start;
            Console.WriteLine(totalShadowLength + " ");
            for (int i = 0; i < otrezkis.Length - 1; i++)
            {
                if (otrezkis[i + 1].start <= otrezkis[i].end)
                {
                    if (otrezkis[i + 1].end < otrezkis[i].end)
                    {
                        otrezkis[i + 1].end = otrezkis[i].end;
                        otrezkis[i + 1].start = otrezkis[i].start;
                    }
                    else
                    {
                        totalShadowLength = totalShadowLength - (otrezkis[i].end - otrezkis[i + 1].start) + (otrezkis[i + 1].end - otrezkis[i + 1].start);
                    }
                }
                else
                {
                    totalShadowLength += (otrezkis[i + 1].end - otrezkis[i + 1].start);
                }
                Console.WriteLine(totalShadowLength + " ");
            }
        }
    }
   

}
