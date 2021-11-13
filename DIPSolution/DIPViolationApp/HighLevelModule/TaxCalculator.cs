using System;
using DIPViolationApp.LowLevelModule;

namespace DIPViolationApp.HighLevelModule
{
    public class TaxCalculator
    {
        private LogPolicyType _policy;
        public TaxCalculator(LogPolicyType policy)
        {
            _policy = policy;
        }
        public int Calculate(int value1,int value2)
        {
            try
            {
                int result = value1 / value2;
                return result;
            }
            catch(Exception ex)
            {
                if (_policy == LogPolicyType.DB) new DBLogger().WriteLine(ex.Message);
                else if (_policy == LogPolicyType.FILE) new FileLogger().WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
