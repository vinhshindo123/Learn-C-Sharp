using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_5
{
    internal class Nguoi
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string CMND { get; set; }

        public Nguoi() { }

        public Nguoi(string hoTen, int namSinh, string cmnd)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            CMND = cmnd;
        }

        public void Nhap()
        {
            Console.Write("Họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());

            Console.Write("CMND: ");
            CMND = Console.ReadLine();
        }

        public void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, CMND: {CMND}");
        }
    }
}
