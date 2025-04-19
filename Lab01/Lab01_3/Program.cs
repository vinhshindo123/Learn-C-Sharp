using System.Text;

Console.OutputEncoding = Encoding.UTF8;

double doC;
Console.Write("Nhập độ C: ");
doC = double.Parse(Console.ReadLine());
double doF = (doC * 9 / 5) + 32;
Console.WriteLine($"Độ C là {doC}, độ F tương ứng là {doF}");
