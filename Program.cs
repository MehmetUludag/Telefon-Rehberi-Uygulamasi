namespace proje_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            PhoneListModel.PhoneNumberList.Add(new Rehber("Mehmet", "Uludağ", "325"));
            PhoneListModel.PhoneNumberList.Add(new Rehber("Ayşe", "Uludağ", "441"));
            PhoneListModel.PhoneNumberList.Add(new Rehber("Kadir", "Uludağ", "535"));
            PhoneListModel.PhoneNumberList.Add(new Rehber("Emine", "Uludağ", "735"));
            PhoneListModel.PhoneNumberList.Add(new Rehber("Remzi", "Halka", "329"));

            BaslangicEkrani();
            int n = Convert.ToInt16(Console.ReadLine());

            while(Islemler.BaskaIslem(n))
            {
                switch (n)
                {
                    case 1:
                        Islemler.YeniNumaraKaydetmek();
                        break;
                    case 2:
                        Islemler.VarolanNumarayıSilmek();
                        break;
                    case 3:
                        Islemler.VarolanNumarayıGüncellemek();
                        break;
                    case 4:
                        Islemler.RehberiListelemek();
                        break;
                    case 5:
                        Islemler.RehberdeAramaYapmak();
                        break;
                    default:
                        Console.WriteLine("Lütfen 1 ile 5 arası bir sayı giriniz!");
                        break;
                }

                BaslangicEkrani();
                n = int.Parse(Console.ReadLine());
            }
        }

        static void BaslangicEkrani()
        {
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncellemek");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
        }
    }
}