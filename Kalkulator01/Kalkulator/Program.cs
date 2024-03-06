using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            Console.WriteLine("Operasi Hitung");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("Pilih Operasi Hitung : ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Input nilai a : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Input nilai b : ");
            int b = int.Parse(Console.ReadLine());

            if(c == 1)
            {
                Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + Penjumlahan(a, b));
            }
            else if(c == 2)
            {
                Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
            }
            else if(c == 3)
            {
                Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + Perkalian(a, b));
            }
            else
            {
                Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + Pembagian(a, b));
            }

            Console.ReadKey(); 
        }
        static int Penjumlahan (int a, int b)
        {
            return a + b;
        }
        static int Pengurangan (int a, int b) 
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }

    }
}
