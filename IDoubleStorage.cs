namespace CalculatorRPN
{
    internal interface IDoubleStorage
    {
        public void Push(double value);
        public double Pop();
        public void Clear();
        public int Count();
    }
}
