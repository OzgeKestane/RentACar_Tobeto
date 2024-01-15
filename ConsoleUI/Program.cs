#region Degiskenler // metinsel ifade yazılabilir, yazılmayadabilir
// Değişkenler
// Type safety , tip güvenli
//bellekte kaplayacağı alanı önceden ayırmış oluyoruz hem de alabileceği değerleri ve aralığını belirlemiş oluyoruz.

//string karsilama = "Hellooo World!";
// var deneme = 3546; var yazdığımızda ide karşıdaki değerin ne olduğunu bilip ona göre değişkeni ifade ediyo

// var yil=2023; Derlemede aşamasında veri tipini kendisi belirliyor

//İLKEL TİP 
// int yil = 2023; tam sayı 32-bit int.MaxValue ( int. max değeri) ~2.1 milyar (- , +)
//short yil = 2023; 16-bit ~32 bin (- , +)
//ushort yil = 2023; // unsigned - değerleri yok 16bit 0 ila ~+65bin arasında

//Console.WriteLine(yil);

//byte yas = 25; //0-255 arasında
////long hesaplamaSonucu = long.MaxValue; 64-bit sonucun çok büyük çıkacağı hesaplamalarda kullanılır unsigned türü de var

//float dolarKuru = 29.06f; // 32 bit 
//double dolarKuru2 = 29.0655865478; //64 bit ondalık kısmı daha fazla tutulabiliyor,
//decimal dolarKuruDecimal = 9.02451285265m; // 128 bit hassas verilerde, hesaplama sonucunda ondalık kısmı daha çok oluyor
//bool dogruMu = true;// 1-bit, en küçük sayı için en küçük yer alan kaplıyor. 2 değer alır true ya da false, default:false
//char karakter = 'A'; //65 sayısına denk geliyor, ASCII tablosuna göre 16-bit yer kaplıyor default: 0 unicode ASCII U+0000(null)

////string aslında bir REFERANS TİP, ilkel/değer tip  metinsel ifadeye göre bellekteki yeri değişiyor
//string isim = "Ahmet"; //32-bit // 16 milyar bite kadar genişleyebiliyor, default:null
////tüm referans tiplerin defaultu nulldur. 
//int sayi2 = default; //0
//Console.WriteLine(sayi2);

//string? takmaAd = null; // bu değişkenin string ya da null olabileceğini söylüypr
//if (takmaAd != null)
//    Console.WriteLine(takmaAd.ToUpper());
//Console.WriteLine(takmaAd?.ToUpper()); // takmaAd eğer null ise toupper metotunu çalıştırmayacak, direkt null verecek

//Console.WriteLine(takmaAd ?? "takma ismi bulunmuyor"); //takmaad null ise sağdaki değeri bize verecek

//bool durum1 = true;
//bool durum2 = false;
//bool sonucDurum = durum1 && durum2; // false;
//bool sonucDurum2 = durum1 || durum2; //true

//int tamSayi = 10;
//double ondalikliSayi = tamSayi; // 10.0 Implisit (bilinçsiz) tür dönüşümü

//double ondalikliSayi2 = 10.5;
//// int tamSayi2 =ondalikliSayi2; // veri kaybı olacağı için implist şekilde dönüşüm yapmayacaktır.
//int tamSayi2 = (int)ondalikliSayi2; // casting (parantez içinde dönüştürme işlemi) Explist (bilinçli) tür dönüşümü
//Console.WriteLine(tamSayi2);

////Console.WriteLine(ondalikliSayi);

//long buyukTamSayi = long.MaxValue; //64-bit
//int normalTamSayi = (int)buyukTamSayi; // 64-bit -> 32-bit // Hata: -1 döndürür

////Daha güvenli tür dönüüşüm işlemleri için:
////int normalTamSayi2 = Convert.ToInt32(buyukTamSayi); // error: değer int'e göre çok büyük

