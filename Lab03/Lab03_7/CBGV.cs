using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_7
{
    internal class CBGV:Nguoi
    {
        public double LuongCung { get; set; }
        public double Thuong { get; set; }
        public double Phat { get; set; }
        public CBGV() { }

        public CBGV(string hoTen, int namSinh, string queQuan, string soCMND, double luongCung, double thuong, double phat) : base(hoTen, namSinh, queQuan, soCMND)
        {
            this.LuongCung = luongCung;
            this.Thuong = thuong;
            this.Phat = phat;
        }
        public double LuongThucLinh
        {
            get { return LuongCung + Thuong - Phat; }
        }

        public override void Nhap()
        {
            base.Nhap();

            Console.Write("Nhập lương cứng: ");
            LuongCung = double.Parse(Console.ReadLine());

            Console.Write("Nhập tiền thưởng: ");
            Thuong = double.Parse(Console.ReadLine());

            Console.Write("Nhập tiền phạt: ");
            Phat = double.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Lương cứng: {LuongCung}, Thưởng: {Thuong}, Phạt: {Phat}, Lương thực lĩnh: {LuongThucLinh}");
        }
    }
}
