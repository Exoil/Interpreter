using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.RomanNumbers
{
    public class RomanTen : Expression
    {
        public override string Five()
        {
            return "L";
        }

        public override string Four()
        {
            return "XL";
        }

        public override int Multipler()
        {
            return 10;
        }

        public override string Nine()
        {
            return "XC";
        }

        public override string One()
        {
            return "X";
        }
    }
}
