using OCPSolutionApp.Lib;
namespace OCPSolutionApp.Client
{
    public class DiwaliFestivalPolicy : IFestivalPolicy
    {
        public double CalculateRate()
        {
            return 0.08;
        }
    }
}
