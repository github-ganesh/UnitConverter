


using System;


using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of Jerk.
   /// </summary>
   
   public class Jerk<T> : PhysicalQuantityBase, IUnitConvertable<Jerk<T>, JerkUnit<T>>, IComparable<Jerk<T>> where T : PhysicalQuantityBase
   {
      /// <summary>
      /// Creates a new instance of Acceleration.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public Jerk(double value, JerkUnit<T> unit)
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

      #region Implementation of IUnitConvertible<Jerk<T>,JerkUnit<T>>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Jerk<T> ConvertTo(JerkUnit<T> newUnit)
      {
         return (Jerk<T>)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertible<Jerk<T>,JerkUnit<T>>

      #region operator +

      /// <summary>
      /// Performs an add operation on two jerks.
      /// </summary>
      /// <param name="x">A jerk to perform the add operation on.</param>
      /// <param name="y">Another jerk to perform the add operation on.</param>
      /// <returns>The sum of two jerks.</returns>
      public static Jerk<T> operator +(Jerk<T> x, Jerk<T> y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Performs an add operation on a jerk and an integer.
      /// </summary>
      /// <param name="x">A jerk to perform the add operation on.</param>
      /// <param name="y">An integer the add operation on.</param>
      /// <returns>The sum of a jerk and an integer.</returns>
      public static Jerk<T> operator +(Jerk<T> x, int y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Performs an add operation on a jerk and an integer.
      /// </summary>
      /// <param name="x">An integer the add operation on.</param>
      /// <param name="y">A jerk to perform the add operation on.</param>
      /// <returns>The sum of a jerk and an integer.</returns>
      public static Jerk<T> operator +(int x, Jerk<T> y)
      {
         return Add(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Jerk<T> operator +(double x, Jerk<T> y)
      {
         return Add(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Jerk<T> operator +(Jerk<T> x, double y)
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
      public static Jerk<T> operator -(Jerk<T> x, Jerk<T> y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Jerk<T> operator -(int x, Jerk<T> y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Jerk<T> operator -(Jerk<T> x, int y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Jerk<T> operator -(double x, Jerk<T> y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Jerk<T> operator -(Jerk<T> x, double y)
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
      public static Jerk<T> operator *(Jerk<T> x, Jerk<T> y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Jerk<T> operator *(Jerk<T> x, int y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Jerk<T> operator *(int x, Jerk<T> y)
      {
         return Multiply(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Jerk<T> operator *(Jerk<T> x, double y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Jerk<T> operator *(double x, Jerk<T> y)
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
      public static Jerk<T> operator /(Jerk<T> x, Jerk<T> y)
      {
         return Divide(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Jerk<T> operator /(Jerk<T> x, int y)
      {
         return Divide(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Jerk<T> operator /(int x, Jerk<T> y)
      {
         return Divide(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Jerk<T> operator /(Jerk<T> x, double y)
      {
         return Divide(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Jerk<T> operator /(double x, Jerk<T> y)
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
      public static bool operator >(Jerk<T> x, Jerk<T> y)
      {
         return x.CompareTo(y) > 0;
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(Jerk<T> x, Jerk<T> y)
      {
         return x.CompareTo(y) < 0;
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>v
      public static bool operator >=(Jerk<T> x, Jerk<T> y)
      {
         return x.CompareTo(y) >= 0;
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(Jerk<T> x, Jerk<T> y)
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
      public int CompareTo(Jerk<T> other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<Acceleration>
   }
}