using Lab03_14;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
PhanSo A = new PhanSo();
PhanSo B = new PhanSo();

Console.WriteLine("=== Nhập phân số A ===");
A.Nhap();
A.RutGon();

Console.WriteLine("=== Nhập phân số B ===");
B.Nhap();
B.RutGon();

while (true)
{
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1. Hiển thị phân số A và B");
    Console.WriteLine("2. Cộng A + B");
    Console.WriteLine("3. Trừ A - B");
    Console.WriteLine("4. Chia A / B");
    Console.WriteLine("0. Thoát");
    Console.Write("Chọn thao tác: ");
    string chon = Console.ReadLine();

    switch (chon)
    {
        case "1":
            Console.Write("Phân số A: "); A.HienThi();
            Console.Write("Phân số B: "); B.HienThi();
            break;
        case "2":
            Console.Write("A + B = ");
            A.Cong(B).HienThi();
            break;
        case "3":
            Console.Write("A - B = ");
            A.Tru(B).HienThi();
            break;
        case "4":
            try
            {
                Console.Write("A / B = ");
                A.Chia(B).HienThi();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            break;
    }
}
