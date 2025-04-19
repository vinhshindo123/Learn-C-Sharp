
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_3
{
    internal class ThiSinhKhoiA:ThiSinh
    {
        public double Toan { get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }
        public ThiSinhKhoiA() { }

        public ThiSinhKhoiA(int sbd, string hoTen, string diaChi, int uuTien, double toan, double ly, double hoa)
            : base(sbd, hoTen, diaChi, uuTien)
        {
            this.Toan = toan;
            this.Ly = ly;
            this.Hoa = hoa;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Điểm Toán: ");
            Toan = double.Parse(Console.ReadLine());
            Console.Write("Điểm Lý: ");
            Ly = double.Parse(Console.ReadLine());
            Console.Write("Điểm Hóa: ");
            Hoa = double.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Toán: {Toan}, Lý: {Ly}, Hóa: {Hoa}, Tổng điểm: {TongDiem()}");
        }

        public override double TongDiem()
        {
            return Toan + Ly + Hoa + UuTien;
        }
    }
}
