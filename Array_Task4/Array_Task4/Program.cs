using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество рядов:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество мест в каждом ряду:"); 
            int  m = Convert.ToInt32(Console.ReadLine());
            int[,] seats = new int[n, m];

            Console.WriteLine("Заполните ряды:");
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    seats[i, j] = Convert.ToInt32(row[j]); ;
                }
            }
            
            Console.WriteLine("Введите количество билетов для продажи:");
            int k = Convert.ToInt32(Console.ReadLine());

            int chosenRow = 0;
            for (int i = 0; i < n; i++)
            {
                int consecutiveSeats = 0;
                for (int j = 0; j < m; j++)
                {
                    if (seats[i, j] == 0)
                    {
                        consecutiveSeats++;
                        if (consecutiveSeats >= k)
                        {
                            chosenRow = i + 1;
                            break;
                        }
                    }
                    else
                    {
                        consecutiveSeats = 0;
                    }
                }
                if (consecutiveSeats >= k)
                {
                    break;
                }
            }
            Console.WriteLine(chosenRow);
            Console.ReadLine();
        }
    

    }
}
