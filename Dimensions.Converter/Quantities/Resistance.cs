

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// The physical dimension of Resistance.
   /// </summary>
   
   public class Resistance : PhysicalQuantityBase, IUnitConvertable<Resistance, ResistanceUnit>, IComparable<Resistance>
   {
      #region public convenience properties

      private static readonly ResistanceUnit OhmUnit = new Ohm();
      private static readonly ResistanceUnit KiloOhmUnit = new Ohm(Multiple.Kilo);

      /// <summary>
      /// Gets a unit of 1 ohm.
      /// </summary>
      public static ResistanceUnit Ohm
      {
         get { return OhmUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 kilo Ohm.
      /// </summary>
      public static ResistanceUnit KiloOhm
      {
         get { return KiloOhmUnit; }
      }

      #endregion public convenience properties

      /// <summary>
      /// Creates a new instance of time.
      /// </summary>
      /// <param name="value"></param>
      /// <param name="unit"></param>
      public Resistance(double value, ResistanceUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets an enumeration value for Resistance.
      /// </summary>
      /// <value>Quantity.ElectricResistance</value>
      public override Quantity Dimension
      {
         get { return Quantity.ElectricResistance; }
      }

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameResistance; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<Resistance,ResistanceUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Resistance ConvertTo(ResistanceUnit newUnit)
      {
         return (Resistance)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertable<Resistance,ResistanceUnit>

      #region operator +

      public static Resistance operator +(Resistance x, Resistance y)
      {
         return Add(x, y);
      }

      public static Resistance operator +(Resistance x, int y)
      {
         return Add(x, y);
      }

      public static Resistance operator +(int x, Resistance y)
      {
         return Add(y, x);
      }

      public static Resistance operator +(double x, Resistance y)
      {
         return Add(y, x);
      }

      public static Resistance operator +(Resistance x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static Resistance operator -(Resistance x, Resistance y)
      {
         return Subtract(x, y);
      }

      public static Resistance operator -(int x, Resistance y)
      {
         return Subtract(y, x);
      }

      public static Resistance operator -(Resistance x, int y)
      {
         return Subtract(x, y);
      }

      public static Resistance operator -(double x, Resistance y)
      {
         return Subtract(y, x);
      }

      public static Resistance operator -(Resistance x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static Resistance operator *(Resistance x, Resistance y)
      {
         return Multiply(x, y);
      }

      public static Resistance operator *(Resistance x, int y)
      {
         return Multiply(x, y);
      }

      public static Resistance operator *(int x, Resistance y)
      {
         return Multiply(y, x);
      }

      public static Resistance operator *(Resistance x, double y)
      {
         return Multiply(x, y);
      }

      public static Resistance operator *(double x, Resistance y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static Resistance operator /(Resistance x, Resistance y)
      {
         return Divide(x, y);
      }

      public static Resistance operator /(Resistance x, int y)
      {
         return Divide(x, y);
      }

      public static Resistance operator /(int x, Resistance y)
      {
         return Divide(y, x);
      }

      public static Resistance operator /(Resistance x, double y)
      {
         return Divide(x, y);
      }

      public static Resistance operator /(double x, Resistance y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(Resistance x, Resistance y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(Resistance x, Resistance y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(Resistance x, Resistance y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(Resistance x, Resistance y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Resistance>

      /// <summary>
      /// Compares the Resistance object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Resistance other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<Resistance>
   }
}