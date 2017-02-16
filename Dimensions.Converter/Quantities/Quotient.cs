

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of Quotient
   /// </summary>
   
   public class Quotient : PhysicalQuantityBase, IUnitConvertable<Quotient, RatioUnitBase>, IComparable<Quotient>
   {
      #region public convenience properties

      private static readonly Percent percent = new Percent();
      private static readonly RatioUnit ratio = new RatioUnit();

      /// <summary>
      /// Gets the unit of 1 per cent.
      /// </summary>
      public static Percent Percent
      {
         get { return percent; }
      }

      /// <summary>
      /// Gets a unit of a ratio.
      /// </summary>
      public static RatioUnit Ratio
      {
         get { return ratio; }
      }

      #endregion public convenience properties

      /// <summary>
      /// Creates a new instance of Quotient.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public Quotient(double value, RatioUnitBase unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameRatio; }
      }

      /// <summary>
      /// Gets an enumeQuotientn value for Quotient.
      /// </summary>
      public override Quantity Dimension
      {
         get { return Quantity.Ratio; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<Quotient,QuotientUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Quotient ConvertTo(RatioUnitBase newUnit)
      {
         return (Quotient)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertable<Quotient,QuotientUnit>

      #region operator +

      /// <summary>
      /// Adds two Quotients.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator +(Quotient x, Quotient y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Adds a Quotient to an integer.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator +(Quotient x, int y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Adds an integer to a Quotient.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator +(int x, Quotient y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// Adds a double to a Quotient.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator +(double x, Quotient y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// Adds a Quotient to a double.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator +(Quotient x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      /// <summary>
      /// Subtracts a Quotient from another.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator -(Quotient x, Quotient y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      /// Subtracts a Quotient from an iteger.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator -(int x, Quotient y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      /// Subtracts an integer from a Quotient.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator -(Quotient x, int y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      /// Subtracts a Quotient from a double.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator -(double x, Quotient y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      /// Subtracts a double from a Quotient.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator -(Quotient x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      /// <summary>
      /// Multiplies two Quotients.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator *(Quotient x, Quotient y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// Multiplies a Quotient by an integer.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator *(Quotient x, int y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// Multiplies an integer by a Quotient.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator *(int x, Quotient y)
      {
         return Multiply(y, x);
      }

      /// <summary>
      /// Multiplies a Quotient by a double.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator *(Quotient x, double y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// Multiplies a double by a Quotient.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator *(double x, Quotient y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      /// <summary>
      /// Divides two Quotients.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator /(Quotient x, Quotient y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// Divides a Quotient by an integer.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator /(Quotient x, int y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// Divides an integer by a Quotient.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator /(int x, Quotient y)
      {
         return Divide(y, x);
      }

      /// <summary>
      /// Divides a Quotient by a double.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator /(Quotient x, double y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// Divides a double by a Quotient.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator /(double x, Quotient y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      /// <summary>
      /// Compares two Quotients.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >(Quotient x, Quotient y)
      {
         return x.CompareTo(y) > 0;
      }

      /// <summary>
      /// Compares two Quotients.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(Quotient x, Quotient y)
      {
         return x.CompareTo(y) < 0;
      }

      /// <summary>
      /// Compares two Quotients.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(Quotient x, Quotient y)
      {
         return x.CompareTo(y) >= 0;
      }

      /// <summary>
      /// Compares two Quotients.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(Quotient x, Quotient y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Quotient>

      /// <summary>
      /// Compares the Quotient object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Quotient other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<Quotient>
   }
}