

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of angular Jerk.
   /// </summary>
   
   public class AngularJerk : PhysicalQuantityBase, IUnitConvertable<AngularJerk, AngularJerkUnit>, IComparable<AngularJerk>
   {
      #region static convenience properties

      private static readonly AngularJerkUnit DegreePerCubicSecondUnit = new AngularJerkUnit(PlaneAngle.Degree, Time.Second);
      private static readonly AngularJerkUnit RadPerCubicSecondUnit = new AngularJerkUnit(PlaneAngle.Rad, Time.Second);

      /// <summary>
      /// Gets a unit for meters per cubic second.
      /// </summary>

      public static AngularJerkUnit DegreePerCubicSecond
      {
         get { return DegreePerCubicSecondUnit; }
      }

      /// <summary>
      /// Gets a unit for inch per cubic second.
      /// </summary>
      public static AngularJerkUnit RadPerCubicSecond
      {
         get { return RadPerCubicSecondUnit; }
      }

      #endregion static convenience properties

      /// <summary>
      /// Creates a new instance of Jerk.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public AngularJerk(double value, AngularJerkUnit unit)
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

      #region Implementation of IUnitConvertible<Jerk,JerkUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public AngularJerk ConvertTo(AngularJerkUnit newUnit)
      {
         return (AngularJerk)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertible<Jerk,JerkUnit>

      #region operator +

      /// <summary>
      /// Adds two jerks.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator +(AngularJerk x, AngularJerk y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Adds a jerk and an integer.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator +(AngularJerk x, int y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Adds a jerk and an integer.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator +(int x, AngularJerk y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// Adds a jerk and a double.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator +(double x, AngularJerk y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// Adds a jerk and a double.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator +(AngularJerk x, double y)
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
      public static AngularJerk operator -(AngularJerk x, AngularJerk y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator -(int x, AngularJerk y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator -(AngularJerk x, int y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator -(double x, AngularJerk y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator -(AngularJerk x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      /// <summary>
      /// Multiplies two angular jerks.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator *(AngularJerk x, AngularJerk y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// Multiplies an angular jerk with an integer.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator *(AngularJerk x, int y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// Multiplies an integer with an angular jerk.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator *(int x, AngularJerk y)
      {
         return Multiply(y, x);
      }

      /// <summary>
      /// Multiplies an angular jerk with a double.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator *(AngularJerk x, double y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// Multiplies a double with an angular jerk.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator *(double x, AngularJerk y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      /// <summary>
      /// Divides two angular jerks.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator /(AngularJerk x, AngularJerk y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// Divides an angular jerk by an integer.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator /(AngularJerk x, int y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator /(int x, AngularJerk y)
      {
         return Divide(y, x);
      }

      /// <summary>
      /// Divides an angular jerk by a double.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator /(AngularJerk x, double y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// Divides a double by an angular jerk.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularJerk operator /(double x, AngularJerk y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      /// <summary>
      /// Compares two angular jerks.
      /// </summary>
      /// <param name="x">An angular jerk to compare.</param>
      /// <param name="y">An angular jerk to compare.</param>
      /// <returns>The comparison result of two angular jerks.</returns>
      public static bool operator >(AngularJerk x, AngularJerk y)
      {
         return x.CompareTo(y) > 0;
      }

      /// <summary>
      /// Compares two angular jerks.
      /// </summary>
      /// <param name="x">An angular jerk to compare.</param>
      /// <param name="y">An angular jerk to compare.</param>
      /// <returns>The comparison result of two angular jerks.</returns>
      public static bool operator <(AngularJerk x, AngularJerk y)
      {
         return x.CompareTo(y) < 0;
      }

      /// <summary>
      /// Compares two angular jerks.
      /// </summary>
      /// <param name="x">An angular jerk to compare.</param>
      /// <param name="y">An angular jerk to compare.</param>
      /// <returns>The comparison result of two angular jerks.</returns>
      public static bool operator >=(AngularJerk x, AngularJerk y)
      {
         return x.CompareTo(y) >= 0;
      }

      /// <summary>
      /// Compares two angular jerks.
      /// </summary>
      /// <param name="x">An angular jerk to compare.</param>
      /// <param name="y">An angular jerk to compare.</param>
      /// <returns>The comparison result of two angular jerks.</returns>
      public static bool operator <=(AngularJerk x, AngularJerk y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Jerk>

      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(AngularJerk other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<Jerk>
   }
}