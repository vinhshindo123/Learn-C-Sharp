using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_4
{
    internal class Nguoi
    {
        public int CMND { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public int NamSinh { get; set; }
        public string NgheNghiep { get; set; }

        public Nguoi() { }

        public Nguoi(int cmnd, string hoTen, int tuoi, int namSinh, string ngheNghiep)
        {
            CMND = cmnd;
            HoTen = hoTen;
            Tuoi = tuoi;
            NamSinh = namSinh;
            NgheNghiep = ngheNghiep;
        }

        public void Nhap()
        {
            Console.Write("CMND: ");
            CMND = int.Parse(Console.ReadLine());
            Console.Write("Họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Tuổi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nghề nghiệp: ");
            NgheNghiep = Console.ReadLine();
        }

        public void HienThi()
        {
            Console.WriteLine($"CMND: {CMND}, Họ tên: {HoTen}, Tuổi: {Tuoi}, Năm sinh: {NamSinh}, Nghề nghiệp: {NgheNghiep}");
        }
    }
}
