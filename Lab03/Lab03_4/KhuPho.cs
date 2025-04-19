using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_4
{
    internal class KhuPho : HoDan
    {
        private HoDan[] danhSachHoDan = new HoDan[100];
        private int soLuongHoDan = 0;

        public void NhapDanhSachHoDan()
        {
            Console.Write("Nhập số lượng hộ dân: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Số lượng không hợp lệ.");
                return;
            }

            if (n > danhSachHoDan.Length)
            {
                Console.WriteLine($"Không thể nhập quá {danhSachHoDan.Length} hộ dân.");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin hộ dân thứ {i + 1}:");
                HoDan ho = new HoDan();
                ho.Nhap();
                danhSachHoDan[soLuongHoDan++] = ho;
            }
        }

        public void HienThiTatCa()
        {
            Console.WriteLine("\n--- Danh sách toàn bộ hộ dân ---");
            for (int i = 0; i < soLuongHoDan; i++)
            {
                danhSachHoDan[i].HienThi();
            }
        }

        public void TimKiemTheoTen()
        {
            Console.Write("Nhập họ tên cần tìm: ");
            string tenCanTim = Console.ReadLine()?.ToLower();

            bool timThay = false;

            for (int i = 0; i < soLuongHoDan; i++)
            {
                var ho = danhSachHoDan[i];
                for (int j = 0; j < ho.SoThanhVien; j++)
                {
                    if (ho.ThanhVien[j].HoTen.ToLower().Contains(tenCanTim))
                    {
                        if (!timThay)
                        {
                            Console.WriteLine($"\nCác hộ dân có người tên chứa \"{tenCanTim}\":");
                            timThay = true;
                        }

                        ho.HienThi();
                        break;
                    }
                }
            }

            if (!timThay)
            {
                Console.WriteLine("Không tìm thấy hộ dân nào có người mang tên đó.");
            }
        }

        public void TimKiemTheoSoNha()
        {
            Console.Write("Nhập số nhà cần tìm: ");
            if (!int.TryParse(Console.ReadLine(), out int soNha))
            {
                Console.WriteLine("Số nhà không hợp lệ.");
                return;
            }

            for (int i = 0; i < soLuongHoDan; i++)
            {
                if (danhSachHoDan[i].SoNha == soNha)
                {
                    Console.WriteLine("Thông tin hộ dân:");
                    danhSachHoDan[i].HienThi();
                    return;
                }
            }

            Console.WriteLine("Không tìm thấy hộ dân với số nhà đó.");
        }
    }
}