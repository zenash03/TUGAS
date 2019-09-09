using System;

namespace quiz09092019
{
    class Bangunruang
    {
        public void volume_kubus()
        {
            Console.WriteLine("volume kubus");

            int sisi,volume;

            Console.Write("sisi = ");
            sisi =Convert.ToInt32(Console.ReadLine());

            volume = sisi * sisi * sisi;
            
            Console.WriteLine("volume kubus adalah "+volume);
        }
        public void volume_balok()
        {
            Console.WriteLine("volume balok");
            int p, l, t,volume;

            Console.Write("panjang = ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("lebar = ");
            l = Convert.ToInt32(Console.ReadLine());

            Console.Write("tinggi = ");
            t = Convert.ToInt32(Console.ReadLine());

            volume= p * l * t;

            Console.WriteLine("volume balok adalah "+volume);
        }
    }
}  
