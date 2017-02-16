


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// The physical dimension of speed.
   /// </summary>
   
   public class Speed : PhysicalQuantityBase, IUnitConvertable<Speed, SpeedUnit>, IComparable<Speed>
   {
      #region public convenience properties

      private static readonly SpeedUnit MetersPerSecondUnit = new SpeedUnit(Length.Meter, Time.Second);
      private static readonly SpeedUnit KiloMetersPerHourUnit = new SpeedUnit(Length.Kilometer, Time.Hour);
      private static readonly SpeedUnit MilesPerHourUnit = new SpeedUnit(Length.Mile, Time.Hour);

      /// <summary>
      /// Gets a new instance for meters per second.
      /// </summary>
      public static SpeedUnit MetersPerSecond
      {
         // 1 meter times 1 second to the power of -1. (m * s^-1)
         get { return MetersPerSecondUnit; }
      }

      /// <summary>
      /// Gets a new instance for kilometers per hour.
      /// </summary>
      public static SpeedUnit KiloMetersPerHour
      {
         get { return KiloMetersPerHourUnit; }
      }

      /// <summary>
      /// Gets a new instance for miles per hour.
      /// </summary>
      public static SpeedUnit MilesPerHour
      {
         get { return MilesPerHourUnit; }
      }


      #endregion

      /// <summary>
      /// Creates a new instance of speed.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public Speed(double value, SpeedUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameSpeed; }
      }

      /// <summary>
      /// Gets an enumeration value for speed.
      /// </summary>
      /// <value><see cref="Quantity.Speed"/></value>
      public override Quantity Dimension
      {
         get { return Quantity.Speed; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<Speed,SpeedUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Speed ConvertTo(SpeedUnit newUnit)
      {
         return (Speed)base.ConvertTo(newUnit);
      }

      #endregion

      #region operator +

      public static Speed operator +(Speed x, Speed y)
      {
         return Add(x, y);
      }

      public static Speed operator +(Speed x, int y)
      {
         return Add(x, y);
      }

      public static Speed operator +(int x, Speed y)
      {
         return Add(y, x);
      }

      public static Speed operator +(double x, Speed y)
      {
         return Add(y, x);
      }

      public static Speed operator +(Speed x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static Speed operator -(Speed x, Speed y)
      {
         return Subtract(x, y);
      }

      public static Speed operator -(int x, Speed y)
      {
         return Subtract(y, x);
      }

      public static Speed operator -(Speed x, int y)
      {
         return Subtract(x, y);
      }

      public static Speed operator -(double x, Speed y)
      {
         return Subtract(y, x);
      }

      public static Speed operator -(Speed x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static Speed operator *(Speed x, Speed y)
      {
         return Multiply(x, y);
      }

      public static Speed operator *(Speed x, int y)
      {
         return Multiply(x, y);
      }

      public static Speed operator *(int x, Speed y)
      {
         return Multiply(y, x);
      }

      public static Speed operator *(Speed x, double y)
      {
         return Multiply(x, y);
      }

      public static Speed operator *(double x, Speed y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static Speed operator /(Speed x, Speed y)
      {
         return Divide(x, y);
      }

      public static Speed operator /(Speed x, int y)
      {
         return Divide(x, y);
      }

      public static Speed operator /(int x, Speed y)
      {
         return Divide(y, x);
      }

      public static Speed operator /(Speed x, double y)
      {
         return Divide(x, y);
      }

      public static Speed operator /(double x, Speed y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(Speed x, Speed y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(Speed x, Speed y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(Speed x, Speed y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(Speed x, Speed y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Speed>

      /// <summary>
      /// Compares the Speed object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Speed other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}