using System;
using System.Text;

namespace Bai2
{
    public class Ex2
    {
        public static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Nhập số thứ 1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số thứ 2:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số thứ 3:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                if (a>c)
                {
                    Console.WriteLine("Số thứ 1 lớn nhất trong 3 số!");
                }
                else
                {
                    Console.WriteLine("Số thứ 3 lớn nhất trong 3 số!");
                }
            }
            else if (b>c)

                Console.WriteLine("Số thứ 2 lớn nhất trong 3 số!");
            else
                Console.WriteLine("Số thứ 3 lớn nhất trong 3 số!");
            Console.ReadKey();
        }
    }
}
