using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_3
{
    internal class ThiSinh
    {
        public int SBD { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int UuTien { get; set; }
        public virtual void Nhap()
        {
            Console.Write("Số báo danh: ");
            SBD = int.Parse(Console.ReadLine());
            Console.Write("Họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Địa chỉ: ");
            DiaChi = Console.ReadLine();
            Console.Write("Mức ưu tiên: ");
            UuTien = int.Parse(Console.ReadLine());
        }
        public ThiSinh() { }

        public ThiSinh(int sbd, string hoTen, string diaChi, int uuTien)
        {
            SBD = sbd;
            HoTen = hoTen;
            DiaChi = diaChi;
            UuTien = uuTien;
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"SBD: {SBD}, Họ tên: {HoTen}, Địa chỉ: {DiaChi}, Ưu tiên: {UuTien}");
        }

        public virtual double TongDiem()
        {
            return 0;
        }
    }
}
