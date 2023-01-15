using System;

namespace dictimory
{
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Dictinory");

            //Dictinory <key , value> dicKullanicilar = new Dictinory <key , string >();

            Dictionary<int , string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(1001,"Ahmet Yilmaz");
            kullanicilar.Add(1002,"Ali Yilmaz");
            kullanicilar.Add(1003,"Veli Yilmaz");

        }
    }
}