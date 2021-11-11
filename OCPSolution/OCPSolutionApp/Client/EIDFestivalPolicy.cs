using OCPSolutionApp.Lib;

namespace OCPSolutionApp.Client
{
    public class EIDFestivalPolicy : IFestivalPolicy
    {
        public double CalculateRate()
        {
            return 0.085;
        }
    }
}
