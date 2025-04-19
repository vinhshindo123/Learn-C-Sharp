using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_2
{
    internal class TaiLieu
    {
        public int MaTaiLieu { get; set; }
        public string TenNhaXuatBan { get; set; }
        public int SoBanPhatHanh { get; set; }
        public TaiLieu()
        {
                
        }
        public TaiLieu(int maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh)
        {
            this.MaTaiLieu = maTaiLieu;
            this.TenNhaXuatBan = tenNhaXuatBan;
            this.SoBanPhatHanh = soBanPhatHanh;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhập mã tài liệu: ");
            MaTaiLieu = int.Parse(Console.ReadLine());

            Console.Write("Nhập tên nhà xuất bản: ");
            TenNhaXuatBan = Console.ReadLine();

            Console.Write("Nhập số bán phát hành: ");
            SoBanPhatHanh = int.Parse(Console.ReadLine());
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Mã tài liệu: {MaTaiLieu}, Nhà xuất bản: {TenNhaXuatBan}, Số bán phát hành: {SoBanPhatHanh}");
        }
    }
}
