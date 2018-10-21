﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DisplayFile1021
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
                return;
            string[] lines = System.IO.File.ReadAllLines(args[0]);
            foreach(string item in lines)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
    }
}
