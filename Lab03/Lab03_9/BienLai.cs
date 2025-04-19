using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_9
{
    internal class BienLai:KhachHang
    {
        public int ChiSoCu { get; set; }
        public int ChiSoMoi { get; set; }
        public double SoTienPhaiTra { get; set; }

        public BienLai() : base() { }

        public BienLai(string hoTen, string soNha, string maCongTo, int chiSoCu, int chiSoMoi)
            : base(hoTen, soNha, maCongTo)
        {
            this.ChiSoCu = chiSoCu;
            this.ChiSoMoi = chiSoMoi;
            this.SoTienPhaiTra = 0;
        }

        public override void Nhap()
        {
            base.Nhap();

            Console.Write("Nhập chỉ số cũ: ");
            ChiSoCu = int.Parse(Console.ReadLine());

            Console.Write("Nhập chỉ số mới: ");
            ChiSoMoi = int.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Chỉ số cũ: {ChiSoCu}");
            Console.WriteLine($"Chỉ số mới: {ChiSoMoi}");
            Console.WriteLine($"Số tiền phải trả: {SoTienPhaiTra} VNĐ");
        }
    }
}
