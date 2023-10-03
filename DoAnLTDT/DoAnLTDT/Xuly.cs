using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTDT
{
    public class Xuly
    {
        public int n;
        public int[,] data;
        
        //Kiem tra file co ton tai hay khong
        public bool KiemTraFile(string filename)
        {
            if(!File.Exists(filename))
            {
                Console.WriteLine("File khong ton tai!!!");
                return false;
            }
            return true;
        }
       
    }
}
