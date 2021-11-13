using System;
using DIPSolutionApp.CommonModule;

namespace DIPSolutionApp.HighLevelModule
{
    public class TaxCalculator
    {
        private ILogger _policy;
        public TaxCalculator(ILogger policy)
        {
            _policy = policy;
        }
        public int Calculate(int value1, int value2)
        {
            try
            {
                int result = value1 / value2;
                return result;
            }
            catch (Exception ex)
            {
                _policy.Log(ex.Message);
                return 0;
            }
        }
    }
}
