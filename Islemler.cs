namespace proje_1
{
     public static class Islemler
    {
        public static void YeniNumaraKaydetmek()
        {
            Console.WriteLine("Lütfen isim giriniz:");
            string isim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz:");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            string no = Console.ReadLine();
            PhoneListModel.PhoneNumberList.Add(new Rehber(isim, soyisim, no));
        }
        public static void VarolanNumarayıSilmek()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            int check = 0;
            string name = Console.ReadLine();
            foreach (var item in PhoneListModel.PhoneNumberList)
            {
                if(item.Isim.ToLower() == name.ToLower() || item.Soyisim.ToLower() == name.ToLower())
                {
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", name);
                    char control = char.Parse(Console.ReadLine());
                    if(control == 'y')
                    {
                        int deleteIndex = PhoneListModel.PhoneNumberList.IndexOf(item);
                        PhoneListModel.PhoneNumberList.RemoveAt(deleteIndex);
                        check++;
                        Console.WriteLine("Silme Onayı Başarılı, Çıkılıyor...");
                        break;
                    }
                    else
                    {
                        check++;
                        Console.WriteLine("Silme Onayı Başarısız, Çıkılıyor...");
                        break;
                    }
                    if (check == 0)
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                        Console.WriteLine("* Yeniden denemek için      : (2)");
                        int selection = int.Parse(Console.ReadLine());
                        if (selection == 2)
                        {
                            while (selection == 2)
                            {
                                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                                name = Console.ReadLine();
                                foreach (var item2 in PhoneListModel.PhoneNumberList)
                                {
                                    
                                    if (item2.Isim.ToLower() == name.ToLower() || item2.Soyisim.ToLower() == name.ToLower())
                                    {
                                        Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", name);
                                        char x = char.Parse(Console.ReadLine());
                                        if (x == 'y')
                                        {
                                            int deleteIndex = PhoneListModel.PhoneNumberList.IndexOf(item2);
                                            PhoneListModel.PhoneNumberList.RemoveAt(deleteIndex);
                                            check++;
                                            selection = 3;
                                            Console.WriteLine("Silme Onayı Başarılı, Çıkılıyor...");
                                            break;
                                        }
                                        else
                                        {
                                            check++;
                                            selection = 3;
                                            Console.WriteLine("Silme Onayı Başarısız, Çıkılıyor...");
                                            break;
                                        }
                                    }
                                }
                                if (check == 0)
                                {
                                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                                    Console.WriteLine("* Yeniden denemek için      : (2)");
                                    selection = int.Parse(Console.ReadLine());  
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void VarolanNumarayıGüncellemek()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string name = Console.ReadLine();
            int count = PhoneListModel.PhoneNumberList.Count;
            int updateControl = 0;
            for (var i = 0; i < count; i++)
            {
                if(PhoneListModel.PhoneNumberList[i].Isim.ToLower() == name.ToLower() || PhoneListModel.PhoneNumberList[i].Soyisim.ToLower() == name.ToLower())
                {
                    Console.WriteLine("Kişi Bulundu ve Telefon Numarası: {0}",PhoneListModel.PhoneNumberList[i].No);
                    Console.WriteLine("Lütfen güncellemek istediğiniz telefon numarasını giriniz...");
                    string newNumber = Console.ReadLine();
                    PhoneListModel.PhoneNumberList[i].No = newNumber;
                    Console.WriteLine("Telefon Numarası Güncellemesi Başarılı, Çıkılıyor...");
                    updateControl++;
                    break;
                }
            }
            if(updateControl == 0)
            {
                Console.WriteLine("Telefon Numarası Güncellemesi Başarısız, Çıkılıyor...");
            }
        }
        public static void RehberiListelemek()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            for (int i = 0; i < PhoneListModel.PhoneNumberList.Count; i++)
            {
                Console.WriteLine("isim: {0}", PhoneListModel.PhoneNumberList[i].Isim);
                Console.WriteLine("Soyisim: {0}", PhoneListModel.PhoneNumberList[i].Soyisim);
                Console.WriteLine("Telefon Numarası: {0}", PhoneListModel.PhoneNumberList[i].No);
                Console.WriteLine("-");
            }
        }
        public static void RehberdeAramaYapmak()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("***********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int select = int.Parse(Console.ReadLine());
            if(select == 1)
            {
                Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin adını ya da soyadını giriniz:");
                string name = Console.ReadLine();
                foreach (var item in PhoneListModel.PhoneNumberList)
                {
                    if (item.Isim.ToLower() == name.ToLower() || item.Soyisim.ToLower() == name.ToLower())
                    {
                        Console.WriteLine("isim: {0}", item.Isim);
                        Console.WriteLine("Soyisim: {0}", item.Soyisim);
                        Console.WriteLine("Telefon Numarası: {0}", item.No);
                        Console.WriteLine("-");
                    }
                }
                Console.WriteLine("Arama İşlemi Bitti, Çıkılıyor...");
            }
            else if(select == 2)
            {
                Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin telefon numarasını giriniz:");
                string no = Console.ReadLine();
                foreach (var item in PhoneListModel.PhoneNumberList)
                {
                    if (item.No == no)
                    {
                        Console.WriteLine("isim: {0}", item.Isim);
                        Console.WriteLine("Soyisim: {0}", item.Soyisim);
                        Console.WriteLine("Telefon Numarası: {0}", item.No);
                        Console.WriteLine("-");
                    }
                }
                Console.WriteLine("Arama İşlemi Bitti, Çıkılıyor...");
            }
            else
            {
                Console.WriteLine("Hatalı Seçim, Çıkılıyor...");
            }
        }
        public static bool BaskaIslem(int number)
        {
            if(number >= 1 && number<= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
    public static class PhoneListModel
    {
        public static List<Rehber> PhoneNumberList = new List<Rehber>();
    }
}