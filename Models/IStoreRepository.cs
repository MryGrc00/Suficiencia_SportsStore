namespace Suficiencia_SportsStore.Models
{

    //Queryable
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
