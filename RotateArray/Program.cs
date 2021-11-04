using System;

namespace RotateArray
{
    class Program
    {
        public static int[] RotateArray(int[] myArray, int steps){
            
            for (int j = 0; j < steps; j++)
            {
                int last = myArray[myArray.Length - 1];
                for (int i = myArray.Length-1; i > 0; i--)
                {
                    myArray[i]=myArray[i-1];
                }
                myArray[0]=last;
            }
            
            return myArray;

        }
        public static void PrintArray(int[] myArray){
            string msgStr = "";
            for (int i = 0; i < myArray.Length; i++)
            {
                msgStr += myArray[i].ToString() + ",";
            }
            msgStr = msgStr.Remove(msgStr.Length -1,1);
            Console.WriteLine(String.Format("[{0}]",msgStr));
        }
        static void Main(string[] args)
        {
            int[] myArray = {1,2,3,4,5,6,7};
            PrintArray(myArray);
            PrintArray(RotateArray(myArray,5));
        }
    }
}
