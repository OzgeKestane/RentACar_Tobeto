namespace ConsoleUI;
//class default access modifier ( erişim belirteci): internal
class Student : User // Çok düzeyli miras //: Object
{
    //default access modifier:private, sadece bu class içerisinde erişilebilir
    //internal string FirstName { get; set; } //Property
    //internal string LastName { get; set; } //Property

    internal string PhoneNumber { get; set; }
    private int _yas; //Field
    internal int Yas //getter - setter , kapsülleme
    {
        get
        {
            return _yas;
        }
        set
        {
            if (value < 0)
                return;
            _yas = value;
        }
    }//Property

    //internal int getYas() { return _yas; }
    //internal void setYas(int value)
    //{
    //    if (value < 0)
    //        return; 
    //    _yas = value;
    //}
    internal string FullName
    {
        get
        { return $"{FirstName} {LastName}"; }
    }
    //internal string GetFullName()
    //{
    //return $"{FirstName} {LastName}";
    //}

    internal Student(int id, string firstName, string lastName, string nickName, string email, string password, string phoneNumber, int yas) : base(id, firstName, lastName, nickName, email, password)
    {
        PhoneNumber = phoneNumber;
        // _yas = yas;
        Yas = yas;
        Console.WriteLine("Bir student oluştu");
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
