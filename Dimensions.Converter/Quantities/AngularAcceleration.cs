


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of angular acceleration.
   /// </summary>
   
   public class AngularAcceleration : PhysicalQuantityBase, IUnitConvertable<AngularAcceleration, AngularAccelerationUnit>, IComparable<AngularAcceleration>
   {
      #region static convenience properties

      private static readonly AngularAccelerationUnit DegreePerSquareSecondUnit = new AngularAccelerationUnit(PlaneAngle.Degree, Time.Second);
      private static readonly AngularAccelerationUnit RadPerSquareSecondUnit = new AngularAccelerationUnit(PlaneAngle.Rad, Time.Second);

      /// <summary>
      /// Gets a unit for meters per square second.
      /// </summary>

      public static AngularAccelerationUnit DegreePerSquareSecond
      {
         get { return DegreePerSquareSecondUnit; }
      }

      /// <summary>
      /// Gets a unit for inch per square second.
      /// </summary>
      public static AngularAccelerationUnit RadPerSquareSecond
      {
         get { return RadPerSquareSecondUnit; }
      }

      #endregion static convenience properties

      /// <summary>
      /// Creates a new instance of Acceleration.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public AngularAcceleration(double value, AngularAccelerationUnit unit)
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
      public AngularAcceleration ConvertTo(AngularAccelerationUnit newUnit)
      {
         return (AngularAcceleration)base.ConvertTo(newUnit);

         ////Acceleration a = new Acceleration(this.Value, (AccelerationUnit)this.Unit);
         ////a.ConvertToInternal(newUnit);

         ////return a;
      }

      #endregion Implementation of IUnitConvertible<Acceleration,AccelerationUnit>

      #region operator +

      public static AngularAcceleration operator +(AngularAcceleration x, AngularAcceleration y)
      {
         return Add(x, y);
      }

      public static AngularAcceleration operator +(AngularAcceleration x, int y)
      {
         return Add(x, y);
      }

      public static AngularAcceleration operator +(int x, AngularAcceleration y)
      {
         return Add(y, x);
      }

      public static AngularAcceleration operator +(double x, AngularAcceleration y)
      {
         return Add(y, x);
      }

      public static AngularAcceleration operator +(AngularAcceleration x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static AngularAcceleration operator -(AngularAcceleration x, AngularAcceleration y)
      {
         return Subtract(x, y);
      }

      public static AngularAcceleration operator -(int x, AngularAcceleration y)
      {
         return Subtract(y, x);
      }

      public static AngularAcceleration operator -(AngularAcceleration x, int y)
      {
         return Subtract(x, y);
      }

      public static AngularAcceleration operator -(double x, AngularAcceleration y)
      {
         return Subtract(y, x);
      }

      public static AngularAcceleration operator -(AngularAcceleration x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static AngularAcceleration operator *(AngularAcceleration x, AngularAcceleration y)
      {
         return Multiply(x, y);
      }

      public static AngularAcceleration operator *(AngularAcceleration x, int y)
      {
         return Multiply(x, y);
      }

      public static AngularAcceleration operator *(int x, AngularAcceleration y)
      {
         return Multiply(y, x);
      }

      public static AngularAcceleration operator *(AngularAcceleration x, double y)
      {
         return Multiply(x, y);
      }

      public static AngularAcceleration operator *(double x, AngularAcceleration y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static AngularAcceleration operator /(AngularAcceleration x, AngularAcceleration y)
      {
         return Divide(x, y);
      }

      public static AngularAcceleration operator /(AngularAcceleration x, int y)
      {
         return Divide(x, y);
      }

      public static AngularAcceleration operator /(int x, AngularAcceleration y)
      {
         return Divide(y, x);
      }

      public static AngularAcceleration operator /(AngularAcceleration x, double y)
      {
         return Divide(x, y);
      }

      public static AngularAcceleration operator /(double x, AngularAcceleration y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(AngularAcceleration x, AngularAcceleration y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(AngularAcceleration x, AngularAcceleration y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(AngularAcceleration x, AngularAcceleration y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(AngularAcceleration x, AngularAcceleration y)
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
      public int CompareTo(AngularAcceleration other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<Acceleration>
   }
}