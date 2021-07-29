using Metigator.NumberSystemExtensions;

namespace Metigator.NumberSystem.Models
{
    /// <summary>Class that represent the decimal number system</summary> 
    public class DecimalSystem : Base
    {
        /// <summary>
        /// Initializes a new instance of the Metigator.NumberSystem.Models.DecimalSystem class to the value indicated
        ///     by a specified string parameter
        /// </summary> 
        /// <param name="value">
        /// string that hold the value of the Decimal system Instance
        /// </param>  
        public DecimalSystem(string value)
        {
            value.Guard("0123456789", NumberBase.DECIMAL);
            this.Value = value;
        }
    }
}
