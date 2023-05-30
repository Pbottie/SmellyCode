using System.Text;

namespace CalculatorRPN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUI ui;
            IDoubleStorage stack;

            ui = new ConsoleUI();
            stack = new DoubleStack();

            CalculatorController calculator = new CalculatorController(ui, stack);

            calculator.Run();

        }
    }
}
        
}
