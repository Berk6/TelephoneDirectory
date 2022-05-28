using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory
{
    public class Directory
    {
        string name;
        string surname;
        long telNumber;
        int selectedNumber;
        int counter = 1;
        List<string> Name = new List<string>();
        List<string> Surname = new List<string>();
        List<long> Number = new List<long>();

        public void AddDirectory()
        {
            Console.Write(" Lütfen isim giriniz             :");
            name = Console.ReadLine();
            Console.Write(" Lütfen soyisim giriniz          :");
            surname = Console.ReadLine();
            Console.Write(" Lütfen telefon numarası giriniz :");
            for (int i = 0; i < counter; i++)
            {
                try
                {
                    telNumber = long.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("girilen telefon numarası hatalıdır tekrar giriniz");
                    counter++;
                }
            }
            Name.Add(name);
            Surname.Add(surname);
            Number.Add(telNumber);
        }
        public void DeleteDirectory()
        {
            ListToDirectory();
            Console.WriteLine("Hangi numara üzerinde işlem yapmak istiyorsunuz? Menuye donmek için 0'ı tuşlayın");
            try
            {
                selectedNumber = int.Parse(Console.ReadLine()) - 1;
            }
            catch
            {
                Console.WriteLine("sayısal değer girin");
                DeleteDirectory();
                return;
            }
            if (selectedNumber == -1)
            {
                return;
            }
            if (selectedNumber > Name.Count - 1)
            {
                Console.WriteLine("Seçtiğiniz numaraya ait veri bulunamadı");
                return;
            }
            Name.RemoveAt(selectedNumber);
            Surname.RemoveAt(selectedNumber);
            Number.RemoveAt(selectedNumber);
        }
        public void UpdateDirectory()
        {
            counter = 1;
            ListToDirectory();
            Console.WriteLine("Hangi numara üzerinde işlem yapmak istiyorsunuz? Menuye donmek için 0'ı tuşlayın");
            try
            {
                selectedNumber = int.Parse(Console.ReadLine()) - 1;
            }
            catch
            {
                Console.WriteLine("sayısal değer girin");
                UpdateDirectory();
                return;
            }
            if (selectedNumber == -1)
            {
                return;
            }
            if (selectedNumber > Name.Count - 1)
            {
                Console.WriteLine("Seçtiğiniz numaraya ait veri bulunamadı");
                return;
            }
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("adı değiştirmek istiyorsanız(1)'e \n soyadı değiştirmek istiyorsanız(2)'e \n numarayı değiştirmek istiyorsanız(3)'e \n  basıp onaylayın ");
                short number = short.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("yeni ad giriniz");
                        Name[selectedNumber] = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("yeni soyad giriniz");
                        Surname[selectedNumber] = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("yeni numara giriniz");
                        Number[selectedNumber] = long.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("yanlış tuşlama yaptınız");
                        counter++;
                        break;
                }
            }
        }
        public void ListToDirectory()
        {
            for (int list = 0; list < Name.Count; list++)
            {
                Console.WriteLine($"{list + 1}. sıradaki kayıt");
                Console.WriteLine(Name[list]);
                Console.WriteLine(Surname[list]);
                Console.WriteLine(Number[list]);
            }
        }
        public void ListToDirectory(int indexNumber)
        {
            try
            {
                Console.WriteLine(Name[indexNumber]);
                Console.WriteLine(Surname[indexNumber]);
                Console.WriteLine(Number[indexNumber]);
            }
            catch
            {
                Console.WriteLine("aranılan ifade bulunamadı");
            }
        }
    }
}
