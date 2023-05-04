// See https://aka.ms/new-console-template for more information

string adi = "Melisa";
int yas = 21;

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C++";
kurs1.Eğitmen = "Engin Demiroğ";
kurs1.IzlenmeOrani = 69;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Eğitmen = "Engin Demiroğ";
kurs2.IzlenmeOrani = 679;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Eğitmen = "Engin Demiroğ";
kurs3.IzlenmeOrani = 369;

//Console.WriteLine(kurs1.KursAdi+" : "+kurs1.Eğitmen);

//Kurs[] kurslar = new Kurs[] {kurs1, kurs2 , kurs3 };
//foreach (var kurs in kurslar)
//{
//    Console.WriteLine(kurs.KursAdi+" : " + kurs.Eğitmen);
//}




Urun urun1 = new Urun();
urun1.Fiyat = 100;
urun1.UrunKategori = "Tişört";
urun1.UrunRenk = "Mavi";

Urun urun2 = new Urun();
urun2.Fiyat = 360;
urun2.UrunKategori = "Pantolon";
urun2.UrunRenk = "Siyah";

Urun urun3 = new Urun();
urun3.Fiyat = 170;
urun3.UrunKategori = "Sweat";
urun3.UrunRenk = "Beyaz";

Urun urun4= new Urun();
urun4.Fiyat = 155;
urun4.UrunKategori = "Şapka";
urun4.UrunRenk = "Beyaz";

Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4 };

//foreach loop start
foreach (var urun in urunler)
{
    Console.WriteLine(urun.UrunRenk+ " "+ urun.UrunKategori+ " : " + urun.Fiyat+"TL");
}
//foreach loop end 


//for loop start
for (int i = 0; i < urunler.Length; i++)
{
   Console.WriteLine(urunler[i].UrunRenk + " " + urunler[i].UrunKategori+" : "+urunler[i].Fiyat);
}
//for loop end 




//while loop start
int k = 0;
while (k<urunler.Length)
{
    Console.WriteLine(urunler[k].UrunRenk + " " + urunler[k].UrunKategori + " : " + urunler[k].Fiyat);
    k++;
}
//while loop end 

class Urun
{
    public int Fiyat { get; set; }
    public string UrunKategori{ get; set; }

    public string UrunRenk { get; set; }

}


class Kurs
{
    public string KursAdi { get; set; }
    public string Eğitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}