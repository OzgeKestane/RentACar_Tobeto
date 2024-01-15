namespace ConsoleUI
{
    internal interface IUserDal //Soyut //Data Access Layer
                                //tamamıyla soyut, amacı arayüz sağlamak
    {
        //public int MyProperty { get; set; } bu interfacei kullandığımız classta tekrar tanıtmamız gerekiyor
        public void GetById(int id); //Abstract
        public void Add(User user); //Abstract
        public void Update(User user); //Abstract
        public void Delete(User user); //Abstract


    }
}
