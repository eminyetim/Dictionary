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
            kullanicilar.Add(1004,"Hüseyin Yilmaz");

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
        
            //Remove
            System.Console.WriteLine("** Remove **");
            kullanicilar.Remove(1004);
            foreach (var item in kullanicilar)
            {
                System.Console.WriteLine(item.Value);
            }

            //Keys
            System.Console.WriteLine("** Keys **");
            foreach (var item in kullanicilar.Keys)
            {
                System.Console.WriteLine(item);
            }

            //Value
            System.Console.WriteLine("** Value **");
            foreach (var item in kullanicilar.Values)
            {
                System.Console.WriteLine(item);
            }


        }   
    }
}