using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemilu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int umur;
            Console.WriteLine("Masukan umur");
            umur = int.Parse(Console.ReadLine());

            if(umur > 17)
            {
                Console.WriteLine("Boleh mencoblos");
            }
            else
            {
                Console.WriteLine("Tidak boleh mencoblos");
            }
        }
    }
}
