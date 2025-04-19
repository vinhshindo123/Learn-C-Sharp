using Lab03_4;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
KhuPho khuPho = new KhuPho();
string chon;

do
{
    Console.WriteLine("\n==== MENU ====");
    Console.WriteLine("1. Nhập danh sách hộ dân");
    Console.WriteLine("2. Hiển thị toàn bộ hộ dân");
    Console.WriteLine("3. Tìm kiếm hộ dân theo họ tên");
    Console.WriteLine("4. Tìm kiếm hộ dân theo số nhà");
    Console.WriteLine("5. Thoát");
    Console.Write("Chọn chức năng: ");
    chon = Console.ReadLine();

    switch (chon)
    {
        case "1":
            khuPho.NhapDanhSachHoDan();
            break;
        case "2":
            khuPho.HienThiTatCa();
            break;
        case "3":
            khuPho.TimKiemTheoTen();
            break;
        case "4":
            khuPho.TimKiemTheoSoNha();
            break;
        case "5":
            Console.WriteLine("Đã thoát chương trình.");
            break;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            break;
    }

} while (chon != "5");
