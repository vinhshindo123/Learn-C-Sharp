using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_12
{
    internal class MaTran
    {
        public int SoDong { get; set; }
        public int SoCot { get; set; }
        public double[,] Arr2D { get; set; }

        public MaTran()
        {
            SoDong = 0;
            SoCot = 0;
            Arr2D = new double[0, 0];
        }

        public MaTran(int n, int m)
        {
            SoDong = n;
            SoCot = m;
            Arr2D = new double[n, m];
        }

        public void Nhap()
        {
            Console.WriteLine($"Nhập ma trận ({SoDong} dòng x {SoCot} cột):");
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Console.Write($"Phần tử [{i},{j}]: ");
                    Arr2D[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }

        public void HienThi()
        {
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Console.Write(Arr2D[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public MaTran Cong(MaTran b)
        {
            if (SoDong != b.SoDong || SoCot != b.SoCot)
                throw new Exception("Hai ma trận phải cùng kích thước để cộng.");

            MaTran kq = new MaTran(SoDong, SoCot);
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    kq.Arr2D[i, j] = this.Arr2D[i, j] + b.Arr2D[i, j];
                }
            }
            return kq;
        }

        public MaTran Tru(MaTran b)
        {
            if (SoDong != b.SoDong || SoCot != b.SoCot)
                throw new Exception("Hai ma trận phải cùng kích thước để trừ.");

            MaTran kq = new MaTran(SoDong, SoCot);
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    kq.Arr2D[i, j] = this.Arr2D[i, j] - b.Arr2D[i, j];
                }
            }
            return kq;
        }

        public MaTran Nhan(MaTran b)
        {
            if (SoCot != b.SoDong)
                throw new Exception("Số cột của ma trận A phải bằng số dòng của ma trận B để nhân.");

            MaTran kq = new MaTran(SoDong, b.SoCot);
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < b.SoCot; j++)
                {
                    kq.Arr2D[i, j] = 0;
                    for (int k = 0; k < SoCot; k++)
                    {
                        kq.Arr2D[i, j] += this.Arr2D[i, k] * b.Arr2D[k, j];
                    }
                }
            }
            return kq;
        }
        public MaTran Chia(MaTran b)
        {
            if (SoDong != b.SoDong || SoCot != b.SoCot)
                throw new Exception("Hai ma trận phải cùng kích thước để chia.");

            MaTran kq = new MaTran(SoDong, SoCot);
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    if (b.Arr2D[i, j] == 0)
                        throw new Exception($"Không thể chia cho 0 tại vị trí [{i},{j}].");

                    kq.Arr2D[i, j] = this.Arr2D[i, j] / b.Arr2D[i, j];
                }
            }
            return kq;
        }
    }
}
