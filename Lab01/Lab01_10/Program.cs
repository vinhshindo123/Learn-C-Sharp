using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n;
Console.WriteLine("Nhập số nguyên: ");
n = int.Parse(Console.ReadLine());
int dem = 0;
for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        dem++;
    }
}
if (dem == 2)
{
    Console.WriteLine($"{n} là số nguyên tố");
}
else
{
    Console.WriteLine($"{n} không phải là số nguyên tố");
}