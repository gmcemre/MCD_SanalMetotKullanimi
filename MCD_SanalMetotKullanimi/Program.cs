using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_SanalMetotKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Televizyon T1 = new Televizyon();
            T1.ekranaYaz("Hangisi?");
            Console.WriteLine("******************");
            Urun U1 = new Urun();
            U1.ekranaYaz("Merhaba");
            Console.WriteLine("******************");
            baseClass B1 = new baseClass();
            B1.ekranaYaz("Merhaba");

            Console.ReadKey();
        }
    }
}
