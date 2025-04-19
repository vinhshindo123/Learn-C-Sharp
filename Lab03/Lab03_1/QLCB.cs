using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_1
{
    internal class QLCB
    {
        private CanBo[] danhSachCanBo = new CanBo[100];
        private int soLuong = 0;

        public void ThemCanBo()
        {
            if (soLuong >= danhSachCanBo.Length)
            {
                Console.WriteLine("==> Danh sách cán bộ đã đầy, không thể thêm mới.");
                return;
            }

            Console.WriteLine("\nChọn loại cán bộ muốn thêm:");
            Console.WriteLine("1. Công nhân");
            Console.WriteLine("2. Kỹ sư");
            Console.WriteLine("3. Nhân viên");
            Console.Write("Lựa chọn: ");
            string chon = Console.ReadLine();

            CanBo cb = null;

            switch (chon)
            {
                case "1":
                    cb = new CongNhan();
                    break;
                case "2":
                    cb = new KySu();
                    break;
                case "3":
                    cb = new NhanVien();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    return;
            }

            cb.Nhap();
            danhSachCanBo[soLuong] = cb;
            soLuong++;

            Console.WriteLine("==> Thêm cán bộ thành công!\n");
        }

        public void TimKiemTheoHoTen()
        {
            Console.Write("Nhập họ tên cần tìm: ");
            string ten = Console.ReadLine();
            bool timThay = false;

            Console.WriteLine("\n==> Kết quả tìm kiếm:");
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSachCanBo[i].HoTen.ToLower().Contains(ten.ToLower()))
                {
                    danhSachCanBo[i].HienThi();
                    Console.WriteLine();
                    timThay = true;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("==> Không tìm thấy cán bộ nào.");
            }
        }

        public void HienThiDanhSach()
        {
            Console.WriteLine("\n==> Danh sách cán bộ:");
            for (int i = 0; i < soLuong; i++)
            {
                danhSachCanBo[i].HienThi();
                Console.WriteLine();
            }
        }
    }
}
