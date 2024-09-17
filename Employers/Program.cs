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
        }
    }
}
