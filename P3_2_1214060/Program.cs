using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_1214060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var start = true;
            while (start)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Menu Persegi Panjang");
                Console.WriteLine("1. Hitunglah Luas Persegi Panjang Berikut");
                Console.WriteLine("2. Hitunglah Keliling Persegi Panjang Berikut");
                Console.WriteLine(" ");

                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "Hitunglah Luas Persegi Panjang Berikut":
                        Console.WriteLine("Menghitung luas persegi panjang ");
                        Console.Write("Panjang persegi panjang: ");
                        var panjang = int.Parse(Console.ReadLine());
                        Console.Write("Lebar persegi panjang: ");
                        var lebar = int.Parse(Console.ReadLine());
                        var luas = panjang * lebar;
                        Console.WriteLine("Berikut adalah luas persegi panjang " + luas);
                        break;

                    case "hitunglah luas persegi panjang berikut":
                        Console.WriteLine("Menghitung luas persegi panjang ");
                        Console.Write("Panjang persegi panjang: ");
                        var panjang3 = int.Parse(Console.ReadLine());
                        Console.Write("Lebar persegi panjang: ");
                        var lebar3 = int.Parse(Console.ReadLine());
                        var luas2 = panjang3 * lebar3;
                        Console.WriteLine("Berikut adalah luas persegi panjang " + luas2);
                        break;

                    case "Hitunglah Keliling Persegi Panjang Berikut":
                        Console.WriteLine("Menghitung keliling persegi panjang");
                        Console.Write("Panjang persegi panjang: ");
                        var panjang2 = int.Parse(Console.ReadLine());
                        Console.Write("Lebar persegi panjang: ");
                        var lebar2 = int.Parse(Console.ReadLine());
                        int keliling = (panjang2 * 2) + (lebar2 * 2);
                        Console.WriteLine("Berikut adalah keliling persegi panjang " + keliling);
                        break;

                    case "hitung keliling":
                        Console.WriteLine("Menghitung keliling persegi panjang");
                        Console.Write("Panjang persegi panjang: ");
                        var panjang4 = int.Parse(Console.ReadLine());
                        Console.Write("Lebar persegi panjang: ");
                        var lebar4 = int.Parse(Console.ReadLine());
                        int keliling2 = (panjang4 * 2) + (lebar4 * 2);
                        Console.WriteLine("Berikut adalah keliling persegi panjang " + keliling2);
                        break;

                    default: Console.WriteLine("Input tidak valid"); break;
                }
                Console.Write("Apakan anda ingin mengulangi lagi? (Y/T): ");
                var input = Console.ReadLine();
                if (input == "T" || input == "t")
                {
                    Console.WriteLine("Terimakasih telah menggunakan aplikasi ini");
                    start = false;
                }
                else
                {
                    start = true;
                }
            }
        }
    }
}
