using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort_console
{
    class Program
    {
       void bubble_sort(string[] array_one)
        {
            for(int i=0;i<array_one.Length-1;i++)
            {

            }
            
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] one = new string[5];
            int size = one.Length;
            int lenght = 5;
           /* for (int i=0;i<5;i++)//заполнение рандомом массива
            {
                for (int n = 0; n < 5; n++)
                {
                    one[i] =one[i]+Convert.ToChar(rnd.Next('a', 'a' + 27)).ToString();
                }
            }*/
            one[0]="aaaaa";
            one[1] = "ccccc";
            one[2] = "eeeee";
            one[3] = "bbbbb";
            one[4] = "ddddd";

            Console.WriteLine("До сортировки:");
            for (int i = 0; i < 5; i++)//вывод массива
            {
                Console.WriteLine(one[i]);
                
            }
            Console.WriteLine("Кол-во строк "+size+" Длина строки "+lenght);
            string x = "";
            for(int i=lenght-1;i>0;i--)
             {
                int summ_l = 0, summ_pre = 0;
                byte[] res_last = System.Text.Encoding.Default.GetBytes(one[i]);//код символов последней строчки
                byte[] res_pre = System.Text.Encoding.Default.GetBytes(one[i - 1]);//код символов predпоследней строчки
                for (int e = size-1; e > 0; e--)
                {
                    summ_l = summ_l + res_last[e];
                    summ_pre = summ_pre + res_pre[e];
                   
                }
                Console.WriteLine(summ_l + " " + summ_pre);
                 
             }
            for(int i=0;i<size;i++)
            {
               // Console.WriteLine(one[i]);
            }
            Console.ReadKey();
        }
    }
}
