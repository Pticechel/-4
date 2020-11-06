using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_5ф
{
    class Program
    {
        static void Main(string[] args)
        {
            Second();
        }

               static void  Second()
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N = Convert.ToInt32(Console.ReadLine());
            String str_all = Console.ReadLine();
            string[] str_elem = str_all.Split(' ');

            int[] mas = new int[N];
            for (int i = 0; i < N; i++)
            {
                mas[i] = Convert.ToInt32(str_elem[i]);
            }
            //Произведение чисел меньших 50
            int proizv = 1;
            for(int i = 0; i < N; i++)
            {
                if (mas[i] < 50)
                {

                    proizv *= mas[i];
                }
                
            }


            //Сумма всех чисел, больших среднего арифметического
            int s = 0, sum = 0;
            float sa = 0;
            for (int i = 0; i < N; i++)
            {
                s += mas[i];
            }
            sa = 1.0f * s / N;

            for(int i = 0; i<N; i++)
            {
                if (mas[i] > sa)
                    sum += mas[i];
            }
            //Минимальное число
            int min = 10000;
            for (int i = 0; i < N; i++)
            {
                if (min > mas[i])
                    min = mas[i];
            }
            Console.WriteLine(proizv);
            Console.WriteLine(sum);
            Console.WriteLine(min);
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
