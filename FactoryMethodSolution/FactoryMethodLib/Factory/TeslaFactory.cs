

using FactoryMethodLib.Product;

namespace FactoryMethodLib.Factory
{
    public class TeslaFactory : IAutoFactory
    {
        private TeslaFactory() { }
        private static TeslaFactory _teslaFactory;
        public IAuto Make()
        {
            return new Tesla();
        }
        public static IAutoFactory GetInstance()
        {
            if (_teslaFactory == null) _teslaFactory = new TeslaFactory();
            return _teslaFactory;
        } 
    }
}
