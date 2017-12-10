using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiedontallenus
{
    class Program
    {
        static void Main(string[] args)
        {
            int lämpötila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte =Console.ReadLine();
            lämpötila = int.Parse(syöte);

            // tiedostoon kirjoittaminen
            string tiedosto = @"C:\Windows\Temp\Lämpötila.txt";
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallenettu.");

            Console.ReadLine();
        }
    }
}
