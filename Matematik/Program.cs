﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5,6);

            dortIslem.Topla(6, 9);

            dortIslem.Topla(8, 56);

            Console.ReadLine();
        }
    }
}
