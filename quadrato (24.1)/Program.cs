using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadrato__24._1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrato q = new Quadrato();

            Console.WriteLine("inserisci il lato:");
            q.Lato = float.Parse(Console.ReadLine());

            Console.WriteLine("l'area è: {0}", q.Lato * q.Lato);

            Console.ReadLine();
        }
    }
}
