

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{

   /// <summary>
   /// Represents the physical quantity of length.
   /// </summary>
   
   public class Length : PhysicalQuantityBase, IUnitConvertable<Length, LengthUnit>, IComparable<Length>
   {
      #region public convenience properties

      private static readonly LengthUnit MillimeterUnit = new Meter(Multiple.Milli);
      private static readonly LengthUnit MeterUnit = new Meter();
      private static readonly LengthUnit CentimeterUnit = new Meter(Multiple.Centi);
      private static readonly LengthUnit DecimeterUnit = new Meter(Multiple.Deci);
      private static readonly LengthUnit KilometerUnit = new Meter(Multiple.Kilo);
      private static readonly LengthUnit InchUnit = new Inch();
      private static readonly LengthUnit FootUnit = new Foot();
      private static readonly LengthUnit YardUnit = new Yard();
      private static readonly LengthUnit MileUnit = new Mile();

      /// <summary>
      /// Gets a unit of 1 millimeter
      /// </summary>
      public static LengthUnit Millimeter
      {
         get { return MillimeterUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 meter
      /// </summary>
      public static LengthUnit Meter
      {
         get { return MeterUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 centimeter
      /// </summary>
      public static LengthUnit Centimeter
      {
         get { return CentimeterUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 decimeter
      /// </summary>
      public static LengthUnit Decimeter
      {
         get { return DecimeterUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 kilometer
      /// </summary>
      public static LengthUnit Kilometer
      {
         get { return KilometerUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 inch
      /// </summary>
      public static LengthUnit Inch
      {
         get { return InchUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 foot
      /// </summary>
      public static LengthUnit Foot
      {
         get { return FootUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 yard
      /// </summary>
      public static LengthUnit Yard
      {
         get { return YardUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 mile
      /// </summary>
      public static LengthUnit Mile
      {
         get { return MileUnit; }
      }

      #endregion public convenience properties

      /// <summary>
      /// Creates a new instance of length.
      /// </summary>
      /// <param name="value">The numeric value of the length in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit of the length.</param>
      public Length(double value, LengthUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameLength; }
      }

      /// <summary>
      /// Gets an enumeration value for length.
      /// </summary>
      public override Quantity Dimension
      {
         get { return Quantity.Length; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<Length,LengthUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Length ConvertTo(LengthUnit newUnit)
      {
         return (Length)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertable<Length,LengthUnit>

      #region operator +
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator +(Length x, Length y)
      {
         return Add(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator +(Length x, int y)
      {
         return Add(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator +(int x, Length y)
      {
         return Add(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator +(double x, Length y)
      {
         return Add(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator +(Length x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator -(Length x, Length y)
      {
         return Subtract(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator -(int x, Length y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator -(Length x, int y)
      {
         return Subtract(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator -(double x, Length y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator -(Length x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator *(Length x, Length y)
      {
         Length l = Multiply(x, y);
         AreaUnit u = new AreaUnit((LengthUnit)x.Unit);
         return new Area(l.Value, u);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator *(Length x, int y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator *(int x, Length y)
      {
         return Multiply(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator *(Length x, double y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator *(double x, Length y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Quotient operator /(Length x, Length y)
      {
         Length l = Multiply(x, y);
         RatioUnit u = Quotient.Ratio;
         return new Quotient(l.Value, u);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator /(Length x, int y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator /(int x, Length y)
      {
         return Divide(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator /(Length x, double y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Length operator /(double x, Length y)
      {
         return Divide(y, x);
      }

      #endregion operator /
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >(Length x, Length y)
      {
         return x.CompareTo(y) > 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(Length x, Length y)
      {
         return x.CompareTo(y) < 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(Length x, Length y)
      {
         return x.CompareTo(y) >= 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(Length x, Length y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Length>

      /// <summary>
      /// Compares the Length object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Length other)
      {
         return base.CompareToInternal(other);
      }

      #endregion Implementation of IComparable<Length>
   }
}