using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_6
{
    internal class HSHocSinh:Nguoi
    {
        public string Lop { get; set; }
        public string KhoaHoc { get; set; }
        public string KyHoc { get; set; }

        public HSHocSinh() { }

        public HSHocSinh(string hoTen, int tuoi, int namSinh, string queQuan, string gioiTinh,
                         string lop, string khoaHoc, string kyHoc)
            : base(hoTen, tuoi, namSinh, queQuan, gioiTinh)
        {
            this.Lop = lop;
            this.KhoaHoc = khoaHoc;
            this.KyHoc = kyHoc;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Lớp: ");
            Lop = Console.ReadLine();

            Console.Write("Khóa học: ");
            KhoaHoc = Console.ReadLine();

            Console.Write("Kỳ học: ");
            KyHoc = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Lớp: {Lop}, Khóa học: {KhoaHoc}, Kỳ học: {KyHoc}");
        }
    }
}
