using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_2
{
    internal class Bao:TaiLieu
    {
        public string NgayPhatHanh { get; set; }
        public Bao()
        {
            
        }
        public Bao(int maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh, string ngayPhatHanh) : base(maTaiLieu, tenNhaXuatBan, soBanPhatHanh)
        {
            this.NgayPhatHanh = ngayPhatHanh;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập ngày phát hành: ");
            NgayPhatHanh = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Ngày phát hành: {NgayPhatHanh}");
        }
    }
}
