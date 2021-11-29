using System;


namespace CalculatorEventLib
{
    public class Calculator
    {
        public event Action<string,int,int,double> OperationCompleted = null;
       // public event Action<string,int,int,double> OnSubtractOperationCompleted = null;

        public void Add(int first, int second)
        {
            double sum = first + second;
            if (OperationCompleted != null) OperationCompleted("Addition",first,second,sum);
        }

        public void Substrct(int first,int second)
        {
            double diff = first - second;
            if (OperationCompleted != null) OperationCompleted("Substraction",first,second,diff);
        }
    }
}
