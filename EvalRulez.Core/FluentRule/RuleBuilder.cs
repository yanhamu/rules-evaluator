using System;

namespace EvalRulez.Core.FluentRule
{
    public static class RuleBuilder
    {
        public static Rule<T> When<T>(Func<T, bool> expression)
        {
            return new Rule<T>(expression);
        }
    }
}