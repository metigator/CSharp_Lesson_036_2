namespace Metigator.NumberSystem.Models
{
    /// <summary>Class that act as the base class for all number system</summary> 
    public abstract class Base
    {
        /// <value>
        /// The <c>Value</c> property represents a Value that needs to be converted
        /// for this instance.
        /// </value>
        public string Value { get; protected set; }
    }
}
