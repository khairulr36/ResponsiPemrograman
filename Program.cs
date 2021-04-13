using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3309
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, bonus1a, bonus1b, bonus2a, bonus2b;
            // objek clas karyawan
            karyawan kar1 = new karyawan();
            karyawan kar2 = new karyawan();
            // memasukan nilai/data
            kar1.Nama = "Paijo";
            kar1.Nik = "190302123";

            kar2.Nama = "Jono";
            kar2.Nik = "190302124";

            // memanggil
            cetakjudul();
            kar1.karyawaninfo1();
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                a = 0;
            }
            kar2.karyawaninfo2();
            b = Convert.ToInt32(Console.ReadLine());
            if (b < 0)
            {
                b = 0;
            }

            Console.WriteLine();
            alhamdullilah();
            Console.WriteLine();

            kar1.bonus1();
            bonus1a = a * 10/100;
            bonus1b = a + bonus1a;
            Console.WriteLine(bonus1b);
            kar2.bonus2();
            bonus2a = b * 10 / 100;
            bonus2b = b + bonus2a;
            Console.WriteLine(bonus2b);




            Console.ReadKey();
        }


        static void cetakjudul()
        {
            Console.WriteLine("NO   NIK/Nama        Gaji bulanan");
            Console.WriteLine("----------------------------------");
        }
        static void alhamdullilah()
        {
            Console.WriteLine("Alhamdulillah dapat kenaikan gaji 10%!!");
        }
    
    }
}
