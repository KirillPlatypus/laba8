using System;

namespace laba8
{
    class Program
    {
        static int TaskOne()
        {
            int n, sum = 0;
            Console.WriteLine("n = ");
            //ВВод строки и преобрзование её в int
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            Console.WriteLine("a[] = ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                //Вводим массив и сдесь же суммируем по условию
                if (a[i] % 2 != 0 && a[i] < 0)
                    sum += a[i];
            }
            return sum;
        }

        static int TaskTwo()
        {
            int n, m, max = Int32.MinValue, min = Int32.MaxValue;
            Console.WriteLine("n = ");
            //ВВод строки и преобрзование её в int
            
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("m = ");
            //ВВод строки и преобрзование её в int
            m = int.Parse(Console.ReadLine());

            int[][] A = new int[n][];

            for (int i = 0; i < n; i++)
            {
                A[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    A[i][j] = int.Parse(Console.ReadLine());
                    //Вводим матрицу и ищем максимальный и минимальный элементы
                    if (max < A[i][j])
                        max = A[i][j];
                    if (min > A[i][j])
                        min = A[i][j];
                }
            }
            return max * min;
        }
        static void Main()
        {
            int n, m, max = Int32.MinValue, min = Int32.MaxValue;
            Console.WriteLine("n = ");
            //ВВод строки и преобрзование её в int

            n = int.Parse(Console.ReadLine());

            Console.WriteLine("m = ");
            //ВВод строки и преобрзование её в int
            m = int.Parse(Console.ReadLine());

            int[][] A = new int[n][];

            for (int i = 0; i < n; i++)
            {
                A[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    A[i][j] = int.Parse(Console.ReadLine());
                    //Вводим матрицу и ищем максимальный и минимальный элементы
                    if (max < A[i][j])
                        max = A[i][j];
                    if (min > A[i][j])
                        min = A[i][j];
                }
            }
            Console.WriteLine(max*min);

        }
    }
}