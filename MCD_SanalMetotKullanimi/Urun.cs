﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_SanalMetotKullanimi
{
    public class Urun:baseClass 
    {
        public Urun()
        {
            Console.WriteLine("urun");
        }

        public override void ekranaYaz(string data)
        {
            Console.WriteLine("urun => "+ data );
        }
    }
}
