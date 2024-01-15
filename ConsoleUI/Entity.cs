namespace ConsoleUI
{
    internal abstract class Entity //soyutladık abstract ile, // buradan nesne üretemeyiz program csde, newleyemeyiz
    {
        internal int Id { get; set; }
        internal DateTime CreatedAt { get; } //Read-Only Property
        //set yazmadık güvenliği arttırdık, dışardan tekrar değiştirilemez anlamında
        internal DateTime? UpdatedAt { get; set; } //null olabilir

        // internal readonly string CreatedAt; //ReadOnly Field
        public Entity()
        {
            Id = generateId(); //ben id vermezsem kendisi bu noktada oluşturacak
            CreatedAt = DateTime.UtcNow; //Read-only özellikleri kurucu metotlarda ilk değeri verebiliyoruz fakat dışarıda veremiyoruz
            //Zaman dilimsiz, (ist. saati gibi standart etmeden, kullanıcı ne zaman açarsa kendi zamanında
            Console.WriteLine("Bir Entity() oluştu");

        }

        public Entity(int id)//:this() 
        {
            Id = id;
            Console.WriteLine("Bir Entity (id)oluştu");
        }
        //protected: private gibi bu program cs dışında ulaşılamayacak fakar, diğer childlarda kullanılabilir, ulaşılabilir.
        //virtual: bu metottu burada yazdık fakar, başka child classlar bunu override yapıp yeniden yazabilir.
        protected virtual int generateId()
        {
            return ++EntityIdHelper.LastId;
        } //isteğe bağlı olarak Entity'i kalırım alan sınıflarda isteğe bağlı olarak override edilebilir


        //protected abstract int generateId(); // abstract olduğu için içinde tanımlama yapamayız
        // Entity'i kalıtım alan Somut classlarda override edilmesi gerekiyor.

    }
}
//static olması: newlemeye gerek yok, bu hep çalışacak, entityıdhelper hep ulaşılabilir ama 1 tane olacak, 1 adet referans

internal static class EntityIdHelper
{
    public static int LastId { get; set; } = 0;
}
