using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_3
{
    internal class TuyenSinh
    {
        private ThiSinh[] danhSachThiSinh = new ThiSinh[100];
        private int soLuong = 0;

        public void NhapThiSinh()
        {
            if (soLuong >= danhSachThiSinh.Length)
            {
                Console.WriteLine("==> Danh sách đã đầy, không thể thêm.");
                return;
            }

            Console.WriteLine("\nChọn khối thi:");
            Console.WriteLine("1. Khối A");
            Console.WriteLine("2. Khối B");
            Console.WriteLine("3. Khối C");
            Console.Write("Lựa chọn: ");
            string loai = Console.ReadLine();

            ThiSinh ts = null;

            switch (loai)
            {
                case "1":
                    ts = new ThiSinhKhoiA();
                    break;
                case "2":
                    ts = new ThiSinhKhoiB();
                    break;
                case "3":
                    ts = new ThiSinhKhoiC();
                    break;
                default:
                    Console.WriteLine("==> Lựa chọn không hợp lệ!");
                    return;
            }

            ts.Nhap();
            danhSachThiSinh[soLuong++] = ts;
            Console.WriteLine("==> Đã thêm thí sinh.\n");
        }

        public void HienThiTrungTuyen()
        {
            Console.WriteLine("\n--- Danh sách thí sinh trúng tuyển ---");
            bool coNguoi = false;

            for (int i = 0; i < soLuong; i++)
            {
                double tongDiem = danhSachThiSinh[i].TongDiem();
                double mocDiem;

                if (danhSachThiSinh[i] is ThiSinhKhoiA)
                {
                    mocDiem = 15;
                }
                else if (danhSachThiSinh[i] is ThiSinhKhoiB)
                {
                    mocDiem = 16;
                }
                else
                {
                    mocDiem = 13.5;
                }

                if (tongDiem > mocDiem)
                {
                    danhSachThiSinh[i].HienThi();
                    Console.WriteLine("------------------");
                    coNguoi = true;
                }
            }

            if (!coNguoi)
            {
                Console.WriteLine("==> Không có thí sinh nào trúng tuyển.");
            }
        }

        public void TimKiemTheoSBD()
        {
            Console.Write("Nhập số báo danh cần tìm: ");
            if (!int.TryParse(Console.ReadLine(), out int sbd))
            {
                Console.WriteLine("==> Số báo danh không hợp lệ!");
                return;
            }

            for (int i = 0; i < soLuong; i++)
            {
                if (danhSachThiSinh[i].SBD == sbd)
                {
                    Console.WriteLine("==> Thông tin thí sinh:");
                    danhSachThiSinh[i].HienThi();
                    return;
                }
            }

            Console.WriteLine("==> Không tìm thấy thí sinh.");
        }
    }
}