//string metinselTamSayi=buyukTamSayi.ToString();
////double 2OndalikSayi //Invalid
//double ondalik_sayi = long.MaxValue; // Valid
//// double double =double.MaxValue; double bir keyword olduğu için değişken ismi olarak kullanamayız
//double @double = double.MaxValue;

//long cokBuyukTamSayi = long.MaxValue;
//Console.WriteLine(cokBuyukTamSayi+1);//sayımız ilgili veri tipinin MinValue değerine geri döner

#endregion // süslü parantez gibi o kısmı ayrı bir bölüm yapıyor. 
#region KosulluIfade

using ConsoleUI;
using System.Collections;
using System.Collections.Immutable;
using System.Text;

bool durum3 = false;
bool durum4 = true;

//if (durum3)
//    Console.WriteLine("Durum 3 geçerli"); // tek satırlık kod yazıldığında scope açmadan da yazılabilir
//if (durum3)
//{ //scope
//    Console.WriteLine("Durum 3 geçerli");
//} //scope
//else if (durum4)
//    Console.WriteLine("durum 4 geçerli");
//else
//{
//    Console.WriteLine("durumlar geçersiz");
//}

string komut = "delete";
//switch (komut)
//{
//    case "add":
//    case "update": // add ya da update ise ||
//        Console.WriteLine("ekleme işlemi tamamlandı");
//        break;
//    case "delete":
//        Console.WriteLine("silme işlemi tamamlandı");
//        break;
//    default:
//        Console.WriteLine("geçersiz işlem");
//        break;
//}
string mesaj; //default null
if (komut == "add" || komut == "update")
    mesaj = "Ekleme işlemi tamalandı";
else if (komut == "delete")
    mesaj = "Silme işlemi tamamlandı";

mesaj = komut == "add" ? "Ekleme işlemi tamamlandı"  // ternary operator
    : komut == "delete" ? "silme işlemi tamamlandı"
    : "geçersiz işlem";
mesaj = komut switch
{
    "add" => "ekleme işlemi tamamlandı",
    "delete" => "Silme işlemi tamamlandı",
    _ => "Geçersiz işlem"
};

#endregion

#region Donguler

//int sayi4 = 10;
//int sayi5 = sayi4++;
//int birArttir(int sayi)
//{
//    int temp = sayi;
//    sayi = sayi + 1;
//    return temp;
//}
//int onceBirArttir (int sayi)
//{
//    sayi= sayi + 1;
//    return sayi;
//}

for (int index = 0; //Döngünün en başında bir kere çalışan komutumuz
    index < 10;// Her döngünün başında kontrol ettiğimiz komut)
    ++index //index++ // index = index+1 // index+=2 // her döngünün sonunda çalışan atama komutumuz
    )
{
    if (index == 5)
        continue; // döngü 5deyken console yazdırmayacak, bir sonraki adıma geçecek

    if (index == 7)
        break; // direkt döngüden çıkacak
    //Console.WriteLine(index);
}
int index2 = 0;
while (index2 < 10)
{
    // if (index2 == 5) continue; //sonsuz döngü oluşturmuş oluyoruz.
    if (index2 == 5)
    {
        index2 += 1;
        continue;
    }

    if (index2 == 7) break;
    //Console.WriteLine(index2);

    index2 += 1;
}
//int index = 10;
//while(index<10)
//{
//    ++index;
//}

//while(true)//her döngünün başında kontrol ettiğimiz kısım 
//sonsuz döngülerden her daim kaçınmamız gerekiyor, çünkü pragram o noktada tıkanacaktır
//{
//    //istisne durumlarda sürekli kontrol için sonsuz döngüler oluşturulabilir. fakat programı aksatmayacak ayrı bir işlem parçacığına gerek olur
//}
//Console.WriteLine("program bitti");

do
{
    // döngünün ilk adımında herhangi bir koşula tabi olmadan ilgili işlemler yapılır
    // döngünün sonraki adımlarında
} while (false); // her döngünün sonunda kontrol ettiğimiz koşul

#endregion

#region Metot ve Fonksiyonlar

