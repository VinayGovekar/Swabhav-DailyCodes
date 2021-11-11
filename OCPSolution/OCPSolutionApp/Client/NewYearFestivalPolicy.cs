using OCPSolutionApp.Lib;
namespace OCPSolutionApp.Client
{
    public class NewYearFestivalPolicy : IFestivalPolicy
    {
        public double CalculateRate()
        {
            return 0.09;
        }
    }
}
