using Lab03_13;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
QLPTGT ql = new QLPTGT();

while (true)
{
    Console.WriteLine("\n===== MENU QUẢN LÝ PHƯƠNG TIỆN =====");
    Console.WriteLine("1. Đăng ký phương tiện");
    Console.WriteLine("2. Tìm phương tiện theo màu");
    Console.WriteLine("3. Tìm phương tiện theo năm sản xuất");
    Console.WriteLine("0. Thoát");
    Console.Write("Nhập lựa chọn: ");
    string chon = Console.ReadLine();

    switch (chon)
    {
        case "1":
            ql.DangKyPhuongTien();
            break;
        case "2":
            ql.TimTheoMau();
            break;
        case "3":
            ql.TimTheoNam();
            break;
        case "0":
            Console.WriteLine("Kết thúc chương trình.");
            return;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            break;
    }
}
