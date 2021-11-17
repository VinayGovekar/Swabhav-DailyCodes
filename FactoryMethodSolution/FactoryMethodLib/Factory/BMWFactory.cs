

using FactoryMethodLib.Product;

namespace FactoryMethodLib.Factory
{
    public class BMWFactory : IAutoFactory
    {
        private static BMWFactory _bmwFactory;
        private BMWFactory() { }
        public IAuto Make()
        {
            return new BMW();
        }
        public static IAutoFactory GetInstance()
        {
            if (_bmwFactory == null) _bmwFactory = new BMWFactory();
            return _bmwFactory;
        }
    }
}
