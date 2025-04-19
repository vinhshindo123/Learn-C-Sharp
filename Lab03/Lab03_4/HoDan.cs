using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_4
{
    internal class HoDan
    {
        public int SoNha { get; set; }
        public int SoThanhVien { get; set; }
        public Nguoi[] ThanhVien { get; set; }

        public void Nhap()
        {
            Console.Write("Số nhà: ");
            SoNha = int.Parse(Console.ReadLine());

            Console.Write("Số thành viên: ");
            SoThanhVien = int.Parse(Console.ReadLine());

            ThanhVien = new Nguoi[SoThanhVien];

            for (int i = 0; i < SoThanhVien; i++)
            {
                Console.WriteLine($"Nhập thông tin thành viên thứ {i + 1}:");
                ThanhVien[i] = new Nguoi();
                ThanhVien[i].Nhap();
            }
        }

        public void HienThi()
        {
            Console.WriteLine($"\nHộ dân - Số nhà: {SoNha}, Số thành viên: {SoThanhVien}");
            for (int i = 0; i < SoThanhVien; i++)
            {
                ThanhVien[i].HienThi();
            }
        }
    }
}
