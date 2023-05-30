namespace CalculatorRPN
{
    internal class DoubleStack : IDoubleStorage
    {
        Stack<double> stack;

        public DoubleStack()
        {
            stack = new Stack<double>();
        }

        public void Clear()
        {
            stack.Clear();
        }

        public double Pop()
        {
            return stack.Pop();
        }

        public void Push(double value)
        {
            stack.Push(value);
        }

        public int Count()
        {
            return stack.Count;
        }

        public override string ToString()
        {
            if (stack.Count == 0)
            {
                return "[]";
            }

            string output = "[";

            foreach (var item in stack)
            {
                output += item.ToString() + ",";
            }

            output = output.Substring(0, output.Length - 1);
            output += "]";
            return output;
        }
    }
}
