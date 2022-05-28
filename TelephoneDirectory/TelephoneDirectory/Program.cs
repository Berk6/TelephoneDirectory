using System;

namespace TelephoneDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool uygulama = true;
                Directory directory = new Directory();
            while (uygulama)
            {
                uint menuNumber = 0;
                Console.WriteLine("Yapmak istediğiniz işlemi seçin");
                Console.WriteLine("(1) Telefon Numarası Kaydetmek");
                Console.WriteLine("(2) Telefon Numarası Silmek");
                Console.WriteLine("(3) Telefon Numarası Güncellemek");
                Console.WriteLine("(4) Rehber Listelemek");
                Console.WriteLine("(5) Uygulamayı Sonlandırmak");
                try
                {
                    menuNumber = uint.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("1-6 arasında sayısal değer giriniz");
                    continue;
                }
                if (menuNumber > 6)
                {
                    Console.WriteLine("hatalı tuşlama yaptınız1");
                    continue;
                }
                switch (menuNumber)
                {
                    case 1:
                        directory.AddDirectory();
                        break;
                    case 2:
                        directory.DeleteDirectory();
                        break;
                    case 3:
                        directory.UpdateDirectory();
                        break;
                    case 4:
                        directory.ListToDirectory();
                        break;
                    case 5:
                        uygulama = false;
                        break;
                }
            }
        }
    }
}
