using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace CalculatorConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string pilihan;
            string ulang;
            int a;
            int b;

            Console.Title = "---CALCULATOR APLICATION---";
        awal:
            Console.Clear();
            Console.WriteLine("Masukan Pilihan : ");
            Console.WriteLine(" 1. Penambahan");
            Console.WriteLine(" 2. Pengurangan");
            Console.WriteLine(" 3. Perkalian");
            Console.WriteLine(" 4. Pembagian");
            Console.Write("\nPilihan Anda : ");
            pilihan = Console.ReadLine();

            if (pilihan == "1")
            {
                Console.Write("Inputkan niai a = ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if (pilihan == "2")
            {
                Console.Write("Inputkan niai a = ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (pilihan == "3")
            {
                Console.Write("Inputkan niai a = ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (pilihan == "4")
            {
                Console.Write("Inputkan niai a = ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Yang Anda Masukan Salah");
                Console.WriteLine("\n");
                Console.WriteLine("Apakah ingin mengulangi ? (y / t ) \n");
                Console.Write("Pilihan Anda : ");
                ulang = Console.ReadLine();
                if (ulang == "y" | ulang == "Y")
                {
                    goto awal;
                }
                else if (ulang == "t" | ulang == "T")
                {
                    goto akhir;
                }
            }
            Console.WriteLine("Apakah ingin mengulangi ? (y / t ) \n");
            Console.Write("Pilihan Anda : ");
            ulang = Console.ReadLine();
            if (ulang == "y" | ulang == "Y")
            {
                goto awal;
            }
            else if (ulang == "t" | ulang == "T")
            {
                goto akhir;
            }
        akhir:
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
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