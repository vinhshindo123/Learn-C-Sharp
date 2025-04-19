using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_14
{
    internal class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo() { }

        public PhanSo(int tu, int mau)
        {
            this.TuSo = tu;
            this.MauSo = (mau == 0) ? 1 : mau;
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
            int ucln = UCLN(Math.Abs(TuSo), Math.Abs(MauSo));
            TuSo /= ucln;
            MauSo /= ucln;
            if (MauSo < 0)
            {
                TuSo = -TuSo;
                MauSo = -MauSo;
            }
        }

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public PhanSo Cong(PhanSo b)
        {
            int tu = TuSo * b.MauSo + MauSo * b.TuSo;
            int mau = MauSo * b.MauSo;
            PhanSo kq = new PhanSo(tu, mau);
            kq.RutGon();
            return kq;
        }

        public PhanSo Tru(PhanSo b)
        {
            int tu = TuSo * b.MauSo - MauSo * b.TuSo;
            int mau = MauSo * b.MauSo;
            PhanSo kq = new PhanSo(tu, mau);
            kq.RutGon();
            return kq;
        }

        public PhanSo Chia(PhanSo b)
        {
            if (b.TuSo == 0)
                throw new Exception("Không thể chia cho phân số có tử số bằng 0.");
            int tu = TuSo * b.MauSo;
            int mau = MauSo * b.TuSo;
            PhanSo kq = new PhanSo(tu, mau);
            kq.RutGon();
            return kq;
        }
    }
}
