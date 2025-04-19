using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_13
{
    internal class PTGT
    {
        public string HangSanXuat { get; set; }
        public int NamSanXuat { get; set; }
        public double GiaBan { get; set; }
        public string Mau { get; set; }
        public PTGT() { }
        public PTGT(string hangSanXuat, int namSanXuat, double giaBan, string mau)
        {
            this.HangSanXuat = hangSanXuat;
            this.NamSanXuat = namSanXuat;
            this.GiaBan = giaBan;
            this.Mau = mau;
        }
        public virtual void Nhap()
        {
            Console.Write("Hãng sản xuất: ");
            HangSanXuat = Console.ReadLine();
            Console.Write("Năm sản xuất: ");
            NamSanXuat = int.Parse(Console.ReadLine());
            Console.Write("Giá bán: ");
            GiaBan = double.Parse(Console.ReadLine());
            Console.Write("Màu: ");
            Mau = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Hãng: {HangSanXuat}, Năm: {NamSanXuat}, Giá: {GiaBan}, Màu: {Mau}");
        }
    }
}
