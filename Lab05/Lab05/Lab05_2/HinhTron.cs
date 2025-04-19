using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_2
{
    internal class HinhTron:Hinh
    {
        public double BanKinh { get; set; }
        public HinhTron() { }
        public HinhTron(double r):base()
        {
            this.BanKinh = r;
        }
        public override double TinhChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }

        public override double TinhDienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }
    }
}
