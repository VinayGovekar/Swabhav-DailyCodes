using SimpleFactoryLib.Product;
namespace SimpleFactoryLib.Factory
{
    public class AutomobileFactory
    {
        private static AutomobileFactory _automobileFactory;
        private AutomobileFactory() { }
        public IAuto Make(AutoType auto)
        {
            if (auto == AutoType.TESLA) return new Tesla();
            else if (auto == AutoType.BWM) return new BMW();
            return new Audi();
        }
        public static AutomobileFactory GetInstance()
        {
            if (_automobileFactory == null) _automobileFactory = new AutomobileFactory();
            return _automobileFactory;
        }
    }
}
