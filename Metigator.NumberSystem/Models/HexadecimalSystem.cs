

using Metigator.NumberSystemExtensions;

namespace Metigator.NumberSystem.Models
{
    /// <summary>Class that represent the hexadecimal number system</summary> 
    public class HexadecimalSystem : Base
    {
        /// <summary>
        /// Initializes a new instance of the Metigator.NumberSystem.Models.HexadecimalSystem class to the value indicated
        ///     by a specified string parameter
        /// </summary> 
        /// <param name="value">
        /// string that hold the value of the Hexadecimal system Instance
        /// </param>  
        public HexadecimalSystem(string value)
        {
            value.Guard("ABCDEFabcdef0123456789", NumberBase.HEXADECIMAL);
            this.Value = value;
        }
    }
}
