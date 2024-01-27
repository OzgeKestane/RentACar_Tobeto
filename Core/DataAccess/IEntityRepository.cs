namespace Core.DataAccess
{
    public interface IEntityRepository<TEntity, TEntityId> //Repository Design Pattern
    {
        //delegate: geri dönüşü olmayan fonk, parametreleri var.
        //CRUD- Create, Read, Update, Delete
        //func aldığım parametlerin ne olduğunu ne ile geri döneceğini söylüyor
        //verilmeyedebilir, varsayılan değeri null olarak atandı.
        public IList<TEntity> GetList(Func<TEntity, bool>? predicate = null);
        //Func fonksiyonları tutabileceğiniz bir type'dır.
        //Jenerik yapısında  en son type argümanı fonksiyonun dönüş tipidir.
        //ondan önce gelen type argümanları da fonksiyonun sırasıyla parametre tipleridir.

        //Func<TEntity,bool>predicateFunc=(Tentity entity)=> {return entity.Name=="";};
        //bool predicate(TEntity entity) 
        //{
        //    bool result = entity.Name == "";
        //    return result;
        //}
        //Func<TEntity, bool> predicateFunc =predicate;
        public TEntity? Get(Func<TEntity, bool> predicate);
        public TEntity Add(TEntity entity);
        public TEntity Update(TEntity entity);

        public TEntity Delete(TEntity entity, bool isSoftDelete = true);
    }
}
