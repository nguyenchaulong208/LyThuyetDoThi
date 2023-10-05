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
        public static void LuuTruMaTranKe(int[,] MaTranKe)
        {
            data = new int[n +1 , n + 1];
            var filename = "App Data/data.txt";
            var filePatch = Path.GetFullPath(filename);
            using (StreamWriter fileData = new StreamWriter(filePatch))
            {
                fileData.WriteLine(n);
                for(int i = 0; i < n + 1; i++)
                {
                    for (int j = 0; j < n + 1; j++)
                    {
                        data[i, j] = MaTranKe[i, j];
                        fileData.Write(data[i, j]);
                        
                    }
                    fileData.WriteLine();
                }
                
            }
       }
#region //code loi
        
        //public static void ChuyenDoiMTK(string filename)
        //{

        //    int[,] newDuLieu = new int[n + 1, n + 1];
        //    string[] file = File.ReadAllLines(filename);
        //    for (int i = 0; i < n; i++)
        //    {
        //        string[] tokens = file[i + 1].Split(' ');
                
                    
                

        //        for (int tokensCount = 1; tokensCount < tokens.Length; tokensCount = tokensCount + 2)
        //        {
        //            for (int j = 0; j < n; j++)
        //            {
        //                newDuLieu[i, j] = int.Parse(tokens[tokensCount]);

        //            }
        //        }
        //    }
        //    LuuTruMaTranKe(newDuLieu);

        //}
    #endregion
        //Chuyen doi danh sach ke sang ma tran ke
        public static void ChuyenDoiMTK(string filename)
        {
        
        int[,] newDuLieu = new int[n + 1, n + 1];
                string[] file = File.ReadAllLines(filename);
            for (int i = 0; i<n+1; i++)
            {
                string[] tokens = file[i + 1].Split(' ');

                for (int tokensCount = 1; tokensCount<tokens.Length; tokensCount = tokensCount + 2)
                {
                    int vertex = int.Parse(tokens[tokensCount]);
                    //Console.WriteLine(vertex);
                    //Console.WriteLine("---");
                    // Lưu đỉnh vào ma trận kề
                    newDuLieu[i, vertex] = 1; // Giả sử đỉnh được đánh số từ 1, nếu đánh số từ 0 thì chỉ cần newDuLieu[i, vertex] = 1;
                   

                }
            }
                LuuTruMaTranKe(newDuLieu);
            

        }
        //check output array
        public static void OutputArray(int[,] arr)
        {
            for(int i = 0; i < n + 1; i++)
            {
                for(int j = 0; j < n + 1; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            
        }
        //Kiem tra do thi co huong hay khong
        public static bool KiemTraDoThi(int[,] arr)
        {
            for(int i = 0; i < n + 1; i++)
            {
                for(int j = 0; j < n + 1; j++)
                {
                    if (arr[i, j] != arr[j, i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }   
        //Kiem tra canh khuyen
        public static int KiemTraCanh(int[,] arr)
        {
            int count = 0;
            for(int i = 0; i < n + 1; i++)
            {
                for(int j = 0; j < n + 1; j++)
                {
                    if (arr[i, i] != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
            
        }
    }
}
