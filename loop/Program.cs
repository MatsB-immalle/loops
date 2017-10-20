using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef je code in: ");  
            
            string code = Console.ReadLine();

            if (code == "1901")
            {
                Console.WriteLine("goed zo");
            }
            else
            {
                Console.WriteLine("fout");
            }
        }

    
    }
}
