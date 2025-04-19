using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_5
{
    internal class KhachSan
    {
        private KhachTro[] danhSachKhach = new KhachTro[100];
        private int soLuongKhach = 0;

        public void NhapDanhSach()
        {
            Console.Write("Nhập số lượng khách trọ: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Số lượng không hợp lệ.");
                return;
            }

            if (n > danhSachKhach.Length)
            {
                Console.WriteLine($"Không thể nhập quá {danhSachKhach.Length} khách.");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Khách trọ thứ {i + 1} ---");
                KhachTro kt = new KhachTro();
                kt.Nhap();
                danhSachKhach[soLuongKhach++] = kt;
            }
        }

        public void HienThiTatCa()
        {
            Console.WriteLine("\n--- Danh sách khách đang trọ ---");
            if (soLuongKhach == 0)
            {
                Console.WriteLine("Không có khách nào.");
                return;
            }

            for (int i = 0; i < soLuongKhach; i++)
            {
                danhSachKhach[i].HienThi();
                Console.WriteLine();
            }
        }

        public void TimKiemTheoTen()
        {
            Console.Write("Nhập họ tên cần tìm: ");
            string ten = Console.ReadLine()?.Trim().ToLower();

            bool timThay = false;

            Console.WriteLine($"\nCác khách có tên chứa \"{ten}\":");
            for (int i = 0; i < soLuongKhach; i++)
            {
                if (danhSachKhach[i].HoTen.ToLower().Contains(ten))
                {
                    danhSachKhach[i].HienThi();
                    Console.WriteLine();
                    timThay = true;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("Không tìm thấy khách nào.");
            }
        }

        public void TinhTienChoKhach()
        {
            Console.Write("Nhập số CMND của khách cần tính tiền: ");
            string cmnd = Console.ReadLine()?.Trim();

            for (int i = 0; i < soLuongKhach; i++)
            {
                if (danhSachKhach[i].CMND == cmnd)
                {
                    double tien = danhSachKhach[i].SoNgayTro * danhSachKhach[i].GiaPhongMotNgay;
                    Console.WriteLine($"Khách {danhSachKhach[i].HoTen} cần thanh toán: {tien:N0} VND");
                    return;
                }
            }

            Console.WriteLine("Không tìm thấy khách với số CMND này.");
        }
    }
}