// [Döndürülen değerin veri tipi] [ METOTUN İSMİ ] ( [PARAMETRELER] )
void yazdir(string icerik)
{
    //int a = 0;
    //...
    //Console.WriteLine(icerik); //printer'a içeriği yazdıran fonksiyon olarak da düşünebiliriz
}
int Topla(int sayi1, int sayi2 = 0) // Fonksiyon, sayi2 opsiyonel parametre
{
    int toplamaSonuc = sayi1 + sayi2;
    //...
    //...
    //..
    return toplamaSonuc;
} // Modülerlik

//fonksiyonlarda overload yok, metotlarda yapılabilir

//parametre verme biçimleri
int sonuc = Topla(10, 20);
int sonuc2 = Topla(sayi2: 60, sayi1: 40); //Tekrar kullanılabilir //okunabilirlik
//Console.WriteLine(sonuc);

string yazdirmakIcinIcerik = sonuc.ToString();
yazdir(sonuc.ToString()); //parametre pozisyon bazlı parametre geçtik
yazdir(icerik: sonuc.ToString()); //parametre isim bazlı parametre geçtik

int hepsiniTopla(int baslangicSayisi, params int[] sayilar) //params bir çok parametre için, birden fazla sayılar var
                                                            //params sadece 1 tane ve en son olacak şekilde kullanabilriz
{
    int toplam = baslangicSayisi;
    foreach (int sayi in sayilar)
    {
        toplam += sayi;
    }
    return toplam;
}
int sonuc3 = hepsiniTopla(baslangicSayisi: 0, 40, 60, 90, 50, 20);
//Console.WriteLine("hepsinin toplamı : " + sonuc3);

/*namespace Printer //classlar bu main kod blogunun içinde kullanılamıyor. ayrı bir namespace lazım
{
/   class PrinterHelper //class:kapsam alanı
    {
        void yazdir(string icerik)//metot
        {
            Console.WriteLine(icerik);
        }
    }
}*/

//ref , out // temel/ilkel veri tipleri üzerinde kullanılır
//ref, fonksiyona kendi içinde değişken oluşturma, referans ettiğim değişkeni kullan demiş oluyoruz.
//out'un farkı, o değişkeni fonksiyon için tanımlamamız gerekiyor, zorunlu
void ikiyleCarpiminiDosyaOlarakKaydet(ref int sayi, out int sayi2)
{
    sayi *= 2;
    sayi2 = 1; // fonksiyon/metot içinde ilk atama işlemini verme zorunluluğu getirir. 

    // .. bu parametre değişkenini kullanarak başka işlemleri yaptığını varsayalım
    //Console.WriteLine($"ikiyleCarpiminiDosyaOlarakKaydet scope sayi: {sayi}");
    // $ işareti ile, string ifadenin içinde bir değişkeni kullandığımızı belirtiyoruz, onu oraya atıyor. + işelmi gibi yapmak için
}
int sayi = 2;
int sayiOut;
ikiyleCarpiminiDosyaOlarakKaydet(ref sayi, out sayiOut);
//Console.WriteLine("ana scope sayı: " + sayi + " sayiOut: " + sayiOut);
//ref ile değişkenleri aynı yapılıyor

MathHelper mathhelper = new MathHelper(); //referans tip
mathhelper.topla(1, 2);




#endregion

#region Diziler ve Koleksiyon
Console.WriteLine("-------------------- Diziler ve Koleksiyon ---------");
// Referans tip
string[] sira = new string[5]; //içinde eğer tiplerin tutulduğu referans tip
sira[0] = "özge";
sira[2] = "ayşe";
//Console.WriteLine($"sıra dizisindeki 0.indeksteki degeri : {sira[0]}");

//foreach (string siradakiKisininAdi in sira)
//{
//    Console.WriteLine(siradakiKisininAdi);
//}

//for (int index = 0; index < sira.Length; index++)
//{
//    string siradakiKisininAdi = sira[index];
//    Console.WriteLine($"sıra dizisindeki {index}.indeksteki degeri : {siradakiKisininAdi ?? "null"}");

//}

