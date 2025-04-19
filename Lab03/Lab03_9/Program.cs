using Lab03_9;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
BienLai[] danhSachBienLai = new BienLai[100];
int soLuongBienLai = 0;
int luaChon;

do
{
    Console.WriteLine("\n======= MENU QUẢN LÝ BIÊN LAI ĐIỆN =======");
    Console.WriteLine("1. Nhập danh sách biên lai hộ dân");
    Console.WriteLine("2. Hiển thị thông tin các biên lai");
    Console.WriteLine("3. Tính tiền điện phải trả cho mỗi hộ dân");
    Console.WriteLine("4. Thoát");
    Console.Write("Chọn chức năng (1-4): ");
    luaChon = int.Parse(Console.ReadLine());

    switch (luaChon)
    {
        case 1:
            Console.Write("Nhập số hộ dân: ");
            int n = int.Parse(Console.ReadLine());
            if (n > danhSachBienLai.Length)
            {
                Console.WriteLine($"Số lượng biên lai tối đa là {danhSachBienLai.Length}.");
                break;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin hộ dân thứ {i + 1} ---");
                BienLai bl = new BienLai();
                bl.Nhap();
                danhSachBienLai[soLuongBienLai++] = bl;
            }
            Console.WriteLine(">> Đã nhập xong danh sách biên lai.");
            break;

        case 2:
            if (soLuongBienLai == 0)
            {
                Console.WriteLine(">> Chưa có dữ liệu. Vui lòng nhập trước.");
            }
            else
            {
                Console.WriteLine("\n====== DANH SÁCH BIÊN LAI ======");
                for (int i = 0; i < soLuongBienLai; i++)
                {
                    danhSachBienLai[i].HienThi();
                    Console.WriteLine("--------------------------");
                }
            }
            break;

        case 3:
            for (int i = 0; i < soLuongBienLai; i++)
            {
                int soDien = danhSachBienLai[i].ChiSoMoi - danhSachBienLai[i].ChiSoCu;

                if (soDien < 0)
                {
                    Console.WriteLine("Lỗi: chỉ số mới nhỏ hơn chỉ số cũ.");
                    danhSachBienLai[i].SoTienPhaiTra = 0;
                    return;
                }

                if (soDien < 50)
                    danhSachBienLai[i].SoTienPhaiTra = soDien * 1250;
                else if (soDien < 100)
                    danhSachBienLai[i].SoTienPhaiTra = soDien * 1500;
                else
                    danhSachBienLai[i].SoTienPhaiTra = soDien * 2000;
            }
            Console.WriteLine("Đã tính xong tiền điện cho các hộ dân.");
            break;

        case 4:
            Console.WriteLine("Thoát chương trình");
            break;

        default:
            Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại.");
            break;
    }

} while (luaChon != 4);
