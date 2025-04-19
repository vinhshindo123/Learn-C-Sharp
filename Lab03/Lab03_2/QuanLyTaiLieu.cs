using System;

namespace Lab03_2
{
    internal class QuanLyTaiLieu
    {
        private TaiLieu[] danhSachTaiLieu = new TaiLieu[100];
        private int soLuong = 0;

        public void ThemTaiLieu()
        {
            if (soLuong >= danhSachTaiLieu.Length)
            {
                Console.WriteLine("==> Danh sách tài liệu đã đầy, không thể thêm mới.");
                return;
            }

            Console.WriteLine("\nChọn loại tài liệu muốn thêm:");
            Console.WriteLine("1. Sách");
            Console.WriteLine("2. Tạp chí");
            Console.WriteLine("3. Báo");
            Console.Write("Lựa chọn: ");
            string chon = Console.ReadLine();

            TaiLieu tl = null;

            switch (chon)
            {
                case "1":
                    tl = new Sach();
                    break;
                case "2":
                    tl = new TapChi();
                    break;
                case "3":
                    tl = new Bao();
                    break;
                default:
                    Console.WriteLine("==> Lựa chọn không hợp lệ.");
                    return;
            }

            tl.Nhap();
            danhSachTaiLieu[soLuong++] = tl;
            Console.WriteLine("==> Thêm tài liệu thành công!\n");
        }

        public void TimKiemTheoLoai()
        {
            Console.WriteLine("Nhập loại tài liệu cần tìm:");
            Console.WriteLine("1. Sách");
            Console.WriteLine("2. Tạp chí");
            Console.WriteLine("3. Báo");
            Console.Write("Lựa chọn: ");
            string luaChon = Console.ReadLine();

            Console.WriteLine("\n--- Kết quả tìm kiếm ---");
            bool timThay = false;
            for (int i = 0; i < soLuong; i++)
            {
                switch (luaChon)
                {
                    case "1":
                        if (danhSachTaiLieu[i] is Sach)
                        {
                            danhSachTaiLieu[i].HienThi();
                            timThay = true;
                        }
                        break;
                    case "2":
                        if (danhSachTaiLieu[i] is TapChi)
                        {
                            danhSachTaiLieu[i].HienThi();
                            timThay = true;
                        }
                        break;
                    case "3":
                        if (danhSachTaiLieu[i] is Bao)
                        {
                            danhSachTaiLieu[i].HienThi();
                            timThay = true;
                        }
                        break;
                    default:
                        Console.WriteLine("==> Lựa chọn không hợp lệ.");
                        return;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("==> Không tìm thấy tài liệu phù hợp.");
            }
            Console.WriteLine("-----------------------");
        }

        public void HienThiTatCa()
        {
            if (soLuong == 0)
            {
                Console.WriteLine("==> Danh sách tài liệu trống.");
                return;
            }

            Console.WriteLine("\n--- Danh sách tài liệu ---");
            for (int i = 0; i < soLuong; i++)
            {
                danhSachTaiLieu[i].HienThi();
                Console.WriteLine("-----------------------");
            }
        }
    }
}
