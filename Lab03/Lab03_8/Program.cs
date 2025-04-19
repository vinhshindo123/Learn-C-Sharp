using Lab03_8;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
TheMuon[] danhSachMuon = new TheMuon[100];
int soLuongMuon = 0;
int luaChon;

do
{
    Console.WriteLine("\n--- MENU ---");
    Console.WriteLine("1. Nhập danh sách thẻ mượn sách");
    Console.WriteLine("2. Tìm kiếm theo mã số sinh viên");
    Console.WriteLine("3. Hiển thị sinh viên đã đến hạn trả sách");
    Console.WriteLine("4. Thoát");
    Console.Write("Chọn chức năng: ");
    luaChon = int.Parse(Console.ReadLine());

    switch (luaChon)
    {
        case 1:
            Console.Write("Nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());
            if (n > danhSachMuon.Length)
            {
                Console.WriteLine($"Số lượng thẻ mượn tối đa là {danhSachMuon.Length}.");
                break;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin sinh viên thứ {i + 1} ---");
                TheMuon tm = new TheMuon();
                tm.Nhap();
                danhSachMuon[soLuongMuon++] = tm;
            }
            break;

        case 2:
            Console.Write("Nhập MSSV cần tìm: ");
            string mssv = Console.ReadLine().ToLower();
            Console.WriteLine($"\n--- Kết quả tìm kiếm MSSV: {mssv} ---");
            foreach (var tm in danhSachMuon)
            {
                if (tm != null && tm.MaSoSV.ToLower() == mssv)
                {
                    tm.HienThi();
                }
            }
            break;

        case 3:
            DateTime ngayHienTai = DateTime.Now;
            Console.WriteLine($"\n--- Danh sách sinh viên đến hạn trả sách (trước hoặc bằng {ngayHienTai:dd/MM/yyyy}) ---");
            foreach (var tm in danhSachMuon)
            {
                if (tm != null && tm.HanTra.Date <= ngayHienTai.Date)
                {
                    tm.HienThi();
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
