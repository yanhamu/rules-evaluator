using EvalRulez.Core;
using EvalRulez.Core.Expressions;
using System;

namespace EvalRulez.Core.FluentRule
{
    public class Rule<T>
    {
        protected IExpression<T> expression;

        public Rule(Func<T, bool> func)
        {
            expression = new SimpleExpression<T>(func);
        }

        public static Rule<T> When(Func<T,bool> expression)
        {
            return new Rule<T>(expression);
        }

        public Rule<T> And(Func<T, bool> expression)
        {
            this.expression = new And<T>(this.expression, new SimpleExpression<T>(expression));
            return this;
        }

        public Rule<T> Or(Func<T, bool> expression)
        {
            this.expression = new Or<T>(this.expression, new SimpleExpression<T>(expression));
            return this;
        }

        public Class<T> ClassifyAs(string name)
        {
            return new Class<T>(this.expression, name);
        }
    }
}