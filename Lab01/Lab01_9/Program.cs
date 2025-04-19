using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n;
Console.Write("Nhập số nguyên n: ");
n = int.Parse(Console.ReadLine());
int giaiThua = 1;
int i = n;
while (i > 0)
{
    giaiThua *= i;
    i--;
}
Console.WriteLine($"Giai thừa của {n} là: {giaiThua}");