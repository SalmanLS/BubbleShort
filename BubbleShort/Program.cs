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
        }
    }
}