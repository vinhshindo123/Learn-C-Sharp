using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_9
{
    internal class KhachHang
    {
        public string HoTen { get; set; }
        public string SoNha { get; set; }
        public string MaCongTo { get; set; }

        public KhachHang() { }

        public KhachHang(string hoTen, string soNha, string maCongTo)
        {
            this.HoTen = hoTen;
            this.SoNha = soNha;
            this.MaCongTo = maCongTo;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhập họ tên chủ hộ: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập số nhà: ");
            SoNha = Console.ReadLine();

            Console.Write("Nhập mã số công tơ: ");
            MaCongTo = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Số nhà: {SoNha}");
            Console.WriteLine($"Mã công tơ: {MaCongTo}");
        }
    }
}
