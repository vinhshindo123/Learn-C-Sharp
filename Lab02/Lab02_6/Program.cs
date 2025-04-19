using System.Text;

Console.OutputEncoding = Encoding.UTF8;

void SapXep(int[] a)
{
    int n = a.Length;
    for (int i = 0; i < n; i++)
    {
        for (int j = i; j < n; j++)
        {
            if (a[i] > a[j])
            {
                int c = a[i];
                a[i] = a[j];
                a[j] = c;
            }
        }
    }
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

SapXep(a);

foreach (int i in a)
{
    Console.Write(i + " ");
}
