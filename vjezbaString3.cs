using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi neku recenicu:");
            
                string s = Console.ReadLine();
            string sVelika = s.ToUpper();
            string sMala = s.ToLower();
            string sPrvaTri = s.Substring(0,3);
            string sZadnjihPet = s.Substring(s.Length -5);
            string s8_11 = s.Substring(7,10);
            Console.WriteLine(sVelika);
            Console.WriteLine(sMala);
            Console.WriteLine(sPrvaTri);
            Console.WriteLine(sZadnjihPet);
            Console.WriteLine(s8_11);
            Console.ReadKey();
        }
    }
}
