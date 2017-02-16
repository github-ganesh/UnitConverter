


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of Voltage.
   /// </summary>
   
   public class Voltage : PhysicalQuantityBase, IUnitConvertable<Voltage, VoltageUnit>, IComparable<Voltage>
   {
      #region static convenience properties

      private static readonly VoltageUnit VoltUnit = new Volt();
      private static readonly VoltageUnit KiloVoltUnit = new Volt(Multiple.Kilo);
      private static readonly VoltageUnit MilliVoltUnit = new Volt(Multiple.Milli);

      /// <summary>
      /// Gets a time unit of 1 Volt. This is also the base unit.
      /// </summary>
      public static VoltageUnit Volt
      {
         get { return VoltUnit; }
      }

      /// <summary>
      /// Gets a time unit of 1 KiloVolt.
      /// </summary>
      public static VoltageUnit KiloVolt
      {
         get { return KiloVoltUnit; }
      }

      /// <summary>
      /// Gets a time unit of 1 MilliVolt.
      /// </summary>
      public static VoltageUnit MilliVolt
      {
         get { return MilliVoltUnit; }
      }

      #endregion static convenience properties

      /// <summary>
      /// Creates a new instance of Voltage.
      /// </summary>
      /// <param name="value">The numeric value of the current in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit of the voltage.</param>
      public Voltage(double value, VoltageUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameVoltage; }
      }

      /// <summary>
      /// Gets an enumeration value for electric current.
      /// </summary>
      public override Quantity Dimension
      {
         get { return Quantity.Voltage; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<Voltage,VoltageUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Voltage ConvertTo(VoltageUnit newUnit)
      {
         return (Voltage)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertable<Voltage,VoltageUnit>

      #region operator +
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator +(Voltage x, Voltage y)
      {
         return Add(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator +(Voltage x, int y)
      {
         return Add(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator +(int x, Voltage y)
      {
         return Add(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator +(double x, Voltage y)
      {
         return Add(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator +(Voltage x, double y)
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
      public static Voltage operator -(Voltage x, Voltage y)
      {
         return Subtract(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator -(int x, Voltage y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator -(Voltage x, int y)
      {
         return Subtract(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator -(double x, Voltage y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator -(Voltage x, double y)
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
      public static Voltage operator *(Voltage x, Voltage y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator *(Voltage x, int y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator *(int x, Voltage y)
      {
         return Multiply(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator *(Voltage x, double y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator *(double x, Voltage y)
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
      public static Voltage operator /(Voltage x, Voltage y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator /(Voltage x, int y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator /(int x, Voltage y)
      {
         return Divide(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator /(Voltage x, double y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Voltage operator /(double x, Voltage y)
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
      public static bool operator >(Voltage x, Voltage y)
      {
         return x.CompareTo(y) > 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(Voltage x, Voltage y)
      {
         return x.CompareTo(y) < 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(Voltage x, Voltage y)
      {
         return x.CompareTo(y) >= 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(Voltage x, Voltage y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Voltage>

      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Voltage other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}