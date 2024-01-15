namespace ConsoleUI
{
    internal class User /*Somut(Concrete Sınıf)*/: Entity //Tekli miras
    { // başka projede kullanmayacaığımız için internal yaptık şuan
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string NickName { get; set; }
        internal string Email { get; set; }
        private string _password;
        internal string Password
        {
            //get { return _password; }
            set
            {
                _password = hashPassword(value);
            }
        }
        internal User(string firstName, string lastName, string nickName, string email, string password) : base()//kurucu metot //Constructor, otomatik oluşuyor
        {
            FirstName = firstName;
            LastName = lastName;
            NickName = nickName;
            Password = password;
            Email = email;
            //CreatedAt= DateTime.Now; // yapamıyoruz, kendi constructarında sadece değiştirilebilir, hata veriyo şuan
            Console.WriteLine("Bir User oluştu");
        }

        internal User(int id, string firstName, string lastName, string nickName, string email, string password) : base(id)//kurucu metot //Constructor, otomatik oluşuyor
        {
            FirstName = firstName;
            LastName = lastName;
            NickName = nickName;
            Password = password;
            Email = email;
            //CreatedAt= DateTime.Now; // yapamıyoruz, kendi constructarında sadece değiştirilebilir, hata veriyo şuan
            Console.WriteLine("Bir User oluştu");
        }
        private string hashPassword(string passwordToHash)
        {

            return passwordToHash + "HASH123@!#";
        }

        //abstract yaptığımızda da burada override yapmamız gerekiyor
        protected override int generateId()
        {
            //int incrementIdExample=base.generateId(); //base classıda kullanabiliriz
            return Convert.ToInt32(DateTime.UtcNow.Nanosecond);//Temsili kod örneğidirş. Tüm oluşturulacak id verisinin benzersiz olması gerekir
        }
    }
}
