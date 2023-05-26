using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Teknik_Servis
{

class TeknikServis
{
public static string isim;
public static string eh;
public static int bütce;
public void Servis()
{
Console.Clear();
System.Threading.Thread.Sleep(500);

Console.SetWindowSize(70, 30);
Console.ForegroundColor = ConsoleColor.Red;
Console.Clear();
Console.WriteLine("Güncel Para Biriminiz : " + bütce);
Console.WriteLine("");
Console.WriteLine("------     Menü    --------");
Console.WriteLine("");
Console.WriteLine(" 1 - Donanım Test");
Console.WriteLine("");
Console.WriteLine(" 2 - İç / Dış Temizleme");
Console.WriteLine("");
Console.WriteLine("___________________________");
Console.WriteLine("");
Console.Write(" Seçim Yapınız : ");
byte secim = Convert.ToByte(Console.ReadLine());

if (secim == 1)
{
Console.Write(" Başarı Ölçme 50TL Onaylıyor Musunuz ? E / H : ");
eh = Console.ReadLine();

if (eh == "H")
{
Console.WriteLine(" İşlem İptal Edildi!");
}
if (eh == "E")
{
if (bütce > 50)
{
    Console.Clear();
    Random rnd = new Random();
    int random = rnd.Next(40, 100);
    Console.WriteLine(" - " + random + " Başarı Yüzdesi.");
    bütce -= 50;
}
if (bütce < 50)
{
    Console.WriteLine(" Para Birimi Yetersiz!");
}

}
}
if (secim == 2)
{
Console.Clear();
Console.Write(" İç / Dış Temizleme 250TL Onaylıyor Musunuz ? E / H : ");
eh = Console.ReadLine();

if (eh == "H")
{
Console.WriteLine(" İşlem İptal Edildi!");
}
if (eh == "E")
{
if (bütce > 250)
{
    Console.Clear();
    Console.Write("İç Yıkıma / Dış Yıkama Seçim Yapınız : ");
    string içdıs = Console.ReadLine();
    System.Threading.Thread.Sleep(500);
    Console.Clear();
    bütce -= 250;
    Console.WriteLine(isim + " : " + bütce + " Kalan Güncel Bütçe");
}
if (bütce < 250)
{
    Console.WriteLine(" Para Birimi Yetersiz!");
}

}
}
if (secim > 2)
{
Console.WriteLine(" Geçersiz SAYI / KARAKTER !");
}

}
        public void telefonServis()
        {
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.SetWindowSize(70, 30);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Güncel Para Biriminiz : " + bütce);
            Console.WriteLine("");
            Console.WriteLine("------     Menü    --------");
            Console.WriteLine("");
            Console.WriteLine(" 1 - Donanım Test");
            Console.WriteLine("");
            Console.WriteLine(" 2 - İç / Dış Temizleme");
            Console.WriteLine("");
            Console.WriteLine(" 3 - Telefon Öneri / İndirimde Olan Ürünler");
            Console.WriteLine("");
            Console.WriteLine("___________________________");
            Console.WriteLine("");
            Console.Write(" Seçim Yapınız: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.Write(" Başarı Ölçme 50TL Onaylıyor Musunuz ? E / H : ");
                eh = Console.ReadLine();

                if (eh == "H")
                {
                    Console.WriteLine(" İşlem İptal Edildi!");
                }
                if (eh == "E")
                {
                    if (bütce > 50)
                    {
                        Console.Clear();
                        Random rnd = new Random();
                        int random = rnd.Next(40, 100);
                        Console.WriteLine(" - " + random + " Başarı Yüzdesi.");
                        bütce -= 50;
                    }
                    if (bütce < 50)
                    {
                        Console.WriteLine(" Para Birimi Yetersiz!");
                    }

                }
                
            }
            if (secim == 2)
            {
                Random rnd = new Random();
                int para = rnd.Next(120, 300);
                Console.WriteLine("Temizleme Ücreti :" + para);
            }
            if (secim == 3)
            {
                Console.WriteLine("Öneri İçin (1)");
                Console.WriteLine("");
                byte secenek = Convert.ToByte(Console.ReadLine());
                if (secenek == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Uygun Fiyat Listesi | İndirimde Olan Ürünler");
                    Console.WriteLine("");
                    Console.WriteLine("_____________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("1 - İphone 13 - 19.400TL");
                    Console.WriteLine("");
                    Console.WriteLine("2 - Samsung S22 Ultra - 14.500TL");
                    Console.WriteLine("");
                    Console.WriteLine("3 - Xiaomi Redmi 10C - 5.000TL");
                    Console.WriteLine("");
                    Console.WriteLine("Haftalık İndirimdeki Ürünler Bunlardır.");
                    Console.WriteLine("");
                    Console.WriteLine("Satın Alım Yapmıcaksanız 4'ü Tuşlayın.");
                    Console.WriteLine("___________________________________________");
                    Console.WriteLine("Almak İstediğiniz Bir Ürün Giriniz : ");
                    byte tel = Convert.ToByte(Console.ReadLine());
                    if (tel == 1)
                    {
                        Console.WriteLine("Siparişiniz Alındı!");
                        Thread.Sleep(500);
                        Console.WriteLine("İphone 13");
                        Console.WriteLine("İşlemi Onaylıyor Musunuz (E/H) : ");
                        eh = Console.ReadLine();
                        if (eh == "E")
                        {
                            if (bütce >= 19400)
                            {
                                Console.WriteLine("Siparişiniz ONAYLANDI!");
                                Console.WriteLine("");
                                bütce -= 19400;
                                Console.WriteLine("Güncel Bütceniz : " + bütce);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Çıkış Yapıldı!");
                        }
                    }
                    if (tel == 2)
                    {
                        Console.WriteLine("Siparişiniz Alındı!");
                        Thread.Sleep(500);
                        Console.WriteLine("Samsung S22 Ultra");
                        Console.WriteLine("İşlemi Onaylıyor Musunuz (E/H) : ");
                        eh = Console.ReadLine();
                        if (eh == "E")
                        {
                            if (bütce >= 14500)
                            {
                                Console.WriteLine("Siparişiniz ONAYLANDI!");

                                Console.WriteLine("");
                                bütce -= 14500;
                                Console.WriteLine("Güncel Bütceniz : " + bütce);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Çıkış Yapıldı!");
                        }
                    }
                    if (tel == 3)
                    {
                        Console.WriteLine("Siparişiniz Alındı!");
                        Thread.Sleep(500);
                        Console.WriteLine("Xiaomi Redmi 10C");
                        Console.WriteLine("İşlemi Onaylıyor Musunuz (E/H) : ");
                        eh = Console.ReadLine();
                        if (eh == "E")
                        {
                            if (bütce >= 5000)
                            {
                                Console.WriteLine("Siparişiniz ONAYLANDI!");

                                Console.WriteLine("");
                                bütce -= 5000;
                                Console.WriteLine("Güncel Bütceniz : " + bütce);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Çıkış Yapıldı!");
                        }
                    }
                    if (tel == 4)
                    {
                        Console.WriteLine("Çıkış Yapıldı!");
                    }
                }
             
            }
            if (secim > 3)
            {
                Console.WriteLine("Geçersiz Karakter / Sayı Algılandı!");
            }
        }
public void müsteri()
{

Console.Clear();
System.Threading.Thread.Sleep(500);
Console.SetWindowSize(80, 30);
Console.ForegroundColor = ConsoleColor.White;
System.Threading.Thread.Sleep(500);
Console.Clear();
Console.WriteLine(" Hoşgeldin " + isim);
System.Threading.Thread.Sleep(500);
Console.WriteLine("");
Console.WriteLine("- Telefon Hataları      (1)");
Console.WriteLine("- Bilgisayar Hataları   (2)");
Console.WriteLine("");
Console.Write("Seçim Yapınız : ");
byte secim = Convert.ToByte(Console.ReadLine());
if (secim == 1)
{
Console.Clear();
Console.WriteLine(isim + "     Sıkça Alınan Hatalar ");
Console.WriteLine("");
Console.WriteLine("| - - - - - - - - - - - - - - - - - |");
Console.WriteLine("");
Console.WriteLine(" Dokunmatik Hatası        (1)");
Console.WriteLine(" Şarj Sorunu              (2)");
Console.WriteLine(" Isınma Sorunu            (3)");
Console.WriteLine(" Şebeke Sorunu            (4)");
Console.WriteLine("");
Console.WriteLine("| - - - - - - - - - - - - - - - - - |");
Console.WriteLine("");
Console.Write("Numara Giriniz : ");
byte hata = Convert.ToByte(Console.ReadLine());
if (hata == 1)
{
Console.Clear();
Console.WriteLine("Dokunmatik Hatası ");
Console.WriteLine("");
Console.WriteLine("Ücret 200 TL Onaylıyor musunuz? E / H");
string eh = Console.ReadLine();
if (eh == "H")
{
    Console.WriteLine(" İşlem İptal Edildi.");
    System.Threading.Thread.Sleep(1000);
}
if (eh == "E")
{
    if (bütce >= 200)
    {
        Console.WriteLine("İşlem Onaylandı! ");
        System.Threading.Thread.Sleep(5000);
        Console.WriteLine("Ekran Değişimi Yapılıyor..");
        System.Threading.Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("Ekran Değişildi");
        Console.WriteLine("Ekran Değişimi = 200TL");
        bütce -= 200;
        Console.WriteLine(isim + " : " + bütce + " Geriye Kalan Paranız.");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("");
    }

    if (bütce < 200)
    {
        Console.WriteLine("Para Biriminiz Yetersiz!");
        System.Threading.Thread.Sleep(1000);
    }


}
}
if (hata == 2)
{
Console.Clear();
Console.WriteLine("Şarj Sorunu");
Console.WriteLine("");
Console.Write("Ücret 500 TL Onaylıyor musunuz? E / H : ");
string eh = Console.ReadLine();
if (eh == "H")
{
    Console.WriteLine("İşlem İptal Edildi.");
}
if (eh == "E")
{
    if (bütce >= 500)
    {
        Console.WriteLine("İşlem Onaylandı! ");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Şarj Girişi Değişimi Yapılıyor..");
        System.Threading.Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("Şarj Girişi Temizlendi");
        Console.WriteLine("Şarj Sorunu Halledildi = 500TL");
        bütce -= 500;
        Console.WriteLine(isim + " : " + bütce + " Geriye Kalan Paranız.");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("");
    }

    if (bütce < 500)
    {
        Console.WriteLine(" Para Biriminiz Yetersiz!");
    }

}
}
if (hata == 3)
{
    Console.Clear();
    Console.WriteLine("Isınma Sorunu");
    Console.WriteLine("");
    Console.Write("Ücret 800 TL Onaylıyor musunuz? E / H : ");
    eh = Console.ReadLine();

    if (eh == "E")
    {
        if (bütce >= 800)
        {
            Console.WriteLine("İşlem Onaylandı! ");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Uygulamalar Siliniyor..");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Telefon Temizlendi");
            Console.WriteLine("Isınma Sorunu Halledildi = 800TL");
            bütce -= 800;
            Console.WriteLine(isim + " : " + bütce + " Geriye Kalan Paranız.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine("Batarya 150Tl!");
            Console.Write("Batarya Değişimi Gerekmektedir Onaylıyor Musunuz? (E / H) :");
            string sb = Console.ReadLine();
            if (sb == "E")
            {
                if (bütce >= 150)
                {
                    Console.WriteLine("Tamire Veriliyor!");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Batarya Değişildi!");
                    Console.WriteLine("");
                    bütce -= 150;
                    Console.WriteLine("Kalan Bütçe : " + bütce);
                    Console.WriteLine("İyi Günler!");
                }
                if (bütce < 150)
                {
                    Console.WriteLine("İşlem Yapılamadı Bütçe Yetersiz!");
                }
            }
            if (sb == "H")
            {
                Console.WriteLine("İşlem İptal Edildi!");
            }
        }
        if (eh == "H")
        {
            Console.WriteLine("İşlem İptal Edildi.");
        }
        if (bütce < 500)
        {
            Console.WriteLine(" Para Biriminiz Yetersiz!");
        }
    }

}
if (hata == 4)
{
    Console.WriteLine("Şebeke Sorunu Çözüm Hattı!");
    Thread.Sleep(500);
    Console.Clear();
    Console.Write("Ücret 200Tl Onaylıyor Musunuz (E/H) : ");
    eh = Console.ReadLine();
    if (eh == "E" && eh == "e")
    {
        if(bütce >= 200)
        {
            Console.WriteLine("Telefon Yeniden Başlatılıyor!");
            Console.WriteLine("Sim Kartı Çıkarıldı.");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Şebeke Sorunu Çözüldü!");
            Console.WriteLine("");
            bütce -= 200;
            Console.WriteLine("Güncel Bütceniz : " + bütce);
        }
        else
        {
            Console.WriteLine("Yetersiz Bakiye!");
        }
    }
}

if (hata > 4)
{
    Console.WriteLine(" Geçersiz Karakter / Sayı Algılandı!");
}
}      
if (secim == 2)
{
Console.Clear();
Console.WriteLine(isim + "      Sıkça Alınan Hatalar ");
Console.WriteLine("");
Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
Console.WriteLine("");
Console.WriteLine(" Güç Kablosu Temassızlığı (1)");
Console.WriteLine(" İnternet Yok             (2)");
Console.WriteLine(" Format'ta Hata Alıyorum  (3)");
Console.WriteLine(" Mavi Ekran Alıyorum      (4)");
Console.WriteLine(" Erişim Engellendi Hatası (5)");
Console.WriteLine("");
Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
Console.Write("Seçim Yapınız : ");
byte sv = Convert.ToByte(Console.ReadLine());
if (sv == 1)
{
Console.Clear();
Console.WriteLine("Güç Kablosu Temassızlığı");
Console.WriteLine("");
Console.WriteLine("Ücret 1500 Tl Onaylıyor Msunuz?(E/H) :");
eh = Console.ReadLine();
if (eh == "E")
{
    if (bütce >= 1500)
    {
        Console.WriteLine("İşlem Onaylandı!");
        System.Threading.Thread.Sleep(500);
        Console.Clear();
        bütce -= 1500;
        Console.WriteLine("");
        Console.WriteLine("Kalan Bütçe : " + bütce);
    }
}
if (eh == "H")
{
    Console.WriteLine("İşlem İptal Edildi!");
}
if (bütce < 1500)
{
    Console.WriteLine("İşlem Yapılamadı , Bütçe Yetersiz!");
}
}
if (sv > 5)
{
Console.WriteLine("Geçersiz Karakter / Sayı Saptandı!");
}
}
if (secim > 2)
{
Console.WriteLine(" Geçersiz Karakter / Sayı Algılandı!");
}



            
}
internal class Program : TeknikServis
{

static void Main(string[] args)
{

Console.ForegroundColor = ConsoleColor.Cyan;
TeknikServis srv = new TeknikServis();
Console.WriteLine("   Enes       Teknik   <3");
System.Threading.Thread.Sleep(1000);
Console.Clear();
Console.Write("Sana Nasıl Hitap Edelim : ");
isim = Console.ReadLine();
Console.Write("Bütçe Giriniz : ");
bütce = Convert.ToInt32(Console.ReadLine());
Console.Clear();

e:
System.Threading.Thread.Sleep(1000);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(isim + " Güncel Para Birimin : " + bütce);
Console.WriteLine("");
Console.WriteLine("______________________________________");
Console.WriteLine("");
Console.WriteLine(" 1 - Bilgisayar  |     Servis        |");
Console.WriteLine("");
Console.WriteLine(" 2 - Telefon     |     Servis        |");
Console.WriteLine("");
Console.WriteLine(" 3 - Teknik      |     Servis        |");
Console.WriteLine("______________________________________");
Console.WriteLine("");
Console.Write(" Seçim Yapınız : ");
byte secim = Convert.ToByte(Console.ReadLine());
if (secim == 1)
{
Console.Clear();
Console.WriteLine(" Bilgisayar Servisi ");
Console.WriteLine("");
srv.Servis();

}
if (secim == 2)
{
Console.Clear();
Console.WriteLine(" Telefon Servisi ");
Console.WriteLine("");
srv.telefonServis();
}
if (secim == 3)
{
Console.Clear();
Console.WriteLine(" Müşteri Hizmetleri ");
Console.WriteLine("");
srv.müsteri();
}
goto e;
Console.ReadKey();
}
}
}
}
