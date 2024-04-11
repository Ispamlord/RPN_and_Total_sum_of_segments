using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class task2
    {

        static int GetPriority(char c)
        {
            switch (c)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }

        public static string ConvertToReversePolishNotation(string expression)
        {
            Stack<char> stack = new Stack<char>();
            string result = "";

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];

                // Если символ - операнд, добавляем его к результату
                if (char.IsLetterOrDigit(c))
                {
                    result += c;
                }
                // Если символ - открывающая скобка, помещаем её в стек
                else if (c == '(')
                {
                    stack.Push(c);
                }
                // Если символ - закрывающая скобка, выталкиваем все элементы из стека до открывающей скобки
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result += stack.Pop();
                    }
                    stack.Pop(); // Удаляем открывающую скобку из стека
                }
                // Если символ - оператор
                else
                {
                    
                    while (stack.Count > 0 && GetPriority(c) <= GetPriority(stack.Peek()))
                    {
                        result += stack.Pop();
                    }
                    stack.Push(c);
                }
            }

            // Добавляем все оставшиеся операторы из стека в результат
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }

            return result;
        }

    }
}

