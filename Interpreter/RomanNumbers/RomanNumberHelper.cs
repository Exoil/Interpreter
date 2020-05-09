using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.RomanNumbers
{
    public class RomanNumberHelper
    {

        public List<Expression> romanExpression;

        public RomanNumberHelper()
        {
            romanExpression = new List<Expression>()
            {
                new RomanHundred(),
                new RomanTen(),
                new RomanOne()
            };         
        }

        public bool ValidateExpression(string expression)
        {
            string tocheckByRemove;
            tocheckByRemove = expression.Trim('X', 'I', 'V', 'C', 'L', 'M', 'D');
            return tocheckByRemove == string.Empty;
        }
    }
}
