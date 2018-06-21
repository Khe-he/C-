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
            string[] one = new string[6];
            int size = one.Length-1;
            int lenght = 5;
           /* for (int i=0;i<5;i++)//заполнение рандомом массива
            {
                for (int n = 0; n < 5; n++)
                {
                    one[i] =one[i]+Convert.ToChar(rnd.Next('a', 'a' + 27)).ToString();
                }
            }
            one[size] = one[size - 1];*/
           /* one[0]="aaaaa";
            one[1] = "ccccc";
            one[2] = "eeeee";
            one[3] = "bbbbb";
            one[4] = "ddddd";
            one[5] = "ddddd";*/
            Console.WriteLine("До сортировки:");
            for (int i = 0; i < 5; i++)//вывод массива
            {
                Console.WriteLine(one[i]);
                
            }
            Console.WriteLine("Кол-во строк "+size+" Длина строки "+lenght);
            string x = "";
            for(int i=lenght;i>0;i--)
             {
                int summ_l = 0, summ_pre = 0;
                byte[] res_last = System.Text.Encoding.Default.GetBytes(one[i]);//код символов первой строчки
                byte[] res_pre = System.Text.Encoding.Default.GetBytes(one[i -1]);//код символов второй строчки
                for (int e = size-1; e > 0; e--)
                {
                    summ_l = summ_l + res_last[e];
                    summ_pre = summ_pre + res_pre[e];
                   
                }
                if(summ_l<summ_pre)
                {
                    x = one[i];
                    one[i] = one[i-1];
                    one[i-1] = x;

                }
                Console.WriteLine(i + " ");
                for (int z = 0; z < size; z++)
                {
                    Console.WriteLine(one[z]);
                }
            }

            Console.ReadKey();
        }
    }
}
