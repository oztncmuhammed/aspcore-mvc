namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product{get ; set;}
        void Save();
    }
}