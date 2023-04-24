using System;

using R5T.T0132;


namespace R5T.T0182
{
    [FunctionalityMarker]
    public partial interface IIntegerOperator : IFunctionalityMarker
    {
        public Delay ToDelay(int value)
        {
            var output = new Delay(value);
            return output;
        }
    }
}
