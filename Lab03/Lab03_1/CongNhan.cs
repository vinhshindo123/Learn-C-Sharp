using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_1
{
    internal class CongNhan:CanBo
    {
        public string Bac { get; set; }
        public CongNhan()
        {
            
        }
        public CongNhan(string hoTen, string namSinh, int gioiTinh, string diaChi, string bac) : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            this.Bac = bac;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập bậc (VD: 3/7): ");
            Bac = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Bậc: {Bac}");
        }
    }
}
