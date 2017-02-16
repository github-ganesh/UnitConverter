
using Dimensions.Converter.Properties;
using System;
using System.Globalization;


namespace Dimensions.Converter.Physics.Dimensions._Framework
{
   /// <summary>
   /// 
   /// </summary>
   public class UnitFormatProvider : IFormatProvider, ICustomFormatter
   {
      #region IFormatProvider Members

      /// <summary>
      /// Returns an object that provides formatting services for the specified type.
      /// </summary>
      /// <returns>
      /// An instance of the object specified by <paramref name="formatType"/>, if the <see cref="T:System.IFormatProvider"/> implementation can supply that type of object; otherwise, null.
      /// </returns>
      /// <param name="formatType">An object that specifies the type of format object to return. </param><filterpriority>1</filterpriority>
      public object GetFormat(Type formatType)
      {
         if (formatType == typeof (UnitFormatProvider))
         {
            return this;
         }

         return null;
      }

      #endregion

      #region ICustomFormatter Members

      /// <summary>
      /// Converts the value of a specified object to an equivalent string representation using specified format and culture-specific formatting information.
      /// </summary>
      /// <returns>
      /// The string representation of the value of <paramref name="arg"/>, formatted as specified by <paramref name="format"/> and <paramref name="formatProvider"/>.
      /// </returns>
      /// <param name="format">A format string containing formatting specifications. </param><param name="arg">An object to format. </param><param name="formatProvider">An object that supplies format information about the current instance. </param><filterpriority>2</filterpriority>
      public string Format(string format, object arg, IFormatProvider formatProvider)
      {
         if (arg.GetType() != typeof (UnitBase))
         {
            return HandleOtherFormats(format, arg);
         }

         UnitBase u = (UnitBase) arg;
         return u.ToString().Replace(PhysicsResources.DotOperator, "-");
      }

      #endregion

      private string HandleOtherFormats(string format, object arg)
      {
         IFormattable formattable = arg as IFormattable;
         if (formattable != null)
         {
            return formattable.ToString(format, CultureInfo.CurrentCulture);
         }

         else if (arg != null)
         {
            return arg.ToString();
         }
         else
         {
            return String.Empty;
         }
      }
   }
}
