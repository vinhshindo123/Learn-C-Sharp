using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_2
{
    internal class HinhVuong:Hinh
    {
        public double Canh { get; set; }
        public HinhVuong() { }
        public HinhVuong(double a):base()
        {
            this.Canh = a;
        }

        public override double TinhChuVi()
        {
            return 4 * Canh;
        }

        public override double TinhDienTich()
        {
            return Canh * Canh;
        }
    }
}
