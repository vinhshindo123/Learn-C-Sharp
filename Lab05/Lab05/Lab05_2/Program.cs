using Lab05_2;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
List<Hinh> danhSachHinh = new List<Hinh>();

danhSachHinh.Add(new HinhTron(5));
danhSachHinh.Add(new HinhVuong(4));
danhSachHinh.Add(new HinhTamGiac(3, 4, 5));
danhSachHinh.Add(new HinhChuNhat(6, 3));

double tongChuVi = 0;
double tongDienTich = 0;

foreach (var hinh in danhSachHinh)
{
    tongChuVi += hinh.TinhChuVi();
    tongDienTich += hinh.TinhDienTich();
}

Console.WriteLine($"Tổng chu vi các hình: {tongChuVi}");
Console.WriteLine($"Tổng diện tích các hình: {tongDienTich}");
