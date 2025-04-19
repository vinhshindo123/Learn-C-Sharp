using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_1
{
    internal class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo() { }

        public PhanSo(int tu, int mau)
        {
            this.TuSo = tu;
            this.MauSo = mau != 0 ? mau : 1;
        }

        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());

            if (MauSo == 0)
            {
                Console.WriteLine("Mẫu số không được bằng 0! Gán mẫu số = 1");
                MauSo = 1;
            }
        }

        public void HienThi()
        {
            if (MauSo == 1)
                Console.WriteLine($"{TuSo}");
            else
                Console.WriteLine($"{TuSo}/{MauSo}");
        }

        public void RutGon()
        {
            TuSo = Math.Abs(TuSo);
            MauSo = Math.Abs(MauSo);
            while (MauSo != 0)
            {
                int temp = MauSo;
                MauSo = TuSo % MauSo;
                TuSo = temp;
            }
            int ucln = TuSo;
            TuSo /= ucln;
            MauSo /= ucln;
            if (MauSo < 0)
            {
                TuSo = -TuSo;
                MauSo = -MauSo;
            }
        }

        public PhanSo Cong(PhanSo b)
        {
            int tu = TuSo * b.MauSo + MauSo * b.TuSo;
            int mau = MauSo * b.MauSo;
            PhanSo kq = new PhanSo(tu, mau);
            kq.RutGon();
            return kq;
        }
    }
}
