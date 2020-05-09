using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.RomanNumbers
{
    public class RomanHundred : Expression
    {
        public override string Five()
        {
            return "D";
        }

        public override string Four()
        {
            return "CD";
        }

        public override int Multipler()
        {
            return 100;
        }

        public override string Nine()
        {
            return "CM";
        }

        public override string One()
        {
            return "C";
        }
    }
}
