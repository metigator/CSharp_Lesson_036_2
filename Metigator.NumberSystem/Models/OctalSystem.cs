 
using Metigator.NumberSystemExtensions;

namespace Metigator.NumberSystem.Models
{
    /// <summary>Class that represent the octal number system</summary> 
    public class OctalSystem : Base
    {
        /// <summary>
        /// Initializes a new instance of the Metigator.NumberSystem.Models.OctalSystem class to the value indicated
        ///    by a specified string parameter
        /// </summary> 
        /// <param name="value">
        /// string that hold the value of the Octal system Instance
        /// </param>  
        public OctalSystem(string value)
        {
            value.Guard("01234567", NumberBase.OCTAL);
            this.Value = value;
        }
    }
}
