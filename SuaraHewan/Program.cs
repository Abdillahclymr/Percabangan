using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaraHewan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string suara = "Rawrrrrr";
            if(suara == "Meong")
            {
                Console.WriteLine("Ini adalah kucing");
            }
            else if(suara == "Rawrrrrr")
            {
                Console.WriteLine("Ini buaya");
            }
            else
            {
                Console.WriteLine("Ini bukan kucing");
            }
        }
    }
}
