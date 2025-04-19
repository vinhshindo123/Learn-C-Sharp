using System.Text;

Console.OutputEncoding = Encoding.UTF8;

void DemSoLuong(int[] a)
{
    int demAm, demDuong;
    demAm = demDuong = 0;
    foreach (int i in a)
    {
        if (i < 0)
        {
            demAm++;
        }
        else if (i > 0)
        {
            demDuong++;
        }
    }
    Console.WriteLine($"Số lượng số âm: {demAm}\nSố lượng số dương: {demDuong}");
}

int n;
Console.Write("Nhập số phần tử của mảng: ");
n = int.Parse(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Nhập phần tử thứ {i + 1}: ");
    a[i] = int.Parse(Console.ReadLine());
}
DemSoLuong(a);
