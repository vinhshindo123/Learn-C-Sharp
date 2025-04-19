using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_13
{
    internal class XeMay:PTGT
    {
        public double CongSuat { get; set; }
        public XeMay() { }

        public XeMay(string hang, int nam, double gia, string mau, double cs)
            : base(hang, nam, gia, mau)
        {
            this.CongSuat = cs;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Công suất: ");
            CongSuat = double.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Loại: Xe máy | Công suất: {CongSuat}");
        }
    }
}
