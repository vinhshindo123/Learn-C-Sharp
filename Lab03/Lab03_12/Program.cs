using Lab03_12;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập số dòng của ma trận: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Nhập số cột của ma trận: ");
int m = int.Parse(Console.ReadLine());

MaTran A = new MaTran(n, m);
MaTran B = new MaTran(n, m);

Console.WriteLine("\nNhập ma trận A:");
A.Nhap();

Console.WriteLine("\nNhập ma trận B:");
B.Nhap();

while (true)
{
    Console.WriteLine("\n----- MENU -----");
    Console.WriteLine("1. Hiển thị ma trận A");
    Console.WriteLine("2. Hiển thị ma trận B");
    Console.WriteLine("3. Tính tổng hai ma trận (A + B)");
    Console.WriteLine("4. Tính hiệu hai ma trận (A - B)");
    Console.WriteLine("5. Tính tích hai ma trận (A x B)");
    Console.WriteLine("6. Tính thương hai ma trận (A / B - chia từng phần tử)");
    Console.WriteLine("0. Thoát");
    Console.Write("Nhập lựa chọn của bạn: ");

    string chon = Console.ReadLine();
    MaTran kq;

    if (chon == "1")
    {
        Console.WriteLine("\nMa trận A:");
        A.HienThi();
    }
    else if (chon == "2")
    {
        Console.WriteLine("\nMa trận B:");
        B.HienThi();
    }
    else if (chon == "3")
    {
        kq = A.Cong(B);
        Console.WriteLine("\nTổng A + B:");
        kq.HienThi();
    }
    else if (chon == "4")
    {
        kq = A.Tru(B);
        Console.WriteLine("\nHiệu A - B:");
        kq.HienThi();
    }
    else if (chon == "5")
    {
        kq = A.Nhan(B);
        Console.WriteLine("\nTích A x B:");
        kq.HienThi();
    }
    else if (chon == "6")
    {
        kq = A.Chia(B);
        Console.WriteLine("\nThương A / B:");
        kq.HienThi();
    }
    else if (chon == "0")
    {
        Console.WriteLine("Đã thoát chương trình.");
        break;
    }
    else
    {
        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại.");
    }
}
