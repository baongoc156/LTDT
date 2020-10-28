using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DanhSachCanh
{
    class TienIch_DoThi
    {
        /// <summary>
        /// Ghi file
        /// </summary>
        /// <param name="fileName"></param>
        public static void GhiFile(string fileName)
        {
            BinaryWriter bw;
            int soCanh = 6;
            int soDinh = 5;
            string s0 = "0,2,4";
            string s1 = "2,1,5";
            string s2 = "2,3,6";
            string s3 = "0,1,2";
            string s4 = "0,4,3";
            string s5 = "1,4,9";
            try
            {
                bw = new BinaryWriter(new FileStream(fileName, FileMode.Create));
                bw.Write(soDinh);
                bw.Write(soCanh);
                bw.Write(s0);
                bw.Write(s1);
                bw.Write(s2);
                bw.Write(s3);
                bw.Write(s4);
                bw.Write(s5);

            }
            catch (Exception)
            {
                return;
            }
            bw.Close();
        }

        /// <summary>
        /// doc file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<Canh> DocFile(string fileName)
        {
            BinaryReader br = new BinaryReader(new FileStream(fileName, FileMode.Open));
            List<Canh> danhSachCanh = new List<Canh>();
            int x = 0;
            string s0 = "";

            //doc file tao danh sach dinh dau cuoi
            try
            {
                int soDinh = br.ReadInt32();
                //Console.WriteLine(soDinh);
                int soCanh = br.ReadInt32();
                //Console.WriteLine(soCanh);


                //doc lan luot cac dong, tao linkedlist cac canh
                for (int i = 0; i < soCanh; i++)
                {
                    Canh t = new Canh();
                    s0 = br.ReadString();
                    if (s0 != "")
                    {
                        string[] danhSachDinh = s0.Split(new Char[] { ',' });
                        t.Dau = int.Parse(danhSachDinh[0]);
                        t.Cuoi = int.Parse(danhSachDinh[1]);
                        t.TrongSo = int.Parse(danhSachDinh[2]);

                    }
                    danhSachCanh.Add(t);
                }
            }
            catch (IOException e)
            {
            }
            br.Close();
            return danhSachCanh;

        }




        public static void In(List<Canh> list)
        {
            foreach (var item in list)
            {
                Console.Write(item);
                Console.WriteLine();
            }


        }

    }
}
