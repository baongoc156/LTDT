using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoThi
{
    class test_DoThi
    {
        static void Main(string[] args)
        {
            //khai bao mang danh sach dinh ke
            List<LinkedList<int>> danhSachKe = new List<LinkedList<int>>();
            string fileName = "DonDoThiVoHuong.DAT";
            TienIch_DoThi.ghiFile(fileName);
            
            //tao danh sach dinh ke
            danhSachKe = TienIch_DoThi.docFile(fileName);

            Console.WriteLine("danh sach cac dinh ke: ");
            TienIch_DoThi.inDanhSachKe(danhSachKe);

            //bac cac dinh
            Console.Write("danh sach bac cua cac dinh: ");
            TienIch_DoThi.inList(TienIch_DoThi.taoDanhSachBac(danhSachKe));

            //kiem tra tinh lien thong
            if (TienIch_DoThi.kiemTraLienThong(danhSachKe) == true)
            {
                Console.WriteLine("\n do thi lien thong");
            }
            else
            {
                Console.WriteLine("\n do thi khong lien thong");
            }
        }
    }
}