string[] sira2 = { "Özge", "Ayşe" };// new string[2] , verdiğimiz başlangıç değeri kadar array tutacaktır
string[] sira3 = new string[5] { "özge", "ayşe", "a", "b", "c" };

//string[] sira4 = new string[6];
//for(int index = 0;index < sira3.Length; index++)
//{
//    sira4[index] = sira3[index];
//}
Array.Resize(ref sira3, 6); // önceki dizinin elemanlarının kopyasını alıp, ekstra 1 tane daha yer açıyor, 6 elemeanlı oldu
sira3[5] = "hacer";

string[,] cokluSira = new string[2, 2]; // boyut arttırıldı, 0. indekste 2 tane yer var, 1. indekstede 2 tane yer var, matriks mantıığı
cokluSira[0, 0] = "Ahmet";
cokluSira[0, 1] = "Güven";
cokluSira[1, 0] = "özge";
cokluSira[1, 1] = "ayşe";
//foreach (string siradakiKisininAdi in cokluSira)
//{
//    Console.WriteLine(siradakiKisininAdi);
//}

// string[ , , ] cokluSira=new string[2,2,2]; //3 boyutlu

//Array.Sort(cokluSira); //sırala
//Array.Fill(sira, "boş"); //sabit yaptı
//bool ahmetVarMi = sira.Contains("Ahmet"); //ahmet değeri varsa true dön
//string siraString=string.Join(", ",sira);
//Console.WriteLine(siraString);

string sentence = "örnek bir cümle";
//splip metotu ile boşluklardan kesim 3 elemanlı array yaptı
string.Join(" ", sentence.Split(' ').Select(word => word.Length >= 5 ? new string(word.Reverse().ToArray()) : word)); //kelimenin uzunluğu, 5ten büyükse ters çevirip array haline getir, 5den küçükse aynı şekilde tut

// string.Join(" ", sentence.Split(' ').Select(word => word.Length >= 5 ? word.Reverse() : word)); //bu şekilde de olur

//KOLEKSİYONLAR
//class oluştu,üzerinde çalışacağımız veri tipi stringtir diyoruz
Console.WriteLine("------KOLEKSİYONLARR-----");
//Koleksiyon Sınıfı<degiskentipi> isim= new Koleksiyon Sınıfı<degıskentipi>();

//List
List<string> sira4 = new List<string>();
//istediğimiz kadar veri ekleyebiliriz, sınır yok 
sira4.Add("Ahmet");
sira4.Add("Özge");
sira4.Add("Burak");
sira4.Remove("Burak");//sildi
sira4[0] = "Furkan"; // eleman ekledikten sonra atayabiliyoruz
//foreach (string siradakiIsim in sira4)
//{
//    Console.WriteLine(siradakiIsim);
//}

//Dictionary
//Anahtar ve değer eşleşmesiyle bir sözlük yapısı oluşturulur
//Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
Dictionary<string, string> sira5 = new();

sira5.Add(key: "Birinci Sıra", value: "Ahmet");
//Console.WriteLine(sira5["Birinci Sıra"]);
//foreach (KeyValuePair<string, string> siradaki in sira5)
//{
//    Console.WriteLine($"{siradaki.Key},{siradaki.Value}");
//}
//ArrayList
//sabit bir veri tipi yok, istediğimizi verebiliriz, uzunluk da belli değil
ArrayList sira6 = new();

sira6.Add("Özge");
sira6.Add(null);
sira6.Add(15);
sira6.Add(true);

//LinkedList
LinkedList<string> sira7 = new();
sira7.AddFirst("Ahmet");
//var sira7IlkKisi = sira7.First.Next.Value;

//HashSet
//ekleyeceğim her veri birbirinden farklıdır,benzersizdir
HashSet<string> katilimcilar = new();

katilimcilar.Add("ozge@gmail.com");
katilimcilar.Add("ahmet@gmail.com");

#endregion

