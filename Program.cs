using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RoadTraffic_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int RoadLenght = 50;

            string[] right = new string[RoadLenght];
            string[] left = new string[RoadLenght];

            for (int i = 0; i < RoadLenght; i++)
            {
                right[i] = " ";
                left[i] = " ";
            }

            while (true)
            {
                for (int i = 0; i < RoadLenght; i++)
                {
                    right[i] = "O";

                    if (i > 0)
                    {
                        right[i - 1] = " ";
                    }
                    else
                    {
                        right[i] = " ";
                    }
                    if(i == RoadLenght - 1)
                    {
                        right[i] = " ";
                    }


                    left[(RoadLenght - 1) - i ] = "O";

                    if ((RoadLenght - 1) - i == RoadLenght - 1)
                    {
                        left[(RoadLenght - 1) - i] = " ";
                    }
                    else
                    {
                        left[(RoadLenght - 1) - i + 1] = " ";
                    }
                    if((RoadLenght - 1) - i == 0)
                    {
                        left[(RoadLenght - 1) - i] = " ";
                    }


                    for (int j = 0; j < RoadLenght; j++)
                    {
                        Console.Write(right[j]);
                    }
                    Console.WriteLine();
                    for (int j = 0; j < RoadLenght; j++)
                    {
                        Console.Write(left[j]);
                    }

                    Thread.Sleep(200);
                    Console.Clear();
                }
            }
        }
    }
}
