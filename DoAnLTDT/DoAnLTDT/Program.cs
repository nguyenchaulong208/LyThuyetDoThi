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
            
            string filename = "input.txt";
           Xuly.KiemTraFile(filename);
            Xuly.ChuyenDoiMTK(filename);
           
            Xuly.OutputArray(Xuly.data);
            
            var check = Xuly.KiemTraDoThi(Xuly.data);
            if(check == true)
            {
                Console.WriteLine("Do thi vo huong");
            }
            else
            {
                Console.WriteLine("Do thi co huong");
            }
            Console.WriteLine($"So dinh cua do thi: {Xuly.n}");
            var checkCanh = Xuly.KiemTraCanh(Xuly.data);
            if (checkCanh != 0)
            {
                Console.WriteLine($"So canh khuyen la: {checkCanh}");
            }
            else
            {
                Console.WriteLine("Khong co canh khuyen");
            }
        }
    }
}
