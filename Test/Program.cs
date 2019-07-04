using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("======================== HE THONG QUAN LY NHAN SU ==============================");

            Console.WriteLine("| 1.Nhap thong tin Nhan vien                                                   |");
            Console.WriteLine("| 2.In thong tin Nhan vien                                                     |");
            Console.WriteLine("| 3.Thong ke                                                                   |");
            Console.WriteLine("|   3.1.Co bao nhieu Nhan vien trong He thong? Ti le Nam, Nu trong He thong ?  |");
            Console.WriteLine("|   3.2.Co bao nhieu Nhan vien sap den tuoi nghi huu?                          |");
            Console.WriteLine("|   3.3.Tong quy luong phai tra?                                               |");
            Console.WriteLine("================================================================================");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Nhap thong tin");
                    break;
                case 2:
                    Console.WriteLine("In thong tin");
                    break;
                case 3:
                    Console.WriteLine("Nhap thong tin");
                    break;
                default:
                    break;
            }

        }
    }
}
