using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n;
Console.Write("Nhập số nguyên: ");
n = int.Parse(Console.ReadLine());
if (n > 0)
{
    Console.WriteLine($"{n} là số nguyên dương");
}
else if (n < 0)
{
    Console.WriteLine($"{n} là số nguyên âm");
}
else
{
    Console.WriteLine($"{n} không là số nguyên âm hoặc số nguyên dương");
}
