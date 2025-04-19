using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_3
{
    internal class ThiSinhKhoiB:ThiSinh
    {
        public double Toan { get; set; }
        public double Hoa { get; set; }
        public double Sinh { get; set; }
        public ThiSinhKhoiB() { }

        public ThiSinhKhoiB(int sbd, string hoTen, string diaChi, int uuTien, double toan, double hoa, double sinh)
            : base(sbd, hoTen, diaChi, uuTien)
        {
            Toan = toan;
            Hoa = hoa;
            Sinh = sinh;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Điểm Toán: ");
            Toan = double.Parse(Console.ReadLine());
            Console.Write("Điểm Hóa: ");
            Hoa = double.Parse(Console.ReadLine());
            Console.Write("Điểm Sinh: ");
            Sinh = double.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Toán: {Toan}, Hóa: {Hoa}, Sinh: {Sinh}, Tổng điểm: {TongDiem()}");
        }

        public override double TongDiem()
        {
            return Toan + Hoa + Sinh + UuTien;
        }
    }
}
