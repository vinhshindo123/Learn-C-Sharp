using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_15
{
    internal class DaGiac
    {
        public int SoCanh { get; set; }
        public int[] CacCanh { get; set; }

        public DaGiac() { }

        public DaGiac(int soCanh, int[] cacCanh)
        {
            SoCanh = soCanh;
            CacCanh = new int[soCanh];
            for (int i = 0; i < soCanh; i++)
                CacCanh[i] = cacCanh[i];
        }

        public virtual void Nhap()
        {
            Console.Write("Nhập số cạnh: ");
            SoCanh = int.Parse(Console.ReadLine());
            CacCanh = new int[SoCanh];
            for (int i = 0; i < SoCanh; i++)
            {
                Console.Write($"Cạnh {i + 1}: ");
                CacCanh[i] = int.Parse(Console.ReadLine());
            }
        }

        public virtual void InCanh()
        {
            Console.Write("Các cạnh: ");
            foreach (int canh in CacCanh)
            {
                Console.Write(canh + " ");
            }
            Console.WriteLine();
        }

        public virtual int TinhChuVi()
        {
            int chuVi = 0;
            foreach (int canh in CacCanh)
            {
                chuVi += canh;
            }
            return chuVi;
        }
    }
}
