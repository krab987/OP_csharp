using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

        m1: Console.Write("Input row -->");

            int row = int.Parse(Console.ReadLine());
            int[][] a = new int[row][]; //виділення пам'яті під row рядків;
            for (int i = 0; i < a.Length; i++)
            {
                int col = row;
                a[i] = new int[col];//виділення пам'яті під col стовпців в рядку row
            }

            //Формування допоміжної діагоналі
            form_array(a);
            print(a);
            form_next(a);
            print(a);

            //Формування головної діагоналі 
            form_glav(a, row);
            print(a);

            form_glav2(a, row);
            print(a);




            Console.Write("Повторити?\n");
            Console.Write("Введи 1 \n");

            if (Console.ReadLine() == ("1")) goto m1;
        }
        static void form_glav(int[][] Mas, int r)
        {
            int p = Mas.Length - 1;

            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = new int[Mas.Length];
                for (int j = 0; j < Mas.Length; j++)
                {
                    if (i == j) { Mas[i][j] = 1; }
                    else
                    {

                        if (j > i) 
                        {
                            Mas[i][j] = 0; 
                        }
                        if (j < i) 
                        { 
                            Mas[i][j] = 0; 
                        }

                    }
                }

                p -= 1;
            }


        }
        static void form_glav2(int[][] Mas, int r)
        {
            Random m = new Random();

            int k = Mas.Length - 1;
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = new int[Mas.Length];
                for (int j = 0; j < Mas.Length; j++)
                {
                    if (i == j) { Mas[i][j] = m.Next(1, 10); }
                    else
                    {

                        if (j > i) 
                        { 
                            Mas[i][j] = 0; 
                        }
                        if (j < i) 
                        { 
                            Mas[i][j] = 1; 
                        
                        
                        }

                    }
                }
                k -= 1;
            }


        }

        static void form_array(int[][] Mas)
        {
            int k = Mas.Length - 1;
            for (int i = 0; i < Mas.Length; i++)
            {
                for (int j = 0; j < Mas.Length; j++)
                {
                    if (k == j) Mas[i][j] = 1;

                }
                k--;
            }

        }
        static void form_next(int[][] Mas)
        {
            Random m = new Random();
            int p = Mas.Length - 1;
            for (int i = 0; i < Mas.Length; i++)
            {
                for (int j = 0; j < Mas.Length; j++)
                {

                    if ((p >= i) || (p >= j)) Mas[i][j] = 3;
                    if ((j > p) && (j > p)) Mas[i][j] = 2;
                    if ((p == j)) Mas[i][j] = m.Next(1, 10);

                }
                p--;
            }

        }

        static void print(int[][] Mas)
        {
            for (int i = 0; i < Mas.Length; i++)
            {
                for (int j = 0; j < Mas[i].Length; j++)
                    Console.Write(Mas[i][j].ToString() + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }

}