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

        static void PrintStack(Stack<double> stack)
        {
            string output = "[";
            foreach (var item in stack)
            {
                output += item.ToString() + ",";
            }
            output = output.Substring(0, output.Length - 1);
            output += "]";
            Console.WriteLine(output);

        }


        static void Calculate(Stack<double> stack, char command)
        {
            if (command == '+')
            {
                stack.Push(stack.Pop() + stack.Pop());
            }
            else if (command == '*')
            {
                stack.Push(stack.Pop() * stack.Pop());
            }
            else if (command == '-')
            {
                double d = stack.Pop();
                stack.Push(stack.Pop() - d);
            }
            else if (command == '/')
            {
                double d = stack.Pop();
                stack.Push(stack.Pop() / d);
            }
        }
    }
        
}
