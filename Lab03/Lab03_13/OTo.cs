using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_13
{
    internal class OTo:PTGT
    {
        public int SoChoNgoi { get; set; }
        public string KieuDongCo { get; set; }

        public OTo() { }

        public OTo(string hang, int nam, double gia, string mau, int soCho, string dongCo)
            : base(hang, nam, gia, mau)
        {
            this.SoChoNgoi = soCho;
            this.KieuDongCo = dongCo;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Số chỗ ngồi: ");
            SoChoNgoi = int.Parse(Console.ReadLine());
            Console.Write("Kiểu động cơ: ");
            KieuDongCo = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Loại: Ô tô | Số chỗ: {SoChoNgoi}, Động cơ: {KieuDongCo}");
        }
    }
}
