using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_13
{
    internal class XeTai:PTGT
    {
        public double TrongTai { get; set; }
        public XeTai() { }

        public XeTai(string hang, int nam, double gia, string mau, double tt)
            : base(hang, nam, gia, mau)
        {
            this.TrongTai = tt;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Trọng tải (tấn): ");
            TrongTai = double.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Loại: Xe tải | Trọng tải: {TrongTai} tấn");
        }
    }
}
