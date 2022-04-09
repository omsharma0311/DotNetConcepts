using System;

namespace CalculatorDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (; ; ) 
            {
                int firstNum = 0;
                int secondNum = 0;
                string _val = "";
                string _val2 = "";
                ConsoleKeyInfo key;

                Console.WriteLine("Enter first number");
                do
                {
                    key = Console.ReadKey(true);
                        int val = 0;
                        bool _x = Int32.TryParse(key.KeyChar.ToString(), out val);
                        if (_x)
                        {
                            _val += key.KeyChar;
                            Console.Write(key.KeyChar);
                        }
                }
                while (key.Key != ConsoleKey.Enter);
                firstNum = Convert.ToInt32(_val);

                Console.WriteLine("\nEnter Second number");
                do
                {
                    key = Console.ReadKey(true);
                    int val2 = 0;
                        bool _x = Int32.TryParse(key.KeyChar.ToString(), out val2);
                        if (_x)
                        {
                            _val2 += key.KeyChar;
                            Console.Write(key.KeyChar);
                        }
                }
                while (key.Key != ConsoleKey.Enter);

                secondNum = Convert.ToInt32(_val2);

                Console.WriteLine("\nEnter Operator");
                char operation = Convert.ToChar(Console.ReadLine());

                int result = 0;
                switch (operation)
                {
                    case '+': result = firstNum + secondNum; break;
                    case '-': result = firstNum - secondNum; break;
                    case '*': result = firstNum * secondNum; break;
                    case '/': result = firstNum / secondNum; break;
                    case '%': result = firstNum % secondNum; break;
                }
                Console.WriteLine("{0} and {1} with Operator {2} result in {3}", firstNum, secondNum, operation, result);
            }
        }
    }
}
