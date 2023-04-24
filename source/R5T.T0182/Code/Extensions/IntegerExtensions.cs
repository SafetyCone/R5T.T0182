using System;


namespace R5T.T0182.Extensions
{
    public static class IntegerExtensions
    {
        public static Delay ToDelay(this int value)
        {
            return Instances.IntegerOperator.ToDelay(value);
        }
    }
}
