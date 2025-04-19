using System.Text;

Console.OutputEncoding = Encoding.UTF8;

double a, b;
Console.Write("Nhập số thứ nhất: ");
a = double.Parse(Console.ReadLine());
Console.Write("Nhập số thứ hai: ");
b = double.Parse(Console.ReadLine());
double tong = a + b;
double tich = a * b;
Console.WriteLine($"Tổng 2 số là {tong}\nTích 2 số là {tich}");
