using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.RomanNumbers
{
    public abstract class Expression
    {
        public void Interpet(Context context)
        {
          if(string.IsNullOrEmpty(context.input))
            { return; }
            
            if(context.input.StartsWith(Nine()))
            {
                context.output += 9 * Multipler();
                context.input=  context.input.Substring(2);
            }
            else if (context.input.StartsWith(Five()))
            {
                context.output += 5 * Multipler();
                context.input = context.input.Substring(1);
            }
            else if (context.input.StartsWith(Four()))
            {
                context.output += 4 * Multipler();
                context.input = context.input.Substring(2);
            }
            while(context.input.StartsWith(One()))
            {
                context.output += 1 * Multipler();
                context.input = context.input.Substring(1);
            }
        }

        abstract public string One();
        abstract public string Four();
        abstract public string Five();
        abstract public string Nine();
        abstract public int Multipler();
      
    }

    
}
