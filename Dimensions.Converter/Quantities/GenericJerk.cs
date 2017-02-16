

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of Generic Jerk.
   /// </summary>
   
   public class GenericJerk : PhysicalQuantityBase, IUnitConvertable<GenericJerk, GenericJerkUnit>, IComparable<GenericJerk>
   {
      #region static convenience properties

      private static readonly GenericJerkUnit UnitsPerCubicSecondUnit = new GenericJerkUnit(new GenericUnit(), Time.Second);

      /// <summary>
      /// Gets a unit for units per cubic second.
      /// </summary>
      public static GenericJerkUnit UnitsPerCubicSecond
      {
         get { return UnitsPerCubicSecondUnit; }
      }

      #endregion static convenience properties

      /// <summary>
      /// Creates a new instance of generic jerk.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public GenericJerk(double value, GenericJerkUnit unit)
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

      #region Implementation of IUnitConvertible<GenericJerk,GenericJerkUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public GenericJerk ConvertTo(GenericJerkUnit newUnit)
      {
         return (GenericJerk)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertible<GenericJerk,GenericJerkUnit>

      #region operator +

      /// <summary>
      /// Performs an add operation on two jerks.
      /// </summary>
      /// <param name="x">A jerk to perform the add operation on.</param>
      /// <param name="y">Another jerk to perform the add operation on.</param>
      /// <returns>The sum of two jerks.</returns>
      public static GenericJerk operator +(GenericJerk x, GenericJerk y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Performs an add operation on a jerk and an integer.
      /// </summary>
      /// <param name="x">A jerk to perform the add operation on.</param>
      /// <param name="y">An integer the add operation on.</param>
      /// <returns>The sum of a jerk and an integer.</returns>
      public static GenericJerk operator +(GenericJerk x, int y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Performs an add operation on a jerk and an integer.
      /// </summary>
      /// <param name="x">An integer the add operation on.</param>
      /// <param name="y">A jerk to perform the add operation on.</param>
      /// <returns>The sum of a jerk and an integer.</returns>
      public static GenericJerk operator +(int x, GenericJerk y)
      {
         return Add(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericJerk operator +(double x, GenericJerk y)
      {
         return Add(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericJerk operator +(GenericJerk x, double y)
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
      public static GenericJerk operator -(GenericJerk x, GenericJerk y)
      {
         return Subtract(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericJerk operator -(int x, GenericJerk y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericJerk operator -(GenericJerk x, int y)
      {
         return Subtract(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericJerk operator -(double x, GenericJerk y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericJerk operator -(GenericJerk x, double y)
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
      public static GenericJerk operator *(GenericJerk x, GenericJerk y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericJerk operator *(GenericJerk x, int y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericJerk operator *(int x, GenericJerk y)
      {
         return Multiply(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericJerk operator *(GenericJerk x, double y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericJerk operator *(double x, GenericJerk y)
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
      public static GenericJerk operator /(GenericJerk x, GenericJerk y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericJerk operator /(GenericJerk x, int y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericJerk operator /(int x, GenericJerk y)
      {
         return Divide(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericJerk operator /(GenericJerk x, double y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericJerk operator /(double x, GenericJerk y)
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
      public static bool operator >(GenericJerk x, GenericJerk y)
      {
         return x.CompareTo(y) > 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(GenericJerk x, GenericJerk y)
      {
         return x.CompareTo(y) < 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(GenericJerk x, GenericJerk y)
      {
         return x.CompareTo(y) >= 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(GenericJerk x, GenericJerk y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<GenericJerk>

      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(GenericJerk other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<GenericJerk>
   }
}