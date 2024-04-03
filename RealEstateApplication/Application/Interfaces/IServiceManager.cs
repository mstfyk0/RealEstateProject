namespace Services.Contracts
{
    public interface IServiceManager
    {
        IProductService ProductService { get; }
        IProductFeatureGroupServices ProductFeatureGroupServices { get; }
        
    }
}