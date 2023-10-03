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
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                        fileData.WriteLine(MaTranKe[i] + " ");
                    fileData.WriteLine();
                }
            }
       }
        //Chuyen doi danh sach ke sang ma tran ke
        public static void ChuyenDoiMTK(string filename)
        {

            int[] newMaTranKe = new int[n + 1];

            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < n; i++)
            {
                string[] line = lines[i + 1].Split(' ');

                for (int j = 1; j < lines.Length; j = j + 2)
                {
                    newMaTranKe[i] = Convert.ToInt32(line[j]);
                }

            }

            LuuTruMaTranKe(newMaTranKe);

        }
        //output array
        public static void OutputArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
