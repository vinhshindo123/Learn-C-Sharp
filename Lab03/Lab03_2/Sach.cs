using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_2
{
    internal class Sach:TaiLieu
    {
        public string TenTacGia { get; set; }
        public int SoTrang { get; set; }
        public Sach()
        {
            
        }
        public Sach(int maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh, string tenTacGia, int soTrang):base(maTaiLieu, tenNhaXuatBan, soBanPhatHanh)
        {
            this.TenTacGia = tenTacGia;
            this.SoTrang = soTrang;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập tên tác giả: ");
            TenTacGia = Console.ReadLine();
            Console.Write("Nhập số trang: ");
            SoTrang = int.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Tên tác giả: {TenTacGia}, Số trang: {SoTrang}");
        }
    }
}
