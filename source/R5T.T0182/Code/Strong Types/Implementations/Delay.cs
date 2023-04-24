using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0182
{
    /// <inheritdoc cref="IDelay"/>
    [StrongTypeImplementationMarker]
    public class Delay : TypedBase<int>, IStrongTypeImplementationMarker,
        IDelay
    {
        public Delay(int value)
            : base(value)
        {
        }
    }
}
