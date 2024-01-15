namespace ConsoleUI
{
    class MathHelper

    {
        //metotların varsayılan erişim belirteci (access modifer): private
        //dışarıdan ulaşmak için private yerine internal yazılabilir
        internal int topla(int sayi1, int sayi2) //metot
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        //method overloading
        internal string topla(string sayi1, string sayi2) //metot ismi + parametrelerin veri tip sırası --> metotun imzası
        {
            int toplam = Convert.ToInt32(sayi1) + int.Parse(sayi2);
            // return toplam.ToString();
            return sayiyiStringeCevir(toplam);
        }
        // private ile sadece bu classda kullanılrı
        private string sayiyiStringeCevir(int sayi)
        {
            return sayi.ToString();
        }
    }
}
