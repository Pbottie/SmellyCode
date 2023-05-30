using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorRPN
{
    internal class CalculatorController
    {
        IUI ui;
        IDoubleStorage stack;

        public CalculatorController(IUI ui, IDoubleStorage stack)
        {
            this.ui = ui;
            this.stack = stack;
        }


        public void Run()
        {
            while (true)
            {
                if (stack.Count() == 0)
                    ui.Print("Commands: q c + - * / number");
                ui.Print(stack.ToString());

                string input = ui.GetInput();
                if (ValidateInput(input))
                {
                    if (input == "q")
                        ui.Exit();

                    if (input == "c")
                    {
                        stack.Clear();
                        continue;
                    }

                    if (Char.IsDigit(input[0]))
                    {
                        double number = Convert.ToDouble(input);
                        stack.Push(number);
                    }
                    else
                    {
                        if (stack.Count() <= 1)
                            ui.Print("Need more numbers in stack");
                        else
                            Calculate(input);
                    }

                }
                else
                {
                    ui.Print("Illegal command, ignored");
                    continue;
                }

            }

        }

        private bool ValidateInput(string input)
        {
            //match number, q, c, or +-/*
            string pattern = @"^\d+$|^q$|^c$|^\+$|^\-$|^\/$|^\*$";
            Regex regex = new Regex(pattern);
            bool result = regex.IsMatch(input);

            return result;
        }

        private void Calculate(string command)
        {
            if (command == "+")
            {
                stack.Push(stack.Pop() + stack.Pop());
            }
            else if (command == "*")
            {
                stack.Push(stack.Pop() * stack.Pop());
            }
            else if (command == "-")
            {
                double d = stack.Pop();
                stack.Push(stack.Pop() - d);
            }
            else if (command == "/")
            {
                double d = stack.Pop();
                stack.Push(stack.Pop() / d);
            }
        }



    }
}
