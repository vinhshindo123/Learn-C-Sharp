using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_1
{
    internal class CanBo
    {
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
        public int GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public CanBo()
        {
        }
        public CanBo(string hoTen, string namSinh, int gioiTinh, string diaChi)
        {
            this.HoTen = hoTen;
            this.NamSinh = namSinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập năm sinh: ");
            NamSinh = Console.ReadLine();

            Console.Write("Nhập giới tính: ");
            GioiTinh = int.Parse(Console.ReadLine());

            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Giới tính: {GioiTinh}, Địa chỉ: {DiaChi}");
        }
    }
}
