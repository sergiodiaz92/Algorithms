using System;
using System.Collections.Generic;

namespace ReversePolishNotation
{
    class Program
    {
        public static int ReversePolishNotation(string[] tokens){
            string operators = "+-*/";
            Stack<int> operands = new Stack<int>();
            int x,y;
            foreach (var item in tokens)
            {
                if(!operators.Contains(item)){
                    operands.Push(int.Parse(item));
                }
                else
                {
                    switch (item)
                    {
                        case "+":
                            y = operands.Pop();
                            x = operands.Pop();
                            operands.Push(x+y);
                        break;
                        case "-":
                            y = operands.Pop();
                            x = operands.Pop();
                            operands.Push(x-y);
                        break;
                        case "*":
                            y = operands.Pop();
                            x = operands.Pop();
                            operands.Push(x*y);
                        break;
                        case "/":
                            y = operands.Pop();
                            x = operands.Pop();
                            operands.Push(x/y);
                        break;
                    }    
                }
            }
            return operands.Pop();
        }
        public static void PrintArray(string[] myArray){
            string msgStr = "";
            for (int i = 0; i < myArray.Length; i++)
            {
                msgStr += myArray[i] + ",";
            }
            msgStr = msgStr.Remove(msgStr.Length -1,1);
            Console.WriteLine(String.Format("[{0}]",msgStr));
        }
        static void Main(string[] args)
        {
            string[] myTokens = {"2", "1", "+", "3", "*"};
            PrintArray(myTokens);
            int result = ReversePolishNotation(myTokens);
            Console.WriteLine(String.Format("Result: {0}", result.ToString()));
            string[] myTokens2 = {"4", "13", "5", "/", "+"};
            PrintArray(myTokens2);
            int result2 = ReversePolishNotation(myTokens2);
            Console.WriteLine(String.Format("Result: {0}", result2.ToString()));
        }
    }
}
