using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTDT
{
    public static class Xuly
    {
        public static int n;
        public static int[,] data;
        
        //Kiem tra file co ton tai hay khong
        public static bool KiemTraFile(string filename)
        {
            if(!File.Exists(filename))
            {
                Console.WriteLine("File khong ton tai!!!");
                return false;
            }
            string[]lines = File.ReadAllLines(filename);
            n = int.Parse(lines[0]);
            return true;
        }
        //Tao va ghi file moi
        public static void LuuTruMaTranKe(int[] MaTranKe)
        {
            var filename = "App Data/data.txt";
            var filePatch = Path.GetFullPath(filename);
            using (StreamWriter fileData = new StreamWriter(filePatch))
            {
                fileData.WriteLine(n);
                
            }
       }
        //Chuyen doi danh sach ke sang ma tran ke
        public static void ChuyenDoiMTK(string filename)
        {

            

        }
        //check output array
        public static void OutputArray(int[] arr)
        {
            
        }
    }
}
