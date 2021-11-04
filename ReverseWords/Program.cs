using System;

namespace ReverseWords
{
    class Program
    {
        public static string ReverseWords(string myString){
            string ret = "";
            string[] stringSplit = myString.Split(" ");

            for (int i = 0; i < stringSplit.Length/2; i++)
            {
                string temp = stringSplit[i];
                stringSplit[i]=stringSplit[stringSplit.Length - 1 - i];
                stringSplit[stringSplit.Length - 1 - i] = temp;
            }
            for (int i = 0; i < stringSplit.Length; i++)
            {
                ret += stringSplit[i] + " ";
            }
            ret = ret.Remove(ret.Length -1,1);
            return ret;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Original String");
            Console.WriteLine("Azure DevOps can help you achieve faster time to market");
            Console.WriteLine();
            Console.WriteLine("Reverse String");
            Console.WriteLine(ReverseWords("Azure DevOps can help you achieve faster time to market"));
        }
    }
}
