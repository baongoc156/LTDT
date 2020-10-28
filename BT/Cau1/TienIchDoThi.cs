using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LTDT_EX
{
    class TienIchDoThi
    {
        public static void WriteFile(string fileName)
        {

            int soDinh = 6;
            int soCanh = 9;
            //Danh sach cac dinh ke
            string s0 = "1,2,3";
            string s1 = "0,2,3,4";
            string s2 = "0,1,4";
            string s3 = "0,1,5";
            string s4 = "1,2,5";
            string s5 = "3,5";

            try
            {
                BinaryWriter bw = new BinaryWriter(new FileStream(fileName, FileMode.Create));
                bw.Write(soDinh);
                bw.Write(soCanh);
                bw.Write(s0);
                bw.Write(s1);
                bw.Write(s2);
                bw.Write(s3);
                bw.Write(s4);
                bw.Write(s5);
                bw.Close();
            }
            catch (Exception)
            {

                throw;
            }


        }

        public static List<LinkedList<int>> ReadFile(string fileName)
        {
            List<LinkedList<int>> danhSachKe = new List<LinkedList<int>>();
            BinaryReader br = new BinaryReader(new FileStream(fileName, FileMode.Open));
            string s0 = "";
            int x = 0;
            try
            {
                int soDinh = br.ReadInt32();
                int soCanh = br.ReadInt32();

                for (int i = 0; i < soDinh; i++)
                {
                    LinkedList<int> t = new LinkedList<int>();

                    s0 = br.ReadString();
                    if (s0 != "")
                    {
                        string[] dsDinhKe = s0.Split(',');
                        for (int j = 0; j < dsDinhKe.Length; j++)
                        {
                            x = int.Parse(dsDinhKe[j]);
                            t.AddLast(x);
                        }
                    }
                    danhSachKe.Add(t);

                }



            }
            catch (Exception)
            {

                throw;
            }

            return danhSachKe;
        }

        public static void Print(List<LinkedList<int>> ds)
        {
            int x = 0;
            foreach (LinkedList<int> item in ds)
            {
                Console.Write(x + " | ");
                foreach (int i in item)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
                x++;
            }
        }


        static void InDanhSachBacDinh(List<LinkedList<int>> ds)
        {
            int x = 0;
            Console.WriteLine("Bac cua dinh: ");
            foreach (LinkedList<int> item in ds)
            {
                Console.WriteLine("{0} | {1}", x, item.Count);
                x++;
            }
        }

  
        public static int[][] chuyenDSKeThanhMaTranKe(List<LinkedList<int>> danhSachKe)
        {
            int[][] maTranKe = new int[danhSachKe.Count][];

            for (int i = 0; i < danhSachKe.Count; i++)
            {
                maTranKe[i] = new int[danhSachKe.Count];

                foreach (int x in danhSachKe[i])
                {
                    maTranKe[i][x] = 1;
                }

            }
            return maTranKe;
        }

     
        public static void inMaTran(int[][] mt)
        {
            for (int i = 0; i < mt.GetLength(0); i++)
            {
                for (int j = 0; j < mt.GetLength(0); j++)
                {
                    Console.Write(mt[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        // Danh sach bac cac dinh
        public static void InFileDanhSachBacDinh(string fileName, List<LinkedList<int>> ds)
        {
            BinaryWriter bw;
            int x = 0;
            int[] danhSachBacDinh = new int[ds.Count];

            try
            {
                bw = new BinaryWriter(new FileStream(fileName, FileMode.Create));
                for (int i = 0; i < danhSachBacDinh.Length; i++)
                {
                    bw.Write(i);
                }
            }
            catch (Exception)
            {
                throw;
            }
            bw.Close();
        }
        //Xet tinh lien thong
        public static bool XetTinhLienThong(List<LinkedList<int>> danhSachKe)
        {
            bool ketQua = true;
            int[] dinhDaXet = new int[danhSachKe.Count];
            Queue<int> hangDoi = new Queue<int>();
            int dinhXet = -1;

            dinhDaXet[1] = 1;
            hangDoi.Enqueue(0);

            while (hangDoi.Count > 0)
            {
                dinhXet = hangDoi.Dequeue();
                if (danhSachKe[dinhXet].Count != 0)
                {
                    foreach (int x in danhSachKe[dinhXet])
                    {
                        if (dinhDaXet[x] == 0)
                        {
                            dinhDaXet[x] = 1;
                            hangDoi.Enqueue(x);
                        }

                    }
                }
            }
            foreach (int x in dinhDaXet)
            {
                if (x == 0)
                {
                    ketQua = false;
                    break;
                }
            }
            return ketQua;
        }

    }
}
            


