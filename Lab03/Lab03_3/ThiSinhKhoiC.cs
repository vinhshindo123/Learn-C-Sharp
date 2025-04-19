using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_3
{
    internal class ThiSinhKhoiC:ThiSinh
    {
        public double Van { get; set; }
        public double Su { get; set; }
        public double Dia { get; set; }

        public ThiSinhKhoiC() { }

        public ThiSinhKhoiC(int sbd, string hoTen, string diaChi, int uuTien, double van, double su, double dia)
            : base(sbd, hoTen, diaChi, uuTien)
        {
            Van = van;
            Su = su;
            Dia = dia;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Điểm Văn: ");
            Van = double.Parse(Console.ReadLine());
            Console.Write("Điểm Sử: ");
            Su = double.Parse(Console.ReadLine());
            Console.Write("Điểm Địa: ");
            Dia = double.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Văn: {Van}, Sử: {Su}, Địa: {Dia}, Tổng điểm: {TongDiem()}");
        }

        public override double TongDiem()
        {
            return Van + Su + Dia + UuTien;
        }
    }
}
