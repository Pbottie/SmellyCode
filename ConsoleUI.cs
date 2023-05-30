namespace CalculatorRPN
{
    internal class ConsoleUI : IUI
    {
        public void Exit()
        {
            System.Environment.Exit(0);
        }

        public string GetInput()
        {
            return Console.ReadLine().Trim();
        }

        public void Print(string output)
        {
            Console.WriteLine(output);
        }
    }
}
