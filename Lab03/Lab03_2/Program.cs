using Lab03_2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
QuanLyTaiLieu ql = new QuanLyTaiLieu();
string chon;

do
{
    Console.WriteLine("\n=== MENU ===");
    Console.WriteLine("1. Nhập tài liệu");
    Console.WriteLine("2. Hiển thị tất cả tài liệu");
    Console.WriteLine("3. Tìm kiếm tài liệu theo loại");
    Console.WriteLine("4. Thoát");
    Console.Write("Chọn chức năng: ");
    chon = Console.ReadLine();

    switch (chon)
    {
        case "1":
            ql.ThemTaiLieu();
            break;
        case "2":
            ql.HienThiTatCa();
            break;
        case "3":
            ql.TimKiemTheoLoai();
            break;
        case "4":
            Console.WriteLine("Thoát chương trình.");
            break;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ!");
            break;
    }

} while (chon != "4");
