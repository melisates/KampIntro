// See https://aka.ms/new-console-template for more information

//tekrar tekrar kullanılabilmeyi sağlayan bir ortam sağlar

//dont repeat yourself-DRY-clean code

using Metotlar;

string urunAdi = "Elma";
double fiyati = 15;
string aciklama = "amasya elması";

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elmasi";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] {urun1, urun2};

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi );
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("***********");
}



Console.WriteLine("---------------Metotlar--------------------");

//instance 
// encapsulation

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("armut", "yeşil armut", 13,60);


