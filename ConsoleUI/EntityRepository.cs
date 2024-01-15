using Newtonsoft.Json;

namespace ConsoleUI
{
    internal class EntityRepository
    {
        internal void UpdateEntity(Entity entity)
        {
            entity.UpdatedAt = DateTime.UtcNow;
            Console.WriteLine(JsonConvert.SerializeObject(entity));
        }
    }
}
