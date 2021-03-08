using System;

namespace Insertationsort
{
    class Program
    {
        static void InsertionSort(int[] data)
        {
                   for (int i = 1; i < data.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (data[j] < data[j - 1])
                    {
                        int tmp = data[j - 1];
                        data[j - 1] = data[j];
                        data[j] = tmp;
                    }
                    else
                        break;
                }
            }
        }

        static int[] GenerateData(int storlek)
        {
            Random rnd = new Random();
            int[] data = new int[storlek];

            for (int i = 0; i < data.Length; i++)
                data[i] = rnd.Next(data.Length);

            return data;
        }

        static void Main(string[] args)
        {
            int[] Storleks = new int[] { 10, 1000, 100000 };

            for (int i = 0; i < Storleks.Length; i++)
            {
                Console.WriteLine("Längden av Talet : " + Storleks[i]);
                int[] data = GenerateData(Storleks[i]);

                Console.WriteLine("Talen är sorterade");
                DateTime startTid = DateTime.Now;
                InsertionSort(data);
                TimeSpan deltaTid = DateTime.Now - startTid;
                Console.WriteLine("Soteringstiden : {0:0.00} ms. \n", deltaTid.TotalMilliseconds);

            }
        }
    }
}



