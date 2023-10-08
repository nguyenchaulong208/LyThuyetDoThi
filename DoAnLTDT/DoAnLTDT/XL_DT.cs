using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DoAnLTDT
{
    public static class XL_DT
    {
        public static int n;
        public static int[,] data;

        //Kiem tra file co ton tai hay khong
        public static bool KiemTraFile(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File khong ton tai!!!");
                return false;
            }
            string[] lines = File.ReadAllLines(filename);
            n = int.Parse(lines[0]);
           // Console.WriteLine($"So n: {n}");
          
            DATA();
            for (int i = 1; i <= n; i++)
            {
                string t = lines[i] + " ";
                //Console.WriteLine(t);
                string[] Mang = new string[n + 1];
                Mang = t.Split(' ');
                int k = Convert.ToInt32(Mang[0]);
                for (int j = 1;j<=k;j++)
                {
                    data[(i - 1), Convert.ToInt32(Mang[2 * (j - 1) + 1])]= Convert.ToInt32(Mang[2*(j-1)+2]) ;
                    //Console.WriteLine(data[(i - 1), Convert.ToInt32(Mang[2 * (j - 1) + 1])] = Convert.ToInt32(Mang[2 * (j - 1) + 2]));
                }
                //Console.WriteLine(k);
                for (int m = 0; m <= n; m++)
                {
                    for (int r = 0; r <= n; r++)
                    {
                        Console.Write(data[m, r] + " ");
                    }
                    Console.WriteLine();
                }

                //    int k = Convert.ToInt32(Mang[0]);
                //    for(int j=1;j<=k;j++)
                //    {
                //        string ggg = (Mang[2 * (j - 1) + 1]);
                //        int g= Convert.ToInt32(ggg);
                //        int gg = Convert.ToInt32(Mang[2 * (j - 1) + 2]);
                //        data[i,g ] = gg ;
                //    }
                //}    
                //for(int i = 0;i<=n; i++)
                //{
                //    for(int j = 0;j<=n; j++)
                //    {
                //        Console.Write(data[i,j]+ " ");
                //    }
                //    Console.WriteLine();    
            }






                return true;
        }
       
        //TẠO DỰNG MẢNG 2 CHIỀU BAN ĐẦU
        public static void DATA()
        {
            data = new int[n + 1, n + 1];
            for(int i = 0;i<=n;i++)
            {
                for (int j = 0;j<=n;j++)
                {
                    data[i,j] = 0;
                  //  Console.Write(data[i, j]);
                }
               // Console.WriteLine();
            }
           
        }
        // CAT CHUOI DE TAO TRONG SO

        





        /*------------------------------------------------------------------------------------------------------------------
         * 
         *  //Tao va ghi file moi
        public static void LuuTruMaTranKe(int[,] MaTranKe)
        {
            data = new int[n + 1, n + 1];

            var filename = "App Data/data.txt";
            var filePatch = Path.GetFullPath(filename);
            using (StreamWriter fileData = new StreamWriter(filePatch))
            {
                fileData.WriteLine(n + 1);
                for (int i = 0; i < n + 1; i++)
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
            for (int i = 0; i < n; i++)
            {
                string[] tokens = file[i + 1].Split(' ');

                for (int tokensCount = 1; tokensCount < tokens.Length; tokensCount = tokensCount + 2)
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
        //public static void outputarray(int[,] arr)
        //{
        //    foreach (int i in arr)
        //    {
        //        Console.Write(i);
        //    }
        //}

        //    
        ------------------------------------------------------------------------------------------------------------------------------------------------------*/

    }
}
