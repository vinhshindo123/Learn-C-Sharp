using System.Text;

Console.OutputEncoding = Encoding.UTF8;

bool LaSoNguyenTo(int n)
{
    if (n < 2) return false;
    if (n == 2) return true;

    for (int i = 2; i < Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
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

for (int i = 0; i < n; i++)
{
    if (LaSoNguyenTo((int)a[i]))
    {
        Console.WriteLine($"{a[i]} là số nguyên tố, ở vị trí thứ {i + 1}");
    }
}