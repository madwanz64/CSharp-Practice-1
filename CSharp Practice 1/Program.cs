using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu :");
            Console.WriteLine("1. Identitas");
            Console.WriteLine("2. Kalulator");
            Console.WriteLine("3. Perbandingan");
            Console.WriteLine("");
            Console.Write("Silakan pilih menu : ");
            int menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {
                Console.WriteLine("Nama Lengkap : Muhammad Ridwan Fauzi");
                Console.WriteLine("Profesi      : Back-End Developer");
                Console.WriteLine("Alamat       : Jln. Karet Karya II No. 19A");
            }
            else if (menu == 2)
            {
                Console.WriteLine("Menu Kalkulator :");
                Console.WriteLine("1. Penjumlahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Pembagian");
                Console.WriteLine("5. Sisa Bagi");
                Console.WriteLine("");
                Console.Write("Silakan pilih menu : ");
                int menuKalkulator = Convert.ToInt32(Console.ReadLine());
                if (menuKalkulator == 1)
                {
                    Console.Write("Masukkan angka pertama : ");
                    int angkaPertama = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan angka kedua   : ");
                    int angkaKedua = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil dari penjumlahan {0} dan {1} adalah {2}", angkaPertama, angkaKedua, angkaPertama + angkaKedua);
                }
                else if (menuKalkulator == 2)
                {
                    Console.Write("Masukkan angka pertama : ");
                    int angkaPertama = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan angka kedua   : ");
                    int angkaKedua = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil dari pengurangan {0} dan {1} adalah {2}", angkaPertama, angkaKedua, angkaPertama - angkaKedua);
                }
                else if (menuKalkulator == 3)
                {
                    Console.Write("Masukkan angka pertama : ");
                    int angkaPertama = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan angka kedua   : ");
                    int angkaKedua = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil dari perkalian {0} dan {1} adalah {2}", angkaPertama, angkaKedua, angkaPertama * angkaKedua);
                }
                else if (menuKalkulator == 4)
                {
                    Console.Write("Masukkan angka pertama : ");
                    int angkaPertama = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan angka kedua   : ");
                    int angkaKedua = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil dari pembagian {0} dan {1} adalah {2}", angkaPertama, angkaKedua, angkaPertama / angkaKedua);
                }
                else if (menuKalkulator == 5)
                {
                    Console.Write("Masukkan angka pertama : ");
                    int angkaPertama = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan angka kedua   : ");
                    int angkaKedua = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sia bagi dari {0} oleh {1} adalah {2}", angkaPertama, angkaKedua, angkaPertama % angkaKedua);
                }
                else
                {
                    Console.WriteLine("Menu yang Anda pilih tidak tersedia.");
                }
            }
            else if (menu == 3)
            {
                Console.Write("Masukkan angka pertama : ");
                int angkaPertama = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan angka kedua   : ");
                int angkaKedua = Convert.ToInt32(Console.ReadLine());
                if (angkaPertama > angkaKedua)
                {
                    Console.WriteLine("Angka {0} lebih besar dari {1}", angkaPertama, angkaKedua);
                }
                else if (angkaPertama < angkaKedua)
                {
                    Console.WriteLine("Angka {0} lebih kecil dari {1}", angkaPertama, angkaKedua);
                }
                else
                {
                    Console.WriteLine("Angka {0} sama dengan {1}", angkaPertama, angkaKedua);
                }
            }
            else
            {
                Console.WriteLine("Menu yang Anda pilih tidak tersedia.");
            }
        }
    }
}
