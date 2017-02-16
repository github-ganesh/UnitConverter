

using System;


using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of acceleration.
   /// </summary>
   
   public class Acceleration<T> : PhysicalQuantityBase, IUnitConvertable<Acceleration<T>, AccelerationUnit<T>>, IComparable<Acceleration<T>> where T : PhysicalQuantityBase
   {
      /// <summary>
      /// Creates a new instance of Acceleration.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public Acceleration(double value, AccelerationUnit<T> unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameAcceleration; }
      }

      /// <summary>
      /// Gets an enumeration value for this quantity.
      /// </summary>
      /// <value>Quantity.Acceleration</value>
      public override Quantity Dimension
      {
         get { return Quantity.Acceleration; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertible<Acceleration,AccelerationUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Acceleration<T> ConvertTo(AccelerationUnit<T> newUnit)
      {
         return (Acceleration<T>)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertible<Acceleration,AccelerationUnit>

      #region operator +

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator +(Acceleration<T> x, Acceleration<T> y)
      {
         return Add(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator +(Acceleration<T> x, int y)
      {
         return Add(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator +(int x, Acceleration<T> y)
      {
         return Add(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator +(double x, Acceleration<T> y)
      {
         return Add(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator +(Acceleration<T> x, double y)
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
      public static Acceleration<T> operator -(Acceleration<T> x, Acceleration<T> y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator -(int x, Acceleration<T> y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator -(Acceleration<T> x, int y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator -(double x, Acceleration<T> y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator -(Acceleration<T> x, double y)
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
      public static Acceleration<T> operator *(Acceleration<T> x, Acceleration<T> y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator *(Acceleration<T> x, int y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator *(int x, Acceleration<T> y)
      {
         return Multiply(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator *(Acceleration<T> x, double y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator *(double x, Acceleration<T> y)
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
      public static Acceleration<T> operator /(Acceleration<T> x, Acceleration<T> y)
      {
         return Divide(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator /(Acceleration<T> x, int y)
      {
         return Divide(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator /(int x, Acceleration<T> y)
      {
         return Divide(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator /(Acceleration<T> x, double y)
      {
         return Divide(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Acceleration<T> operator /(double x, Acceleration<T> y)
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
      public static bool operator >(Acceleration<T> x, Acceleration<T> y)
      {
         return x.CompareTo(y) > 0;
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(Acceleration<T> x, Acceleration<T> y)
      {
         return x.CompareTo(y) < 0;
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(Acceleration<T> x, Acceleration<T> y)
      {
         return x.CompareTo(y) >= 0;
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(Acceleration<T> x, Acceleration<T> y)
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
      public int CompareTo(Acceleration<T> other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<Acceleration>
   }
}