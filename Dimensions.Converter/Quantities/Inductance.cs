


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of inductance.
   /// </summary>
   
   public class Inductance : PhysicalQuantityBase, IUnitConvertable<Inductance, InductanceUnit>, IComparable<Inductance>
   {
      #region public convenience properties

      private static readonly InductanceUnit HenryUnit = new Henry();
      private static readonly InductanceUnit MilliHenryUnit = new Henry(Multiple.Milli);

      /// <summary>
      /// Gets a unit of 1 Henry.
      /// </summary>
      public static InductanceUnit Henry
      {
         get { return HenryUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 milli Henry.
      /// </summary>
      public static InductanceUnit MilliHenry
      {
         get { return MilliHenryUnit; }
      }

      #endregion

      /// <summary>
      /// Creates a new instance of inductance.
      /// </summary>
      /// <param name="value">The numeric value of the length in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit of the length.</param>
      public Inductance(double value, InductanceUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameInductance; }
      }

      /// <summary>
      /// Gets an enumeration value for inductance.
      /// </summary>
      /// <value>Quantity.Inductance</value>
      public override Quantity Dimension
      {
         get { return Quantity.Inductance; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<Inductance,InductanceUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Inductance ConvertTo(InductanceUnit newUnit)
      {
         return (Inductance)base.ConvertTo(newUnit);
      }

      #endregion

      #region operator +

      public static Inductance operator +(Inductance x, Inductance y)
      {
         return Add(x, y);
      }

      public static Inductance operator +(Inductance x, int y)
      {
         return Add(x, y);
      }

      public static Inductance operator +(int x, Inductance y)
      {
         return Add(y, x);
      }

      public static Inductance operator +(double x, Inductance y)
      {
         return Add(y, x);
      }

      public static Inductance operator +(Inductance x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static Inductance operator -(Inductance x, Inductance y)
      {
         return Subtract(x, y);
      }

      public static Inductance operator -(int x, Inductance y)
      {
         return Subtract(y, x);
      }

      public static Inductance operator -(Inductance x, int y)
      {
         return Subtract(x, y);
      }

      public static Inductance operator -(double x, Inductance y)
      {
         return Subtract(y, x);
      }

      public static Inductance operator -(Inductance x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static Inductance operator *(Inductance x, Inductance y)
      {
         return Multiply(x, y);
      }

      public static Inductance operator *(Inductance x, int y)
      {
         return Multiply(x, y);
      }

      public static Inductance operator *(int x, Inductance y)
      {
         return Multiply(y, x);
      }

      public static Inductance operator *(Inductance x, double y)
      {
         return Multiply(x, y);
      }

      public static Inductance operator *(double x, Inductance y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static Inductance operator /(Inductance x, Inductance y)
      {
         return Divide(x, y);
      }

      public static Inductance operator /(Inductance x, int y)
      {
         return Divide(x, y);
      }

      public static Inductance operator /(int x, Inductance y)
      {
         return Divide(y, x);
      }

      public static Inductance operator /(Inductance x, double y)
      {
         return Divide(x, y);
      }

      public static Inductance operator /(double x, Inductance y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(Inductance x, Inductance y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(Inductance x, Inductance y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(Inductance x, Inductance y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(Inductance x, Inductance y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Inductance>

      /// <summary>
      /// Compares the Inductance object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Inductance other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}