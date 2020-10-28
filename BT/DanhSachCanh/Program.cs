using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DanhSachCanh
{
    class Program
    {
        static void Main(string[] args)
        {
            TienIch_DoThi.GhiFile("test.DAT");
            List<Canh> danhSachCanh = TienIch_DoThi.DocFile("test.DAT");
            //Console.WriteLine(danhSachCanh.Count);
            TienIch_DoThi.In(danhSachCanh);


        }
    }
}
