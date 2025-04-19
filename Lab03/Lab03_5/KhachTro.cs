using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_5
{
    internal class KhachTro:Nguoi
    {
        public int SoNgayTro { get; set; }
        public string LoaiPhong { get; set; }
        public double GiaPhongMotNgay { get; set; }
        public KhachTro() { }

        public KhachTro(string hoTen, int namSinh, string cmnd, int soNgayTro, string loaiPhong, double gia):base(hoTen, namSinh, cmnd)
        {
            SoNgayTro = soNgayTro;
            LoaiPhong = loaiPhong;
            GiaPhongMotNgay = gia;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhập thông tin cá nhân:");
            base.Nhap();

            Console.Write("Số ngày trọ: ");
            SoNgayTro = int.Parse(Console.ReadLine());

            Console.Write("Loại phòng: ");
            LoaiPhong = Console.ReadLine();

            Console.Write("Giá phòng mỗi ngày: ");
            GiaPhongMotNgay = double.Parse(Console.ReadLine());
        }

        public void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Loại phòng: {LoaiPhong}, Số ngày trọ: {SoNgayTro}, Giá phòng/ngày: {GiaPhongMotNgay}");
        }
    }
}
