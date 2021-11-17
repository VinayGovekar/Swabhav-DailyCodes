using FactoryMethodLib.Product;
namespace FactoryMethodLib.Factory
{
    public interface IAutoFactory
    {
        IAuto Make();   
    }
}
