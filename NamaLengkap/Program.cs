using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamaLengkap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nama;
            Console.WriteLine("Masukan nama panggilan : ");
            nama = Console.ReadLine();
            if (nama == "Abdillah")
            {
                Console.WriteLine("Nama : Abdillah Hakim");
                Console.WriteLine("Umur : 15 Tahun");
                Console.WriteLine("Asal : Cilacap");
            }
            else if(nama == "Faikhaa")
            {
                Console.WriteLine("Nama : Faikhaa 'Adzroo Kaamila Qurrota'aina");
                Console.WriteLine("Umur : 16 Tahun");
                Console.WriteLine("Asal : Jogja");
            }
            else if(nama == "Rezy")
            {
                Console.WriteLine("Nama : Fahrezy Shiham Muttaki");
                Console.WriteLine("Umur : 16 Tahun");
                Console.WriteLine("Asal : Kalimantan");
            }
            else if(nama == "Kenjiro")
            {
                Console.WriteLine("Nama : Kenjiro Keiji Putra Hermawan");
                Console.WriteLine("Umur : 15 Tahun");
                Console.WriteLine("Asal : Jogja");
            }
            else if(nama == "Vieri")
            {
                Console.WriteLine("Nama : Vieri Khairandy");
                Console.WriteLine("Umur : 15 Tahun");
                Console.WriteLine("Asal : Jogja");
            }
            else if(nama == "Dani")
            {
                Console.WriteLine("Nama : Dani Fatah Atmaja Wijaya");
                Console.WriteLine("Umur : 16 Tahun");
                Console.WriteLine("Asal : Bekasi");
            }
            else if(nama == "Kang Bahar")
            {
                Console.WriteLine("Nama : Baharrudin Uyun");
                Console.WriteLine("Umur : 26 (kayaknya)");
                Console.WriteLine("Asal : Pekalongan");
            }
            else
            {
                Console.WriteLine("Kamu siapa?");
            }

        }
    }
}
