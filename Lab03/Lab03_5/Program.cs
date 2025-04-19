using Lab03_5;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
KhachSan ks = new KhachSan();
string luaChon;

do
{
    Console.WriteLine("\n===== QUẢN LÝ KHÁCH SẠN =====");
    Console.WriteLine("1. Nhập danh sách khách trọ");
    Console.WriteLine("2. Hiển thị tất cả khách trọ");
    Console.WriteLine("3. Tìm kiếm khách theo họ tên");
    Console.WriteLine("4. Tính tiền thanh toán cho khách");
    Console.WriteLine("5. Thoát");
    Console.Write("Chọn chức năng: ");
    luaChon = Console.ReadLine();

    switch (luaChon)
    {
        case "1":
            ks.NhapDanhSach();
            break;
        case "2":
            ks.HienThiTatCa();
            break;
        case "3":
            ks.TimKiemTheoTen();
            break;
        case "4":
            ks.TinhTienChoKhach();
            break;
        case "5":
            Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình!");
            break;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
            break;
    }

} while (luaChon != "5");
