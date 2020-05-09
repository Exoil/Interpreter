using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.RomanNumbers
{
    public class RomanOne : Expression
    {
        public override string Five()
        {
            return "V";
        }

        public override string Four()
        {
            return "IV";
        }

        public override int Multipler()
        {
            return 1;
        }

        public override string Nine()
        {
            return "IX";
        }

        public override string One()
        {
            return "I";
        }
    }
}
