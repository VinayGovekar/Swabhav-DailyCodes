using OCPSolutionApp.Lib;

namespace OCPSolutionApp.Client
{
    public class NormalFestivalPolicy : IFestivalPolicy
    {
        public double CalculateRate()
        {
            return 0.07;
        }
    }
}
