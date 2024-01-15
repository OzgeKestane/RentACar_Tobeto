namespace ConsoleUI
{
    internal class InMemoryUserDal : IUserDal
    { //interfacedeki alanların public olması gerekiyor
        public void Add(User user)
        {
            Console.WriteLine("Belleğe veri yazıldı");
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
