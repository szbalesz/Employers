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
            Console.WriteLine("Az összes dolgozó neve:");
            foreach (var d in dolgozok)
            {
                Console.Write($"{d.nev}, ");
            }
            int legjobbIndex = 0;
            for (int i = 0; i < dolgozok.Count; i++)
            {
                if (dolgozok[i].kereset > dolgozok[legjobbIndex].kereset)
                {
                    legjobbIndex = i;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"\nLegjobban keres: ID:{dolgozok[legjobbIndex].azonosito} Név:{dolgozok[legjobbIndex].nev}");
            Console.WriteLine();
            Console.WriteLine("10 év múlva nyugdíjas:");
            foreach (var d in dolgozok)
            {
                if (d.kor == 65 - 10)
                {
                    Console.WriteLine($"{d.nev} {d.kor}");
                }
            }
            int db = 0;

            foreach (var d in dolgozok)
            {
                if (d.kereset > 50000)
                {
                    db++;
                }
            }
            Console.WriteLine($"{db}-en keresnek többet mint 50 000!");
            Console.ReadLine();
        }
    }
}
