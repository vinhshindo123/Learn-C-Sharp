using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_2
{
    internal class HinhChuNhat:Hinh
    {
        public double Dai { get; set; }
        public double Rong { get; set; }
        public HinhChuNhat() { }
        public HinhChuNhat(double dai, double rong):base()
        {
            this.Dai = dai;
            this.Rong = rong;
        }

        public override double TinhChuVi()
        {
            return 2 * (Dai + Rong);
        }

        public override double TinhDienTich()
        {
            return Dai * Rong;
        }
    }
}
