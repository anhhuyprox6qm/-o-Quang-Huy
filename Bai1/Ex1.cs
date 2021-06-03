using System;
using System.Text;

namespace Bai1
{
    public class Ex1
    {
        public static void ThongTin()
        {
            Console.OutputEncoding=Encoding.UTF8;
            ThongTin thongTin = new ThongTin();
            Console.WriteLine("Tên: ");
            thongTin.Name = Console.ReadLine();
            Console.WriteLine("Đ/C: ");
            thongTin.Address = Console.ReadLine();
            Console.WriteLine("SĐT: ");
            thongTin.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hiển thị thông tin:");
            Console.WriteLine($"Name: {thongTin.Name}, Address: {thongTin.Address}, Phone number: {thongTin.PhoneNumber}");

        }
    }
}
