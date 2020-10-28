using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDT_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            TienIchDoThi.WriteFile("DoThiVoHuong.DAT");
            List<LinkedList<int>> ds = TienIchDoThi.ReadFile("DoThiVoHuong.DAT");

            int[][] test =  TienIchDoThi.chuyenDSKeThanhMaTranKe(ds);
            TienIchDoThi.inMaTran(test);


            TienIchDoThi.Print(ds);
        }
    }
}
