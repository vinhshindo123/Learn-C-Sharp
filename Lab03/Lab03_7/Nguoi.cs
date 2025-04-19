using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_7
{
    internal class Nguoi
    {

        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string QueQuan { get; set; }
        public string CMND { get; set; }
        public Nguoi() { }
        public Nguoi(string hoTen, int namSinh, string queQuan, string cmnd)
        {
            this.HoTen = hoTen;
            this.QueQuan = queQuan;
            this.NamSinh = namSinh;
            this.CMND = cmnd;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());

            Console.Write("Nhập quê quán: ");
            QueQuan = Console.ReadLine();

            Console.Write("Nhập số CMND: ");
            CMND = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Quê quán: {QueQuan}, Số CMND: {CMND}");
        }
    }
}
