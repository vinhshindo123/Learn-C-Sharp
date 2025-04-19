using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab03_2
{
    internal class TapChi:TaiLieu
    {
        public int SoPhatHanh { get; set; }
        public string ThangPhatHanh { get; set; }
        public TapChi()
        {
            
        }
        public TapChi(int maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh, int soPhatHanh, string thangPhatHanh) :base(maTaiLieu, tenNhaXuatBan, soBanPhatHanh)
        {
            this.SoPhatHanh = soPhatHanh;
            this.ThangPhatHanh = thangPhatHanh;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập số phát hành: ");
            SoPhatHanh = int.Parse(Console.ReadLine());
            Console.Write("Nhập tháng phát hành: ");
            ThangPhatHanh = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Số phát hành: {SoPhatHanh}, Tháng phát hành: {ThangPhatHanh}");
        }
    }
}
