using Lab03_11;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;

SoPhuc A = new SoPhuc();
SoPhuc B = new SoPhuc();

A.Nhap();
B.Nhap();

int luaChon;
do
{
    Console.WriteLine("\n===== MENU PHÉP TOÁN SỐ PHỨC =====");
    Console.WriteLine("1. Tính tổng A + B");
    Console.WriteLine("2. Tính hiệu A - B");
    Console.WriteLine("3. Tính tích A * B");
    Console.WriteLine("4. Tính thương A / B");
    Console.WriteLine("5. Thoát");
    Console.Write("Chọn chức năng (1-5): ");
    luaChon = int.Parse(Console.ReadLine());

    SoPhuc ketQua;

    switch (luaChon)
    {
        case 1:
            ketQua = A.Cong(B);
            ketQua.HienThi("Tổng A + B");
            break;
        case 2:
            ketQua = A.Tru(B);
            ketQua.HienThi("Hiệu A - B");
            break;
        case 3:
            ketQua = A.Nhan(B);
            ketQua.HienThi("Tích A * B");
            break;
        case 4:
            ketQua = A.Chia(B);
            ketQua.HienThi("Thương A / B");
            break;
        case 5:
            Console.WriteLine(">> Thoát chương trình.");
            break;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ!");
            break;
    }

} while (luaChon != 5);
