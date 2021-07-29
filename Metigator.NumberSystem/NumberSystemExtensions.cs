using Metigator.NumberSystem.Models;
using System;

namespace Metigator.NumberSystemExtensions
{

    /// <summary>Class that contains extension methods to convert number from one base to another</summary> 
    public static class Extensions
    {

        /// <summary>
        /// Extension Method to convert the decimal value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from decimal system to binary</returns>
        public static string ToBinary(this DecimalSystem source) =>
           source.To(NumberBase.BINARY);

        /// <summary>
        /// Extension Method to convert the decimal value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from decimal system to octal</returns>
        public static string ToOctal(this DecimalSystem source) =>
            source.To(NumberBase.OCTAL);

        /// <summary>
        /// Extension Method to convert the decimal value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from decimal system to hexadecimal</returns>
        public static string ToHexadecimal(this DecimalSystem source) =>
         source.To(NumberBase.HEXADECIMAL);


        /// <summary>
        /// Extension Method to convert the hexadecimal value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from hexadecimal system to binary</returns>
        public static string ToBinary(this HexadecimalSystem source) =>
             source.To(NumberBase.BINARY);

        /// <summary>
        /// Extension Method to convert the hexadecimal value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from hexadecimal system to octal</returns>
        public static string ToOctal(this HexadecimalSystem source) =>
              source.To(NumberBase.OCTAL);

        /// <summary>
        /// Extension Method to convert the hexadecimal value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from hexadecimal system to decimal</returns>
        public static string ToDecimal(this HexadecimalSystem source) =>
              source.To(NumberBase.DECIMAL);

        /// <summary>
        /// Extension Method to convert the Octal value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from octal system to binary</returns>
        public static string ToBinary(this OctalSystem source) =>
           source.To(NumberBase.BINARY);

        /// <summary>
        /// Extension Method to convert the Octal value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from octal system to decimal</returns>
        public static string ToDecimal(this OctalSystem source) =>
           source.To(NumberBase.DECIMAL);

        /// <summary>
        /// Extension Method to convert the Octal value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from octal system to hexadecimal</returns>
        public static string ToHexadecimal(this OctalSystem source) =>
           source.To(NumberBase.HEXADECIMAL);

        /// <summary>
        /// Extension Method to convert the Binary value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from Binary system to octal</returns>
        public static string ToOctal(this BinarySystem source) =>
          source.To(NumberBase.OCTAL);

        /// <summary>
        /// Extension Method to convert the Binary value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from Binary system to decimal</returns>
        public static string ToDecimal(this BinarySystem source) =>
           source.To(NumberBase.DECIMAL);

        /// <summary>
        /// Extension Method to convert the Binary value of <paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param> 
        /// <returns>A string value as a result of conversion from Binary system to hexadecimal</returns>
        public static string ToHexadecimal(this BinarySystem source) =>
            source.To(NumberBase.HEXADECIMAL);


        /// <summary>
        /// Extension Method to convert <typeparamref name="T"/><paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param>
        /// <param name="toBase">
        /// enum value that represent the number system
        /// </param> 
        /// <returns>A string value as a result of conversion</returns>
        public static string To<T>(this T source, NumberBase toBase) where T : Base
        {
#if DEBUG
            Console.WriteLine("This will be shown in debug mode only");
#endif
            NumberBase fromBase;


            switch (source)
            {
                case BinarySystem: fromBase = NumberBase.BINARY; break;
                case OctalSystem: fromBase = NumberBase.OCTAL; break;
                case DecimalSystem: fromBase = NumberBase.DECIMAL; break;
                case HexadecimalSystem: fromBase = NumberBase.HEXADECIMAL; break;
                default: fromBase = NumberBase.DECIMAL; break;
            }

            return Convert.ToString(Convert.ToInt32(source.Value, (int)fromBase), (int)toBase);
        }

        /// <summary>
        /// Guard to validate ser input 
        /// </summary>
        /// <param name="source">
        /// the string to validate
        /// </param>
        /// <param name="allowedCharacter">
        /// The Allowed Character set as a string value
        /// </param>
        /// <param name="numberBase">
        /// This parameter helps identifying which number system input violate the rules
        /// </param> 
        /// <exception cref="System.InvalidOperationException">
        /// Thrown when <paramref name="source" has at least one character that does not exist in the characters of  <paramref name="allowedCharacter"/>
        /// </exception>
        public static void Guard(this string source, string allowedCharacter, NumberBase numberBase)
        {
            foreach (var ch in source)
            {
                if (!allowedCharacter.Contains(ch))
                    throw new InvalidOperationException($"'{source}' is invalid {numberBase}");
            }
        }
    }
}
