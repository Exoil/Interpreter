using Interpreter;
using Interpreter.RomanNumbers;
using System;
using Xunit;

namespace InterpreterTest
{
    public class RomanNumbersTest
    {
        [Theory]
        [InlineData("CC")]
        public void PositiveTest(string test)
        {
            var helper = new RomanNumberHelper();
            Assert.True(helper.ValidateExpression(test));
          
            if (helper.ValidateExpression(test))
            {
                var context = new Context(test);

                foreach (var expression in helper.romanExpression)
                {
                    expression.Interpet(context);
                }
                Assert.Equal(200, context.output);
            }

        }
        [Theory]
        [InlineData("COC")]
        public void NegativeTest(string test)
        {
            var helper = new RomanNumberHelper();
            var tekst = helper.ValidateExpression(test);
            Assert.False(helper.ValidateExpression(test));
            if (helper.ValidateExpression(test) == true)
            {
                var context = new Context(test);

                foreach (var expression in helper.romanExpression)
                {
                    expression.Interpet(context);
                }
                Assert.Equal(200, context.output);
            }
        }
    }
    
}
