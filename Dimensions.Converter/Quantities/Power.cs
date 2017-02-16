


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// The physical dimension of power.
   /// </summary>
   
   public class Power : PhysicalQuantityBase, IUnitConvertable<Power, PowerUnit>, IComparable<Power>
   {
      #region public convenience properties

      private static readonly PowerUnit MilliWattUnit = new Watt(Multiple.Milli);
      private static readonly PowerUnit WattUnit = new Watt();
      private static readonly PowerUnit KiloWattUnit = new Watt(Multiple.Kilo);
      private static readonly PowerUnit MegaWattUnit = new Watt(Multiple.Mega);
      private static readonly PowerUnit GigaWattUnit = new Watt(Multiple.Giga);

      /// <summary>
      /// Gets a unit of 1 milliwatt.
      /// </summary>
      public static PowerUnit MilliWatt
      {
         get { return MilliWattUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 watt.
      /// </summary>
      public static PowerUnit Watt
      {
         get { return WattUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 kilowatt.
      /// </summary>
      public static PowerUnit KiloWatt
      {
         get { return KiloWattUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 megawatt.
      /// </summary>
      public static PowerUnit MegaWatt
      {
         get { return MegaWattUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 gigawatt.
      /// </summary>
      public static PowerUnit GigaWatt
      {
         get { return GigaWattUnit; }
      }

      #endregion

      /// <summary>
      /// Creates a new instance of power.
      /// </summary>
      /// <param name="value">Numeric value of the dimension.</param>
      /// <param name="unit">The unit of this dimension.</param>
      public Power(double value, PowerUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NamePower; }
      }

      /// <summary>
      /// Gets an enumeration value for Power.
      /// </summary>
      public override Quantity Dimension
      {
         get { return Quantity.Power; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<Power,PowerUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Power ConvertTo(PowerUnit newUnit)
      {
         return (Power)base.ConvertTo(newUnit);
      }

      #endregion

      #region operator +

      public static Power operator +(Power x, Power y)
      {
         return Add(x, y);
      }

      public static Power operator +(Power x, int y)
      {
         return Add(x, y);
      }

      public static Power operator +(int x, Power y)
      {
         return Add(y, x);
      }

      public static Power operator +(double x, Power y)
      {
         return Add(y, x);
      }

      public static Power operator +(Power x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static Power operator -(Power x, Power y)
      {
         return Subtract(x, y);
      }

      public static Power operator -(int x, Power y)
      {
         return Subtract(y, x);
      }

      public static Power operator -(Power x, int y)
      {
         return Subtract(x, y);
      }

      public static Power operator -(double x, Power y)
      {
         return Subtract(y, x);
      }

      public static Power operator -(Power x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static Power operator *(Power x, Power y)
      {
         return Multiply(x, y);
      }

      public static Power operator *(Power x, int y)
      {
         return Multiply(x, y);
      }

      public static Power operator *(int x, Power y)
      {
         return Multiply(y, x);
      }

      public static Power operator *(Power x, double y)
      {
         return Multiply(x, y);
      }

      public static Power operator *(double x, Power y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static Power operator /(Power x, Power y)
      {
         return Divide(x, y);
      }

      public static Power operator /(Power x, int y)
      {
         return Divide(x, y);
      }

      public static Power operator /(int x, Power y)
      {
         return Divide(y, x);
      }

      public static Power operator /(Power x, double y)
      {
         return Divide(x, y);
      }

      public static Power operator /(double x, Power y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(Power x, Power y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(Power x, Power y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(Power x, Power y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(Power x, Power y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Power>

      /// <summary>
      /// Compares the Power object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Power other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}