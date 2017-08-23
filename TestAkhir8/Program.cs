using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestAkhir8
{
    class Program
    {
        static void Main(string[] args)
        {
            int panjang;
            int lebar;
            int tinggi;
            int volume;

           
            Console.WriteLine("Aplikasi Perhitungan Bangun Ruang Balok \n");
            Console.Write("Masukan Panjang Balok :");
            panjang = int.Parse(Console.ReadLine());
            Console.Write("Masukan Lebar :");
            lebar = int.Parse(Console.ReadLine());
            Console.Write("Masukan Tinggi : ");
            tinggi = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Pertama Tama Kita Lakukan Perhitungan untuk Mendapatkan Volume Balok \n");
            Thread.Sleep(1000);
            Console.WriteLine("Rumus Nya Adalah : \n");
            Thread.Sleep(2000);
            Console.WriteLine("Volume = panjang x lebar x tinggi \n");
            Thread.Sleep(2000);
            volume = panjang * lebar * tinggi;
            Console.WriteLine("Diketahui : P ={0}CM, L = {1}CM, Tinggi = {2}CM", panjang, lebar, tinggi);
            Console.WriteLine();
            Thread.Sleep(3000);
            Console.WriteLine("Maka V = {0}CM x {1}CM x {2}CM = {3}CM", panjang, lebar, tinggi, volume);

            Console.ReadKey();

            
        }
    }
}
