

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// The physical dimension of angular speed.
   /// </summary>
   
   public class AngularSpeed : PhysicalQuantityBase, IUnitConvertable<AngularSpeed, AngularSpeedUnit>, IComparable<AngularSpeed>
   {
      #region public convenience properties

      private static readonly RotationalSpeedUnit RevolutionsPerSecondUnit = new RotationalSpeedUnit(Time.Second);
      private static readonly RotationalSpeedUnit RevolutionsPerMinuteUnit = new RotationalSpeedUnit(Time.Minute);

      /// <summary>
      /// Gets a unit for number of revolutions per second
      /// </summary>
      public static RotationalSpeedUnit RevolutionsPerSecond
      {
         get { return RevolutionsPerSecondUnit; }
      }

      /// <summary>
      /// Gets a unit for number of revolutions per minute
      /// </summary>
      public static RotationalSpeedUnit RevolutionsPerMinute
      {
         get { return RevolutionsPerMinuteUnit; }
      }

      #endregion public convenience properties

      /// <summary>
      /// Creates a new instance of angular speed.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public AngularSpeed(double value, AngularSpeedUnit unit)
         : base(value, unit)
      {
      }

      /// <summary>
      /// Creates a new instance of angular speed.
      /// </summary>
      /// <param name="angle">An instance of an angle.</param>
      /// <param name="time">An instance of time.</param>
      public AngularSpeed(PlaneAngle angle, Time time)
         : base(angle.Value / time.Value, new AngularSpeedUnit((PlaneAngleUnit)angle.Unit, (TimeUnit)time.Unit))
      { }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameAngularSpeed; }
      }

      /// <summary>
      /// Gets an enumeration value for angluar speed.
      /// </summary>
      /// <value><see cref="Quantity.AngularSpeed"/></value>
      public override Quantity Dimension
      {
         get { return Quantity.AngularSpeed; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<RotationalSpeed,RotationalSpeedUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public AngularSpeed ConvertTo(AngularSpeedUnit newUnit)
      {
         return (RotationalSpeed)base.ConvertTo(newUnit);
      }

      #region operator +

      public static AngularSpeed operator +(AngularSpeed x, AngularSpeed y)
      {
         return Add(x, y);
      }

      public static AngularSpeed operator +(AngularSpeed x, int y)
      {
         return Add(x, y);
      }

      public static AngularSpeed operator +(int x, AngularSpeed y)
      {
         return Add(y, x);
      }

      public static AngularSpeed operator +(double x, AngularSpeed y)
      {
         return Add(y, x);
      }

      public static AngularSpeed operator +(AngularSpeed x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static AngularSpeed operator -(AngularSpeed x, AngularSpeed y)
      {
         return Subtract(x, y);
      }

      public static AngularSpeed operator -(int x, AngularSpeed y)
      {
         return Subtract(y, x);
      }

      public static AngularSpeed operator -(AngularSpeed x, int y)
      {
         return Subtract(x, y);
      }

      public static AngularSpeed operator -(double x, AngularSpeed y)
      {
         return Subtract(y, x);
      }

      public static AngularSpeed operator -(AngularSpeed x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static AngularSpeed operator *(AngularSpeed x, AngularSpeed y)
      {
         return Multiply(x, y);
      }

      public static AngularSpeed operator *(AngularSpeed x, int y)
      {
         return Multiply(x, y);
      }

      public static AngularSpeed operator *(int x, AngularSpeed y)
      {
         return Multiply(y, x);
      }

      public static AngularSpeed operator *(AngularSpeed x, double y)
      {
         return Multiply(x, y);
      }

      public static AngularSpeed operator *(double x, AngularSpeed y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static AngularSpeed operator /(AngularSpeed x, AngularSpeed y)
      {
         return Divide(x, y);
      }

      public static AngularSpeed operator /(AngularSpeed x, int y)
      {
         return Divide(x, y);
      }

      public static AngularSpeed operator /(int x, AngularSpeed y)
      {
         return Divide(y, x);
      }

      public static AngularSpeed operator /(AngularSpeed x, double y)
      {
         return Divide(x, y);
      }

      public static AngularSpeed operator /(double x, AngularSpeed y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      #endregion Implementation of IUnitConvertable<RotationalSpeed,RotationalSpeedUnit>

      public static bool operator >(AngularSpeed x, AngularSpeed y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(AngularSpeed x, AngularSpeed y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(AngularSpeed x, AngularSpeed y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(AngularSpeed x, AngularSpeed y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<AngularSpeed>

      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(AngularSpeed other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<AngularSpeed>
   }
}