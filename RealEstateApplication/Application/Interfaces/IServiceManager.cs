namespace Application.Interfaces
{
    public interface IServiceManager
    {
        IProductService ProductService { get; }
        IProductFeatureGroupServices ProductFeatureGroupServices { get; }
        IProductFeatureServices ProductFeatureServices { get; }

    }
}