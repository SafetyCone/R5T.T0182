using System;

using R5T.T0178;
using R5T.T0183;


namespace R5T.T0182
{
    /// <summary>
    /// A delay, in <inheritdoc cref="Y0005.Glossary.ForTime.Milliseconds" path="/display"/> for use with the various threading delay and sleep methods.
    /// </summary>
    public interface IDelay : IStrongTypeMarker,
        IMilliseconds
    {
    }
}
