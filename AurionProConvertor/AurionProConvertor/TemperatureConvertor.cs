
namespace AurionProConvertor
{
    public static class TemperatureConvertor
    {
        public static double CelciusToFahrenheit(double celcius)
        {
            return celcius * 9 / 5 + 32;
        }
        public static double CelciusToKelvin(double celcius)
        {
            return celcius + 273.15;
        }
        public static double FahrenheitToCelcius(double fahrenheit)
        {
            return fahrenheit - 32 * 5 / 9;
        }
        public static double KelvinToCelcius(double kelvin)
        {
            return kelvin - 273.15;
        }
        public static double FahrenheitToKelvin(double fahrenheit)
        {
            return CelciusToKelvin(FahrenheitToCelcius(fahrenheit));
        }

        public static double KelvinToFahrenheit(double kelvin)
        {
            return CelciusToFahrenheit(KelvinToCelcius(kelvin));
        }
    }
}
