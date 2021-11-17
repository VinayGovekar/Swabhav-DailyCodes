

using FactoryMethodLib.Product;

namespace FactoryMethodLib.Factory
{
    public class AudiFactory : IAutoFactory
    {
        private static AudiFactory _audiFactory;
        private AudiFactory() { }
        public IAuto Make()
        {
            return new Audi();
        }

        public static AudiFactory GetInstance()
        {
            if (_audiFactory == null) _audiFactory=  new AudiFactory();
            return _audiFactory;
        }
    }
}
