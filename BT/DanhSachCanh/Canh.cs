using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DanhSachCanh
{
    class Canh
    {
        private int dau;
        private int cuoi;
        private int trongSo;

        public int Dau
        {
            get
            {
                return dau;
            }

            set
            {
                dau = value;
            }
        }

        public int Cuoi
        {
            get
            {
                return cuoi;
            }

            set
            {
                cuoi = value;
            }
        }

        public int TrongSo
        {
            get
            {
                return trongSo;
            }

            set
            {
                trongSo = value;
            }
        }

        public Canh()
        {
        
        }

    

        public override string ToString()
        {
            return dau +"|"+cuoi+"|"+trongSo;
        }
    }
}
