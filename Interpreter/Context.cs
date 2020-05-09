using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Context
    {
        public string input { get; set; }
        public int output { get; set; }

        public Context(string input)
        {
            this.input = input;
            output = 0;
        }
    }
}
