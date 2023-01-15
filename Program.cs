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

            //Listing

            System.Console.WriteLine("** Listing ***");

            System.Console.WriteLine("Key 1001 : " + kullanicilar[1001]);

            foreach (var item in kullanicilar)
            {
                System.Console.WriteLine(item);
            }

            //Count

            System.Console.WriteLine("** Count **");

            System.Console.WriteLine(kullanicilar.Count);


            //Contains (is there ?)
            System.Console.WriteLine("** Contains **");
            System.Console.WriteLine(kullanicilar.ContainsKey(1003));
            System.Console.WriteLine(kullanicilar.ContainsValue("Hasan Yilmaz"));
        }   
    }
}