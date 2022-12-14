using System;

namespace Bubble_Sort
{
    class Program
    {
        private int[] a = new int[20];
        private int n;

        public void read()
        {
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\n Array dapa mempunyai maksimal 20 elemen. \n)");

            }
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("---------------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<"+(i+1)+">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Elemen array yang telah tersusun");
            Console.WriteLine("--------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for(int i = 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[j] > a[j+1])
                    {
                        int temp;
                        temp = a[j];
                        a[j] = a[j+1];
                        a[j+1] = temp;  
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program mylist = new Program();
            mylist.read();
            mylist.BubbleSortArray();
            mylist.display();

            Console.WriteLine("\n\n Tekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}