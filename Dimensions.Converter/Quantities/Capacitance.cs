


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a physical quantity of electric capacitance.
   /// </summary>
   
   public class Capacitance : PhysicalQuantityBase, IUnitConvertable<Capacitance, CapacitanceUnit>, IComparable<Capacitance>
   {
      #region static convenience properties

      private static readonly CapacitanceUnit FaradUnit = new Farad();
      private static readonly CapacitanceUnit MilliFaradUnit = new Farad(Multiple.Milli);
      private static readonly CapacitanceUnit MicroFaradUnit = new Farad(Multiple.Micro);

      /// <summary>
      /// Gets the capacitance of 1 Farad. This is also the base unit.
      /// </summary>
      public static CapacitanceUnit Farad
      {
         get { return FaradUnit; }
      }

      /// <summary>
      /// Gets the capacitance of 1 milliFarad.
      /// </summary>
      public static CapacitanceUnit MilliFarad
      {
         get { return MilliFaradUnit; }
      }

      /// <summary>
      /// Gets the capacitance of 1 microFarad.
      /// </summary>
      public static CapacitanceUnit MicroFarad
      {
         get { return MicroFaradUnit; }
      }

      #endregion

      /// <summary>
      /// Creates a new instance of capacitance.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public Capacitance(double value, CapacitanceUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets an enumeration value for capacitance.
      /// </summary>
      /// <value>Quantity.Capacitance</value>
      public override Quantity Dimension
      {
         get { return Quantity.Capacitance; }
      }

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameCapacity; }
      }

      #endregion Overrides of PhysicalQuantity

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Capacitance ConvertTo(CapacitanceUnit newUnit)
      {
         return (Capacitance)base.ConvertTo(newUnit);
      }

      #region operator +

      public static Capacitance operator +(Capacitance x, Capacitance y)
      {
         return Add(x, y);
      }

      public static Capacitance operator +(Capacitance x, int y)
      {
         return Add(x, y);
      }

      public static Capacitance operator +(int x, Capacitance y)
      {
         return Add(y, x);
      }

      public static Capacitance operator +(double x, Capacitance y)
      {
         return Add(y, x);
      }

      public static Capacitance operator +(Capacitance x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static Capacitance operator -(Capacitance x, Capacitance y)
      {
         return Subtract(x, y);
      }

      public static Capacitance operator -(int x, Capacitance y)
      {
         return Subtract(y, x);
      }

      public static Capacitance operator -(Capacitance x, int y)
      {
         return Subtract(x, y);
      }

      public static Capacitance operator -(double x, Capacitance y)
      {
         return Subtract(y, x);
      }

      public static Capacitance operator -(Capacitance x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static Capacitance operator *(Capacitance x, Capacitance y)
      {
         return Multiply(x, y);
      }

      public static Capacitance operator *(Capacitance x, int y)
      {
         return Multiply(x, y);
      }

      public static Capacitance operator *(int x, Capacitance y)
      {
         return Multiply(y, x);
      }

      public static Capacitance operator *(Capacitance x, double y)
      {
         return Multiply(x, y);
      }

      public static Capacitance operator *(double x, Capacitance y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static Capacitance operator /(Capacitance x, Capacitance y)
      {
         return Divide(x, y);
      }

      public static Capacitance operator /(Capacitance x, int y)
      {
         return Divide(x, y);
      }

      public static Capacitance operator /(int x, Capacitance y)
      {
         return Divide(y, x);
      }

      public static Capacitance operator /(Capacitance x, double y)
      {
         return Divide(x, y);
      }

      public static Capacitance operator /(double x, Capacitance y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(Capacitance x, Capacitance y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(Capacitance x, Capacitance y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(Capacitance x, Capacitance y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(Capacitance x, Capacitance y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Capacitance>

      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Capacitance other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}