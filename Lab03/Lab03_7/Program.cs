using Lab03_7;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
CBGV[] danhSachCBGV = new CBGV[100];
int soLuongCBGV = 0;
int luaChon;

do
{
    Console.WriteLine("\n--- MENU ---");
    Console.WriteLine("1. Nhập danh sách cán bộ giáo viên");
    Console.WriteLine("2. Tìm kiếm theo quê quán");
    Console.WriteLine("3. Hiển thị cán bộ có lương thực lĩnh trên 5 triệu");
    Console.WriteLine("4. Thoát");
    Console.Write("Chọn chức năng: ");
    luaChon = int.Parse(Console.ReadLine());

    switch (luaChon)
    {
        case 1:
            Console.Write("Nhập số lượng cán bộ giáo viên: ");
            int n = int.Parse(Console.ReadLine());
            if (n > danhSachCBGV.Length)
            {
                Console.WriteLine($"Số lượng cán bộ giáo viên tối đa là {danhSachCBGV.Length}.");
                break;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin cán bộ thứ {i + 1} ---");
                CBGV cb = new CBGV();
                cb.Nhap();
                danhSachCBGV[soLuongCBGV++] = cb;
            }
            break;

        case 2:
            Console.Write("Nhập quê quán cần tìm: ");
            string que = Console.ReadLine().ToLower();
            Console.WriteLine($"\n--- Danh sách cán bộ giáo viên quê ở {que} ---");
            foreach (var cb in danhSachCBGV)
            {
                if (cb != null && cb.QueQuan.ToLower().Contains(que))
                {
                    cb.HienThi();
                }
            }
            break;

        case 3:
            Console.WriteLine("\n--- Danh sách cán bộ giáo viên có lương thực lĩnh > 5 triệu ---");
            foreach (var cb in danhSachCBGV)
            {
                if (cb != null && cb.LuongThucLinh > 5000000)
                {
                    cb.HienThi();
                }
            }
            break;

        case 4:
            Console.WriteLine("Đã thoát chương trình.");
            break;

        default:
            Console.WriteLine("Lựa chọn không hợp lệ!");
            break;
    }

} while (luaChon != 4);
