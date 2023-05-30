namespace CalculatorRPN
{
    internal interface IUI
    {
        public string GetInput();
        public void Print(string output);
        public void Exit();
    }
}
