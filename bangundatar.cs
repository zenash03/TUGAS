using System;

namespace quiz09092019
{
    class bangundatar
    {
        public void luas_persegi()
        {
            Console.WriteLine("luas persegi");
            
            int sisi, luas;

            Console.Write("sisi = ");
            sisi =Convert.ToInt32(Console.ReadLine());

            luas = sisi * sisi;
            Console.WriteLine("luas persegi adalah "+luas);
        }
        public void luas_segitiga()
            {
                Console.WriteLine("luas segitiga");

                int alas, tinggi , luas;

                Console.Write("alas = " );
                alas = Convert.ToInt32(Console.ReadLine());

                Console.Write("tinggi = ");
                tinggi = Convert.ToInt32(Console.ReadLine());

                luas = alas * tinggi / 2;

                Console.WriteLine(" luas segitiga adalah "+luas);
            }
            public void luas_lingkaran()
            {
                Console.WriteLine("luas lingkaran");

                int jari,luas;

                Console.Write("jari-jari = ");
                jari = Convert.ToInt32(Console.ReadLine());

                luas = 22 * jari * jari /7;

                Console.WriteLine("luas lingkaran adalah "+luas);
            }
    }
}