using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_8
{
    internal class TheMuon:SinhVien
    {
        public string SoPhieuMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public string SoHieuSach { get; set; }

        public TheMuon() : base() { }

        public TheMuon(string hoTen, int namSinh, string lop, string maSoSV,
                       string soPhieuMuon, DateTime ngayMuon, DateTime hanTra, string soHieuSach)
            : base(hoTen, namSinh, lop, maSoSV)
        {
            this.SoPhieuMuon = soPhieuMuon;
            this.NgayMuon = ngayMuon;
            this.HanTra = hanTra;
            this.SoHieuSach = soHieuSach;
        }

        public override void Nhap()
        {
            base.Nhap();

            Console.Write("Nhập số phiếu mượn: ");
            SoPhieuMuon = Console.ReadLine();

            Console.Write("Nhập số hiệu sách: ");
            SoHieuSach = Console.ReadLine();

            Console.Write("Nhập ngày mượn (dd/MM/yyyy): ");
            NgayMuon = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Nhập hạn trả (dd/MM/yyyy): ");
            HanTra = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Số phiếu mượn: {SoPhieuMuon}, Số hiệu sách: {SoHieuSach}, Ngày mượn: {NgayMuon:dd/MM/yyyy}, Hạn trả: {HanTra:dd/MM/yyyy}");
        }
    }
}
