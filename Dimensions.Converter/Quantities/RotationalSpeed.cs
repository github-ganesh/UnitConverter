


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// The physical dimension of speed.
   /// </summary>
   
   public class RotationalSpeed : AngularSpeed, IUnitConvertable<RotationalSpeed, RotationalSpeedUnit>, IComparable<RotationalSpeed>
   {

      /// <summary>
      /// Creates a new instance of speed.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public RotationalSpeed(double value, RotationalSpeedUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameRotationalSpeed; }
      }


      /// <summary>
      /// Gets an enumeration value for speed.
      /// </summary>
      /// <value><see cref="Quantity.RotationalSpeed"/></value>
      public override Quantity Dimension
      {
         get { return Quantity.RotationalSpeed; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<RotationalSpeed,RotationalSpeedUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public RotationalSpeed ConvertTo(RotationalSpeedUnit newUnit)
      {
         return (RotationalSpeed)base.ConvertTo(newUnit);
      }

      #endregion

      #region operator +
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator +(RotationalSpeed x, RotationalSpeed y)
      {
         return Add(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator +(RotationalSpeed x, int y)
      {
         return Add(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator +(int x, RotationalSpeed y)
      {
         return Add(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator +(double x, RotationalSpeed y)
      {
         return Add(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator +(RotationalSpeed x, double y)
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
      public static RotationalSpeed operator -(RotationalSpeed x, RotationalSpeed y)
      {
         return Subtract(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator -(int x, RotationalSpeed y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator -(RotationalSpeed x, int y)
      {
         return Subtract(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator -(double x, RotationalSpeed y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator -(RotationalSpeed x, double y)
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
      public static RotationalSpeed operator *(RotationalSpeed x, RotationalSpeed y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator *(RotationalSpeed x, int y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator *(int x, RotationalSpeed y)
      {
         return Multiply(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator *(RotationalSpeed x, double y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator *(double x, RotationalSpeed y)
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
      public static RotationalSpeed operator /(RotationalSpeed x, RotationalSpeed y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator /(RotationalSpeed x, int y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator /(int x, RotationalSpeed y)
      {
         return Divide(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator /(RotationalSpeed x, double y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static RotationalSpeed operator /(double x, RotationalSpeed y)
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
      public static bool operator >(RotationalSpeed x, RotationalSpeed y)
      {
         return x.CompareTo(y) > 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(RotationalSpeed x, RotationalSpeed y)
      {
         return x.CompareTo(y) < 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(RotationalSpeed x, RotationalSpeed y)
      {
         return x.CompareTo(y) >= 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(RotationalSpeed x, RotationalSpeed y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Speed>

      /// <summary>
      /// Compares the RotationalSpeed object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(RotationalSpeed other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}