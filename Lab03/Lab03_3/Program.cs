using Lab03_3;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
TuyenSinh tuyenSinh = new TuyenSinh();
string chon;

do
{
    Console.WriteLine("\n==== MENU ====");
    Console.WriteLine("1. Nhập thông tin thí sinh");
    Console.WriteLine("2. Hiển thị thí sinh trúng tuyển");
    Console.WriteLine("3. Tìm kiếm theo số báo danh");
    Console.WriteLine("4. Thoát");
    Console.Write("Chọn chức năng: ");
    chon = Console.ReadLine();

    switch (chon)
    {
        case "1":
            tuyenSinh.NhapThiSinh();
            break;
        case "2":
            tuyenSinh.HienThiTrungTuyen();
            break;
        case "3":
            tuyenSinh.TimKiemTheoSBD();
            break;
        case "4":
            Console.WriteLine("Đã thoát chương trình.");
            break;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ!");
            break;
    }

} while (chon != "4");
