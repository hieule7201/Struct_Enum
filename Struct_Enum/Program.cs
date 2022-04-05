using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Struct_Enum
{
    class Program
    {
        struct SinhVien
        {
            public int MaSv_121;
            public string HoTen_121;
            public double Toan_121;
            public double Ly_121;
            public double Hoa_121;
        }
        enum HocLuc {
            Kem_121, TrungBinh_121 = 4, Kha_121 = 6, Gioi_121 = 8
        }
        static void nhap(ref SinhVien[] ds_121, int n_121)
        {
            for (int i_121 = 0; i_121 < n_121; i_121++)
            {
                Console.Write("nhap vao MSV: ");
                ds_121[i_121].MaSv_121 = int.Parse(Console.ReadLine());
                Console.Write("nhap vao Ho Ten: ");
                ds_121[i_121].HoTen_121 = Console.ReadLine();
                Console.Write("Nhap vao diem Toan: ");
                ds_121[i_121].Toan_121 = double.Parse(Console.ReadLine());
                Console.Write("Nhap vao diem Ly: ");
                ds_121[i_121].Ly_121 = double.Parse(Console.ReadLine());
                Console.Write("Nhap vao diem Hoa: ");
                ds_121[i_121].Hoa_121 = double.Parse(Console.ReadLine());
            }
        }
        static void hien(SinhVien[] ds_121)
        {
            Console.WriteLine("danh sach vua nhap vao la");
            foreach (SinhVien item_121 in ds_121)
            {
                Console.WriteLine("Ma SV: " + item_121.MaSv_121);
                Console.WriteLine("Ho Ten: " + item_121.HoTen_121);
                Console.WriteLine("Toan: " + item_121.Toan_121);
                Console.WriteLine("Toan: " + item_121.Ly_121);
                Console.WriteLine("Toan: " + item_121.Hoa_121);
                Console.WriteLine("DTB: " + DiemTBSinhVien(item_121));
            }
        }
        static double DiemTBSinhVien(SinhVien SV_121)
        {
            return (SV_121.Toan_121 + SV_121.Ly_121 + SV_121.Hoa_121) / 3;
        }
        static void TimKiem(String ten_121, SinhVien[] ds_121)
        {
            foreach (SinhVien item_121 in ds_121)
            {
                if (ten_121.ToLower() == item_121.HoTen_121.ToLower())
                {
                    double DTB_121 = DiemTBSinhVien(item_121);
                    Console.WriteLine("Ho Ten: " + item_121.HoTen_121);
                    Console.WriteLine("DTB: " + DTB_121);
                    if (DTB_121 >= (double)HocLuc.Gioi_121)
                        Console.WriteLine("Hoc Luc: " + (HocLuc)8);
                    else if (DTB_121 >= (double)HocLuc.Kha_121)
                        Console.WriteLine("Hoc Luc: " + (HocLuc)6);
                    else if (DTB_121 >= (double)HocLuc.TrungBinh_121)
                        Console.WriteLine("Hoc Luc: " + (HocLuc)4);
                    else
                        Console.WriteLine("Hoc Luc: " + (HocLuc)0);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("nhap vao so sinh vien <100: ");
            int n_121 = int.Parse(Console.ReadLine());
            SinhVien[] ds_121 = new SinhVien[n_121];
            nhap(ref ds_121, n_121);
            hien(ds_121);
            Console.Write("nhap ten sinh vien can tim: ");
            String ten_121 = Console.ReadLine();
            TimKiem(ten_121, ds_121);
            Console.ReadLine();
        }
    }
}
