﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m;
            double km;

            Console.Write("informe o valor em milha: ");
            m = double.Parse(Console.ReadLine());

            km = m * 1852 / 1000;

            Console.WriteLine("valor em km é: {0}", km);
        }
    }
}
