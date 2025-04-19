using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_1
{
    internal class NhanVien:CanBo
    {
        public string CongViec { get; set; }
        public NhanVien()
        {
             
        }
        public NhanVien(string hoTen, string namSinh, int gioiTinh, string diaChi, string congViec):base(hoTen, namSinh, gioiTinh, diaChi)
        {
            this.CongViec = congViec;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập công việc: ");
            CongViec = Console.ReadLine();
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Công việc: {CongViec}");
        }
    }
}
