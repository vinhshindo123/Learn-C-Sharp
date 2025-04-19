using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int nam;
Console.WriteLine("Nhập vào 1 năm: ");
nam = int.Parse(Console.ReadLine());
if (nam % 100 == 0)
{
    if (nam % 4 == 0)
    {
        Console.WriteLine($"{nam} là năm nhuận");
    }
    else
    {
        Console.WriteLine($"{nam} không phải năm nhuận");
    }
}
else
{
    if (nam % 4 == 0)
    {
        Console.WriteLine($"{nam} là năm nhuận");
    }
    else
    {
        Console.WriteLine($"{nam} không phải năm nhuận");
    }
}