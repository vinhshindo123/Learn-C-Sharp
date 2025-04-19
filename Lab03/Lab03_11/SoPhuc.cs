using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_11
{
    internal class SoPhuc
    {
        private double phanThuc;
        private double phanAo;

        public SoPhuc() { }

        public SoPhuc(double a, double b)
        {
            this.phanThuc = a;
            this.phanAo = b;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhập số phức");
            Console.Write("Phần thực: ");
            phanThuc = double.Parse(Console.ReadLine());
            Console.Write("Phần ảo: ");
            phanAo = double.Parse(Console.ReadLine());
        }

        public void HienThi(string kiHieu)
        {
            string dau = phanAo >= 0 ? "+" : "-";
            Console.WriteLine($"{kiHieu}: z = {phanThuc} {dau} {Math.Abs(phanAo)}i");
        }

        public SoPhuc Cong(SoPhuc sp)
        {
            return new SoPhuc(phanThuc + sp.phanThuc, phanAo + sp.phanAo);
        }

        public SoPhuc Tru(SoPhuc sp)
        {
            return new SoPhuc(phanThuc - sp.phanThuc, phanAo - sp.phanAo);
        }

        public SoPhuc Nhan(SoPhuc sp)
        {
            double a = phanThuc * sp.phanThuc - phanAo * sp.phanAo;
            double b = phanThuc * sp.phanAo + phanAo * sp.phanThuc;
            return new SoPhuc(a, b);
        }

        public SoPhuc Chia(SoPhuc sp)
        {
            double mau = sp.phanThuc * sp.phanThuc + sp.phanAo * sp.phanAo;

            if (mau == 0)
            {
                Console.WriteLine("Không thể chia cho số phức có cả phần thực và phần ảo bằng 0.");
                return new SoPhuc(0, 0);
            }

            double a = (phanThuc * sp.phanThuc + phanAo * sp.phanAo) / mau;
            double b = (phanAo * sp.phanThuc - phanThuc * sp.phanAo) / mau;
            return new SoPhuc(a, b);
        }
    }
}
