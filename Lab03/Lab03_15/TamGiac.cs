using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_15
{
    internal class TamGiac:DaGiac
    {
        public TamGiac() : base() { }

        public TamGiac(int[] cacCanh) : base(3, cacCanh) { }

        public override void Nhap()
        {
            SoCanh = 3;
            CacCanh = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Cạnh {i + 1}: ");
                CacCanh[i] = int.Parse(Console.ReadLine());
            }
        }

        public override int TinhChuVi()
        {
            return CacCanh[0] + CacCanh[1] + CacCanh[2];
        }

        public double TinhDienTich()
        {
            double a = CacCanh[0], b = CacCanh[1], c = CacCanh[2];
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool LaTamGiacVuong()
        {
            int[] sorted = (int[])CacCanh.Clone();
            Array.Sort(sorted);
            return sorted[0] * sorted[0] + sorted[1] * sorted[1] == sorted[2] * sorted[2];
        }
    }
}
