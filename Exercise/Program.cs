using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class program
    {
        private int[] d = new int[25];
        private int n;

        public void read()
        {
            while (true)
            {
                Console.WriteLine("Masukkan banyaknya elemen: ");
                string s = Console.ReadLine();
                n = int.Parse(s);
                if (n <= 25)
                    break;
                else
                    Console.WriteLine("\nMaksimal elemen adalah 25.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("---------------------");

            for(int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                d[i] = Int32.Parse(s1);
            }
        }

        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("================================");
            Console.WriteLine("Element array yang telah tersusun");
            Console.WriteLine("================================");
            for(int dk = 2; dk < n; dk++)
            {
                Console.WriteLine(d[dk]);
            }
            Console.WriteLine("");
        }

        public void exercise1Array()
        {
            for(int i = 1; i < n; i++)
            {
                for(int dk = 2; dk < n - i; dk++)
                {
                    if (d[dk] > d[n - 1])
                    {
                        int temp;
                        temp = d[dk];
                        d[dk] = d[n - 1];
                        d[n - 1] = temp; 
                    }
                }
            }
        }
        
        static void Main(string[] args)
        {
            program myList = new program();
            myList.read();
            myList.exercise1Array();
            myList.display();
            Console.WriteLine("\n\nTekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}
