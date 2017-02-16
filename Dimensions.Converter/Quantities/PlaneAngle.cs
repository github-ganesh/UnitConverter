

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of PlaneAngle.
   /// </summary>
   
   public class PlaneAngle : PhysicalQuantityBase, IUnitConvertable<PlaneAngle, PlaneAngleUnit>, IComparable<PlaneAngle>
   {
      #region public convenience properties

      private static readonly PlaneAngleUnit RadUnit = new Rad();
      private static readonly PlaneAngleUnit DegreeUnit = new AngleDegree();

      /// <summary>
      /// Gets the angle unit of 1 rad.
      /// </summary>
      public static PlaneAngleUnit Rad
      {
         get { return RadUnit; }
      }

      /// <summary>
      /// Gets the angle unit of 1 degree.
      /// </summary>
      public static PlaneAngleUnit Degree
      {
         get { return DegreeUnit; }
      }

      #endregion public convenience properties

      /// <summary>
      /// Creates a new instance for a plane angle unit.
      /// </summary>
      /// <param name="value">The numeric value of the length in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit of the length.</param>
      public PlaneAngle(double value, PlaneAngleUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NamePlaneAngle; }
      }

      /// <summary>
      /// Gets an enumeration value for plane angle.
      /// </summary>
      public override Quantity Dimension
      {
         get { return Quantity.Angle; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<PlaneAngle,PlaneAngleUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public PlaneAngle ConvertTo(PlaneAngleUnit newUnit)
      {
         return (PlaneAngle)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertable<PlaneAngle,PlaneAngleUnit>

      #region operator +

      public static PlaneAngle operator +(PlaneAngle x, PlaneAngle y)
      {
         return Add(x, y);
      }

      public static PlaneAngle operator +(PlaneAngle x, int y)
      {
         return Add(x, y);
      }

      public static PlaneAngle operator +(int x, PlaneAngle y)
      {
         return Add(y, x);
      }

      public static PlaneAngle operator +(double x, PlaneAngle y)
      {
         return Add(y, x);
      }

      public static PlaneAngle operator +(PlaneAngle x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static PlaneAngle operator -(PlaneAngle x, PlaneAngle y)
      {
         return Subtract(x, y);
      }

      public static PlaneAngle operator -(int x, PlaneAngle y)
      {
         return Subtract(y, x);
      }

      public static PlaneAngle operator -(PlaneAngle x, int y)
      {
         return Subtract(x, y);
      }

      public static PlaneAngle operator -(double x, PlaneAngle y)
      {
         return Subtract(y, x);
      }

      public static PlaneAngle operator -(PlaneAngle x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static PlaneAngle operator *(PlaneAngle x, PlaneAngle y)
      {
         return Multiply(x, y);
      }

      public static PlaneAngle operator *(PlaneAngle x, int y)
      {
         return Multiply(x, y);
      }

      public static PlaneAngle operator *(int x, PlaneAngle y)
      {
         return Multiply(y, x);
      }

      public static PlaneAngle operator *(PlaneAngle x, double y)
      {
         return Multiply(x, y);
      }

      public static PlaneAngle operator *(double x, PlaneAngle y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static PlaneAngle operator /(PlaneAngle x, PlaneAngle y)
      {
         return Divide(x, y);
      }

      public static PlaneAngle operator /(PlaneAngle x, int y)
      {
         return Divide(x, y);
      }

      public static PlaneAngle operator /(int x, PlaneAngle y)
      {
         return Divide(y, x);
      }

      public static PlaneAngle operator /(PlaneAngle x, double y)
      {
         return Divide(x, y);
      }

      public static PlaneAngle operator /(double x, PlaneAngle y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(PlaneAngle x, PlaneAngle y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(PlaneAngle x, PlaneAngle y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(PlaneAngle x, PlaneAngle y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(PlaneAngle x, PlaneAngle y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<PlaneAngle>

      /// <summary>
      /// Compares the PlaneAngle object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(PlaneAngle other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<PlaneAngle>
   }
}