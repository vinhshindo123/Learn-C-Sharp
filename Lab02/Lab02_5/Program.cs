using System.Text;

Console.OutputEncoding = Encoding.UTF8;

void HoanDoi(ref int a, ref int b)
{
    int c = a;
    a = b;
    b = c;
}

int a, b;
Console.Write("Nhập số nguyên a: ");
a = int.Parse(Console.ReadLine());
Console.Write("Nhập số nguyên b: ");
b = int.Parse(Console.ReadLine());
HoanDoi(ref a, ref b);
Console.WriteLine($"Hai số a và b sau khi hoàn đổi là: a - {a}, b - {b}");