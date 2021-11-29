using System;


namespace CalculatorEventLib
{
    public class Calculator
    {
        public event Action<string,int,int,double> OnAddOperationCompleted = null;
        public event Action<string,int,int,double> OnSubtractOperationCompleted = null;

        public void Add(int first, int second)
        {
            double sum = first + second;
            if (OnAddOperationCompleted != null) OnAddOperationCompleted("Addition",first,second,sum);
        }

        public void Substrct(int first,int second)
        {
            double diff = first - second;
            if (OnSubtractOperationCompleted != null) OnSubtractOperationCompleted("Substraction",first,second,diff);
        }
    }
}
