namespace Application.Interfaces
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        IProductFeatureGroupRepository ProductFeatureGroup { get; }
        IProductFeatureRepository ProductFeature { get; }

    }
}