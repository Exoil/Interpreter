using Interpreter.RomanNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Interpreter
{
    class Program
    {
     
        public static string ReadRomanSymbols()
        {
            string romanInput = Console.ReadLine();
            romanInput = romanInput.ToUpper();
            string tocheckByRemove;
            tocheckByRemove = romanInput.Trim('X','I','V','C','L','M','D');
            //int tocompare = romanInput.Count((symbol => symbol.CompareTo("X") || symbol.Equals("V") || symbol.Equals("X")
           // || symbol.Equals("C") || symbol.Equals("L") || symbol.Equals("M") || symbol.Equals("D"));
            
            if(tocheckByRemove.Equals(string.Empty))
            {
                return romanInput;
            }
            else
            {
                return string.Empty;
            }
        }

    
        static void Main(string[] args)
        {
            Console.WriteLine("Interpeter");

            var romanSymbols = new RomanNumberHelper();
            Context context = new Context("");
            string input = string.Empty;

            while (!string.IsNullOrEmpty(input = ReadRomanSymbols()))
            {
                context.input = input;
                context.output = 0;

                foreach(var expression in romanSymbols.romanExpression)
                {
                    expression.Interpet(context);
                }
                Console.WriteLine($"{input}: {context.output}");
            }


            Console.WriteLine("Koniec");
            Console.ReadLine();
        }
    }
}
