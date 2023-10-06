using System;
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
            Console.WriteLine("Do An Ly Thuyet Do Thi");
            Console.WriteLine("1. Phan tich do thi.");
            Console.WriteLine("2. Duyet do thi.");
            Console.WriteLine("3. Tim cay khung nho nhat.");
            Console.WriteLine("4. Tim duong di ngan nhat.");
            Console.WriteLine("5. Tim chu trinh hoac duong di Euler.");
            Console.WriteLine("____");
            Console.Write("Chon yeu cau can thuc hien: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            string filename = "input.txt";
            Xuly.KiemTraFile(filename);
            Xuly.ChuyenDoiMTK(filename);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. Phan tich do thi.\n");
                   

                    Xuly.OutputArray(Xuly.data);

                    var check = Xuly.KiemTraDoThi(Xuly.data);
                    if (check == true)
                    {
                        Console.WriteLine("Do thi vo huong");
                    }
                    else
                    {
                        Console.WriteLine("Do thi co huong");
                    }
                    Console.WriteLine($"So dinh cua do thi: {Xuly.n}");
                    var checkCanh = Xuly.KiemTraCanh(Xuly.data);
                    
                        Console.WriteLine($"So canh khuyen la: {checkCanh}");
                    
                    
                    int soCanh = Xuly.DemCanh(Xuly.data);
                    Console.WriteLine($"So canh cua do thi la: {soCanh}");
                    break;
                case 2:
                    Console.WriteLine("2. Duyet do thi.");
                    

                    break;
            }


            
           
        }
    }
}
