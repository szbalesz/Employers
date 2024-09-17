using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Employers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fajl = File.ReadAllLines("tulajdonsagok_100sor.txt");
            List<dolgozo> dolgozok = new List<dolgozo>(); 
            foreach (string sor in fajl)
            {
                dolgozok.Add(new dolgozo(sor));
            }
            Console.WriteLine("Dolgozók:");
            foreach (var d in dolgozok)
            {
                Console.WriteLine(d.nev);
            }
            int legjobbIndex = 0;
            for (int i = 0; i < dolgozok.Count; i++)
            {
                if (dolgozok[i].kereset > dolgozok[legjobbIndex].kereset)
                {
                    legjobbIndex = i;
                }
            }
            Console.WriteLine("Legjobban keres: "+dolgozok[legjobbIndex].nev);
            

            Console.ReadLine();
        }
    }
}
