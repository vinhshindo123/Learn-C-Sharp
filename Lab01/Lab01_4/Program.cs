using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n;
Console.Write("Nhập vào một số nguyên: ");
n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
{
    Console.WriteLine($"{n} là số chẵn");
}
else
{
    Console.WriteLine($"{n} là số lẻ");
}
