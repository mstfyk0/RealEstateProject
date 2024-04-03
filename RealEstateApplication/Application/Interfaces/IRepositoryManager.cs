namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }

        IProductFeatureGroupRepository ProductFeatureGroup { get; }
    }
}