using Lab03_15;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập số lượng tam giác: ");
int n = int.Parse(Console.ReadLine());
List<TamGiac> danhSach = new List<TamGiac>();

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\nNhập tam giác thứ {i + 1}:");
    TamGiac tg = new TamGiac();
    tg.Nhap();
    danhSach.Add(tg);
}

Console.WriteLine("\nCác tam giác thỏa mãn định lý Pitago:");
foreach (TamGiac tg in danhSach)
{
    if (tg.LaTamGiacVuong())
    {
        tg.InCanh();
        Console.WriteLine($"→ Chu vi: {tg.TinhChuVi()}");
        Console.WriteLine($"→ Diện tích: {tg.TinhDienTich():F2}\n");
    }
}
