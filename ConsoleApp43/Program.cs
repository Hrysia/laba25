using System;

namespace ConsoleApp43
{
    public class Program
    {


        public static void Main()
        {
            int n;
            int m;
            Console.WriteLine("Enter size of massive");
            Console.Write("Lines - ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns - ");
            m = Convert.ToInt32(Console.ReadLine());
            if (n == m)
            {

                int[,] c = new int[n, m];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"Data[{i},{j}]=");
                        c[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }



                int min = c[0, 0];
                int min_i = 0;

                int suma = 0;
                for (int i = 0; i < n; i++)
                {

                    for (int j = 0; j < m; j++)
                    {
                        if (min > c[i, j])
                        {
                            min_i = i;
                            min = c[i, j];

                        }

                    }

                }

                Console.WriteLine("Min = " + min);
                Console.WriteLine("Min_i = " + min_i);
                for (int i = 0; i < n; i++)
                {

                    suma += c[i, i];

                }
                Console.WriteLine("Suma = " + suma);


                for (int i = 0; i < n; i++) ;
                {
                    for (int j = 0; j < m; j++)
                    {
                        c[min_i, j] = suma;
                    }

                }
                
                for (int i = 0; i < n; i++)
                {

                    for (int j = 0; j < m; j++)
                    {

                        Console.Write(c[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                               
            }
            else
            {
                Console.WriteLine("Incorrect array size");
            }
            
        }
    }
}
