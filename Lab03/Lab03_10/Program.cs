using Lab03_10;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;

VanBan vb = new VanBan();
Console.Write("Nhập nội dung văn bản: ");
vb.XauKiTu = Console.ReadLine();

int chon;

do
{
    Console.WriteLine("\n===== MENU XỬ LÝ VĂN BẢN =====");
    Console.WriteLine("1. Hiển thị văn bản hiện tại");
    Console.WriteLine("2. Đếm số từ");
    Console.WriteLine("3. Đếm số ký tự 'H'");
    Console.WriteLine("4. Chuẩn hoá văn bản");
    Console.WriteLine("5. Thoát");
    Console.Write("Chọn chức năng (1-5): ");

    bool isValid = int.TryParse(Console.ReadLine(), out chon);

    if (!isValid)
    {
        Console.WriteLine("Vui lòng nhập số hợp lệ.");
        continue;
    }

    switch (chon)
    {
        case 1:
            Console.WriteLine("Nội dung văn bản: \"" + vb.XauKiTu + "\"");
            break;
        case 2:
            Console.WriteLine($"Số từ trong văn bản: {vb.DemSoTu()}");
            break;
        case 3:
            Console.WriteLine($"Số ký tự 'H' hoặc 'h': {vb.DemSoKyTuH()}");
            break;
        case 4:
            vb.ChuanHoa();
            Console.WriteLine("Đã chuẩn hoá văn bản.");
            Console.WriteLine("Nội dung văn bản: \"" + vb.XauKiTu + "\"");
            break;
        case 5:
            Console.WriteLine(">> Thoát chương trình.");
            break;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            break;
    }

} while (chon != 5);
