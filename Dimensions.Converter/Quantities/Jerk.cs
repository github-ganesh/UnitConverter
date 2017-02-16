

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of Jerk.
   /// </summary>
   
   public class Jerk : PhysicalQuantityBase, IUnitConvertable<Jerk, JerkUnit>, IComparable<Jerk>
   {
      #region static convenience properties

      private static readonly JerkUnit MetersPerCubicSecondUnit = new JerkUnit(Length.Meter, Time.Second);
      private static readonly JerkUnit InchPerCubicSecondUnit = new JerkUnit(Length.Inch, Time.Second);

      /// <summary>
      /// Gets a unit for meters per square second.
      /// </summary>
      public static JerkUnit MetersPerCubicSecond
      {
         get { return MetersPerCubicSecondUnit; }
      }

      /// <summary>
      /// Gets a unit for inch per square second.
      /// </summary>
      public static JerkUnit InchPerCubicSecond
      {
         get { return InchPerCubicSecondUnit; }
      }

      #endregion static convenience properties

      /// <summary>
      /// Creates a new instance of Acceleration.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public Jerk(double value, JerkUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameJerk; }
      }

      /// <summary>
      /// Gets an enumeration value for this quantity.
      /// </summary>
      /// <value>Quantity.Jerk</value>
      public override Quantity Dimension
      {
         get { return Quantity.Jerk; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertible<Acceleration,AccelerationUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Jerk ConvertTo(JerkUnit newUnit)
      {
         return (Jerk)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertible<Acceleration,AccelerationUnit>

      #region operator +

      /// <summary>
      /// Performs an add operation on two jerks.
      /// </summary>
      /// <param name="x">A jerk to perform the add operation on.</param>
      /// <param name="y">Another jerk to perform the add operation on.</param>
      /// <returns>The sum of two jerks.</returns>
      public static Jerk operator +(Jerk x, Jerk y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Performs an add operation on a jerk and an integer.
      /// </summary>
      /// <param name="x">A jerk to perform the add operation on.</param>
      /// <param name="y">An integer the add operation on.</param>
      /// <returns>The sum of a jerk and an integer.</returns>     
      public static Jerk operator +(Jerk x, int y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Performs an add operation on a jerk and an integer.
      /// </summary>
      /// <param name="x">An integer the add operation on.</param>
      /// <param name="y">A jerk to perform the add operation on.</param>
      /// <returns>The sum of a jerk and an integer.</returns>     
      public static Jerk operator +(int x, Jerk y)
      {
         return Add(y, x);
      }

      public static Jerk operator +(double x, Jerk y)
      {
         return Add(y, x);
      }

      public static Jerk operator +(Jerk x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static Jerk operator -(Jerk x, Jerk y)
      {
         return Subtract(x, y);
      }

      public static Jerk operator -(int x, Jerk y)
      {
         return Subtract(y, x);
      }

      public static Jerk operator -(Jerk x, int y)
      {
         return Subtract(x, y);
      }

      public static Jerk operator -(double x, Jerk y)
      {
         return Subtract(y, x);
      }

      public static Jerk operator -(Jerk x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static Jerk operator *(Jerk x, Jerk y)
      {
         return Multiply(x, y);
      }

      public static Jerk operator *(Jerk x, int y)
      {
         return Multiply(x, y);
      }

      public static Jerk operator *(int x, Jerk y)
      {
         return Multiply(y, x);
      }

      public static Jerk operator *(Jerk x, double y)
      {
         return Multiply(x, y);
      }

      public static Jerk operator *(double x, Jerk y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static Jerk operator /(Jerk x, Jerk y)
      {
         return Divide(x, y);
      }

      public static Jerk operator /(Jerk x, int y)
      {
         return Divide(x, y);
      }

      public static Jerk operator /(int x, Jerk y)
      {
         return Divide(y, x);
      }

      public static Jerk operator /(Jerk x, double y)
      {
         return Divide(x, y);
      }

      public static Jerk operator /(double x, Jerk y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(Jerk x, Jerk y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(Jerk x, Jerk y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(Jerk x, Jerk y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(Jerk x, Jerk y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Acceleration>

      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Jerk other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<Acceleration>
   }
}