#region Classlar
//referense type
//C# Nesneye Dayalı (OOP) Programlama Dili
//classlar nesneler oluşturmak için bir şablondur diyebiliriz
//Student ogrenci = new Student(); //nesne // referans
//ogrenci.FirstName = "Özge";
//ogrenci.LastName = "Kestane";
//Console.WriteLine(ogrenci.FullName);

//Student ogrenci1 = new()
//{
//    FirstName = "Muhammet",
//    LastName = "Mutlo",
//    Yas = 25
//};
//Console.WriteLine($"{ ogrenci1.FirstName}-{ ogrenci1.LastName}");

//Student ogrenci2 = ogrenci1;
//ogrenci1.LastName = "Mutlu";
//Console.WriteLine($"{ogrenci1.FirstName}-{ogrenci1.LastName}-{ogrenci1.Yas}");
//Console.WriteLine($"{ogrenci2.FirstName}-{ogrenci2.LastName}-{ogrenci2.Yas}");


#endregion

#region Değer ve Referans Veri Tipleri

// Değer Veri Tipleri 
//değişkenler: veriyi geçici olarak RAM da tutabildiğimiz değerlerdir
int number1 = 10; //10 // 30
int number2 = 20; //10 //10

number2 = number1; // number2: 20 ->10
number1 = 30; //number1: 10-> 30
Console.WriteLine(number2); //10

//Referans Veri Tipleri //array
string[] cities1 = // 0x3271 (Hexidecimal 16'lık sayı sistemindeki sayı
    new string[2] { "Konya", "İstanbul" }; //veri Heapdeki ayrılan yere yerleştirilir, örneğin 0x3271
string[] cities2 = //0x5721
    new string[2] { "Ankara", "İzmir" };

Console.WriteLine(cities1.ToString()); // hangi veri tipinde döndüğünü gösteriyor
cities2 = cities1;


//cities1.CopyTo(cities2,0); //0. indeksteki veriyi cities2'ye kopyalar
//for (int i = 0; i < cities1.Length; i++)
// cities2[i] = cities1[i]; ==> 417. satırı yoruma alıp bunu yazınca, cevap konya çıkıyor. burada bellek adresleri değişmeden sadece veri kopyalaması yapıldığı için
// cities1.CopyTo(cities2,i);

cities1[0] = "Antalya";

Console.WriteLine(cities2[0]); //Antalya
//Console.WriteLine(ogrenci);

const int number3 = 10; // const sabit değere sahip değişken, tekrar atama yapamayız
//Immutable
ImmutableArray<string> cities3 = cities1.ToImmutableArray(); //referans tiptekiler için, değiştirilmez
//cities3[0] = "Konya"; olmuyor

//string veri tipi

string city1 = "Konya"; //0x4242
string city2 = "Ankara"; //0x0606
city2 = city1; //0x0606 -> 0x4242
#region Temsili Arka Plan

//Temsili Arka Plan
//ImmutableArray<char>SetString(ImmutableArray<char>city1Array())
//ImmutableArray<char> city1ArrayToAntalya = ImmutableArray.Create('a', 'n', 't', 'a', 'l', 'y', 'a'); //char[7]
//Array.Resize(ref city1Array, 7);
//for (int i = 0; i < city1Array.Length; i++)
//{
//    city1Array[i] = city1ArrayToAntalya[i];
//city1Array = city1ArrayToAntalya;

//}
#endregion
city1 = "Antalya"; //0x4242 -> 0x0707
city1 += "Güzeldir"; //0x0707 -> 0x0807 // boyutu büyüdüğü için

Console.WriteLine(city2);//Konya

//StringBuilder
StringBuilder stringBuilder = new StringBuilder(); //0x9284 // Allocation //daha performanslı
stringBuilder.Append("Antalya"); //0x9284
stringBuilder.Append("Güzeldir"); //0x9284 No Allocation

Console.WriteLine(stringBuilder.ToString()); // 0x7292 //Allocation // Stringe çevirdiği için yeni bir adres oluşturuyor



#endregion

