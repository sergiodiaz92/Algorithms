using System;

namespace RomanNumbers
{
    class Program
    {
        public static string RomanNumber(int number){
            string romanstr = "";
            if(number >= 1000){
                ProcessRomanNumber("M",1000,ref number,ref romanstr);
            }
            if(number >= 900 && number < 1000){
                ProcessRomanNumber("CM",900,ref number,ref romanstr);
            }
            if(number >= 500 && number < 900){
                ProcessRomanNumber("D",500,ref number,ref romanstr);
            }
            if(number >= 400 && number < 500){
                ProcessRomanNumber("CD",400,ref number,ref romanstr);
            }

            if(number >= 100 && number < 400){
                ProcessRomanNumber("C",100,ref number,ref romanstr);
            }
            
            if(number >= 90 && number < 100){
                ProcessRomanNumber("XC",90,ref number,ref romanstr);
            }
            
            if(number >= 50 && number < 90){
                ProcessRomanNumber("L",50,ref number,ref romanstr);
            }
            
            if(number >= 40 && number < 50){
                ProcessRomanNumber("XL",40,ref number,ref romanstr);
            }

            if(number >= 10 && number < 40){
                ProcessRomanNumber("X",10,ref number,ref romanstr);
            }

            if(number >= 9 && number < 10){
                ProcessRomanNumber("IX",9,ref number,ref romanstr);
            }
            
            if(number >= 5 && number < 9){
                ProcessRomanNumber("V",5,ref number,ref romanstr);
            }
            
            if(number >= 4 && number < 5){
                ProcessRomanNumber("IV",4,ref number,ref romanstr);
            }

            if(number >= 1 && number < 4){
                ProcessRomanNumber("I",1,ref number,ref romanstr);
            }

            return romanstr;
        }
        public static void ProcessRomanNumber(string romanLetter,int divisor, ref int number, ref string roman){
                int quotient = number/divisor;
                for (int j = 0; j < quotient; j++)
                {
                    roman += romanLetter;                    
                }
                number = number - divisor*quotient;
        }
        public static void PrintRomanNumber(int number){
            string msg = String.Format("Roman Number of {0} is {1}", number.ToString(),RomanNumber(number));
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            PrintRomanNumber(2021);
            PrintRomanNumber(1999);
            PrintRomanNumber(1549);
            PrintRomanNumber(999);
            PrintRomanNumber(854);
            PrintRomanNumber(698);
            PrintRomanNumber(486);
            PrintRomanNumber(265);
            PrintRomanNumber(145);
            PrintRomanNumber(99);
            PrintRomanNumber(85);
            PrintRomanNumber(47);
            PrintRomanNumber(29);
            PrintRomanNumber(15);
            PrintRomanNumber(9);
            PrintRomanNumber(7);
            PrintRomanNumber(4);
            PrintRomanNumber(2);
        }
    }
}
