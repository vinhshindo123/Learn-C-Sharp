using Lab03_6;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
HSHocSinh[] danhSachHS = new HSHocSinh[100];
int soLuongHocSinh = 0;
int luaChon;

do
{
    Console.WriteLine("\n--- MENU ---");
    Console.WriteLine("1. Nhập danh sách học sinh");
    Console.WriteLine("2. Hiển thị học sinh nữ và sinh năm 1985");
    Console.WriteLine("3. Tìm kiếm học sinh theo quê quán");
    Console.WriteLine("4. Thoát");
    Console.Write("Chọn chức năng: ");
    luaChon = int.Parse(Console.ReadLine());

    switch (luaChon)
    {
        case 1:
            Console.Write("Nhập số lượng học sinh: ");
            int n = int.Parse(Console.ReadLine());
            if (n > danhSachHS.Length)
            {
                Console.WriteLine($"Số lượng học sinh tối đa là {danhSachHS.Length}.");
                break;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin học sinh thứ {i + 1}:");
                HSHocSinh hs = new HSHocSinh();
                hs.Nhap();
                danhSachHS[soLuongHocSinh++] = hs;
            }
            break;

        case 2:
            Console.WriteLine("\n--- Học sinh nữ và sinh năm 1985 ---");
            foreach (var hs in danhSachHS)
            {
                if (hs != null && hs.GioiTinh.ToLower() == "nữ" && hs.NamSinh == 1985)
                {
                    hs.HienThi();
                }
            }
            break;

        case 3:
            Console.Write("Nhập quê quán cần tìm: ");
            string que = Console.ReadLine().ToLower();
            Console.WriteLine($"\n--- Học sinh có quê ở {que} ---");
            foreach (var hs in danhSachHS)
            {
                if (hs != null && hs.QueQuan.ToLower().Contains(que))
                {
                    hs.HienThi();
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