#region Nesneye Yönelimli Programlama (OOP) 
/*
 * Sınıflar ve Nesneler: Yazılım, gerçek dünyadaki ve iş sürecindeki nesnelerin özelliklerinin tanımı ve davranışlarını içeren sınıflardır, ve sınıflarla üretilen nesnelerle oluşur 
 * 
 * Kapsülleme (Encapsulation):Veriyi, davranışları,özellikleri (property) arada tutmak ve bunlara olan dışarıdan erişimini kontrol etmemiz
 * 
 * Kalıtım (Inheritance); Sınıflar arasında bir "parent-child" ilişkisi kurulması ve aynı zamanda "is a" ilişkisi kurulması, bir sınıfın özellikleri ve davranışları diğer sınıfa miras olarak geçirebilmesi. Böylece yazılımın bazı parçaları tekrar kullanılabikir. 
 * yazdığımız her classın içinde default olarak Object kalıtımı geliyor. 
 * class Ogrenci: Object
 * 
 * Çok Biçimlilik (Polymorphism): Aynı isimdeki davranışların farklı sınıflarda farklı şekillerde davranabilmesini sağlar. Bu da yazılımın esnekliğini arttırır. Base Classlar, child classların referansını tutabiliyorlar
 * 
 * Soyutlama (Abstraction): KArmaşık sistemleri basitleştirmek için ortak özellikleri belirleyerek soyutlama yapılır. 
 * Fakat soyutlamalar üzerinden somut bir veri oluşturulmaz.
 * Ogrenci is a human
 */

int lastId = 0;

User user = new User(/*id: ++lastId,*/ firstName: "Hacer Sema", lastName: "Aktaş", nickName: "Hacer.Aktas", email: "hacer@exp.com", password: "123456");
User user1 = new User(firstName: "Hacer Sema", lastName: "Aktaş", nickName: "Hacer.Aktas", email: "hacer@exp.com", password: "123456");


Console.WriteLine(user.Id);
Console.WriteLine(user1.Id);

// user.CreatedAt= DateTime.Now; //set'i kaldırdığımız için bu kodda kızıyor
Console.WriteLine("-----------");
Student student = new(id: ++lastId, firstName: "Özge", lastName: "Kestane", nickName: "ozgkestane", email: "ozge@exp.com", password: "1234", phoneNumber: "123456", yas: 25);
Entity student1 = new Student(id: ++lastId, firstName: "Özge", lastName: "Kestane", nickName: "ozgkestane", email: "ozge@exp.com", password: "1234", phoneNumber: "123456", yas: 25);

Console.WriteLine(student);
Console.WriteLine(((Student)student1).PhoneNumber); //entitty olarak oluşturduğumuzda phone numberı görmüyordu, şuan bunu bir student olarak gör dedik
student1.UpdatedAt = DateTime.Now;
Console.WriteLine($"Student: {((Student)student1).PhoneNumber}");

Console.WriteLine("-----------");


Instructor instructor = new
    (id: ++lastId,
    firstName: "Ahmet",
    lastName: "Çetinkaya",
    nickName: "a.cetinkaya",
    email: "ahmet@exp.com",
    password: "123456",
    field: "software"
    );
//get'i kaldırınca erişilmiyor
//Console.WriteLine(instructor.Password);

instructor.Password = "654321";
//Console.WriteLine(instructor.Password);

//EntityRepository entityRepository = new EntityRepository();
//entityRepository.UpdateEntity(user);
//entityRepository.UpdateEntity(student);
//entityRepository.UpdateEntity(instructor);

IUserDal userDal = new SqlDbUserDal(); //new InMemoryUserDal();
// Dependency Injection // IoC


userDal.Add(user);

#endregion

//Configuration.cs
//IBrandDal brandDal = new InMemoryBrandDal();
//BrandBusinessRules brandBusinessRules = new BrandBusinessRules(brandDal);
//IBrandService brandService = new BrandManager(brandDal, brandBusinessRules);
////Configuration.cs



//// >RentACar add brand BMW

//Brand brandToAdd = new Brand { Name = "BMW" };
//brandService.Add(brandToAdd);