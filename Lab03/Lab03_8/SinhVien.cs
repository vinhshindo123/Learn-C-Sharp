using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_8
{
    internal class SinhVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string Lop { get; set; }
        public string MaSoSV { get; set; }

        public SinhVien() { }

        public SinhVien(string hoTen, int namSinh, string lop, string maSoSV)
        {
            this.HoTen = hoTen;
            this.NamSinh = namSinh;
            this.Lop = lop;
            this.MaSoSV = maSoSV;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());

            Console.Write("Nhập lớp: ");
            Lop = Console.ReadLine();

            Console.Write("Nhập mã số sinh viên: ");
            MaSoSV = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Lớp: {Lop}, MSSV: {MaSoSV}");
        }
    }
}
