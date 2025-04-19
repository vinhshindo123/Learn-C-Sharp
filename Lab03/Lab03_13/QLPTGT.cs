using System;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_13
{
    internal class QLPTGT
    {
        private PTGT[] danhSach = new PTGT[100];
        private int soLuong = 0;

        public void DangKyPhuongTien()
        {
            Console.WriteLine("Chọn loại phương tiện để đăng ký:");
            Console.WriteLine("1. Ô tô");
            Console.WriteLine("2. Xe máy");
            Console.WriteLine("3. Xe tải");
            Console.Write("Lựa chọn: ");
            string luaChon = Console.ReadLine();

            PTGT pt;

            if (luaChon == "1")
                pt = new OTo();
            else if (luaChon == "2")
                pt = new XeMay();
            else if (luaChon == "3")
                pt = new XeTai();
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
                return;
            }

            pt.Nhap();

            if (soLuong < danhSach.Length)
            {
                danhSach[soLuong++] = pt;
                Console.WriteLine(">>> Đã thêm phương tiện thành công!");
            }
            else
            {
                Console.WriteLine("Không thể thêm phương tiện, mảng đã đầy.");
            }
        }

        public void TimTheoMau()
        {
            Console.Write("Nhập màu cần tìm: ");
            string mau = Console.ReadLine();

            var ketQua = danhSach.Where(pt => pt != null && pt.Mau.ToLower() == mau.ToLower());

            Console.WriteLine($"\nKết quả tìm theo màu '{mau}':");
            foreach (var pt in ketQua)
            {
                pt.HienThi();
                Console.WriteLine();
            }
        }

        public void TimTheoNam()
        {
            Console.Write("Nhập năm sản xuất cần tìm: ");
            int nam = int.Parse(Console.ReadLine());

            var ketQua = danhSach.Where(pt => pt != null && pt.NamSanXuat == nam);

            Console.WriteLine($"\nKết quả tìm theo năm '{nam}':");
            foreach (var pt in ketQua)
            {
                pt.HienThi();
                Console.WriteLine();
            }
        }
    }
}
