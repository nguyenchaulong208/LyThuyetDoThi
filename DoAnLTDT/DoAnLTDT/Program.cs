﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTDT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string filename = "input.txt";
           Xuly.KiemTraFile(filename);
            Xuly.ChuyenDoiMTK(filename);
            Xuly.OutputArray(Xuly.data);
           

        }
    }
}
