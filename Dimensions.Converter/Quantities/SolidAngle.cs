

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of solid angle.
   /// </summary>
   
   public class SolidAngle : PhysicalQuantityBase, IUnitConvertable<SolidAngle, SolidAngleUnit>, IComparable<SolidAngle>
   {
      #region public convenience properties

      private static readonly SolidAngleUnit SteradiantUnit = new Steradiant();

      /// <summary>
      /// Gets the angle unit of 1 Steradiant.
      /// </summary>
      public static SolidAngleUnit Steradiant
      {
         get { return SteradiantUnit; }
      }

      #endregion public convenience properties

      /// <summary>
      /// Creates a new instance for a solid angle unit.
      /// </summary>
      /// <param name="value">The numeric value of the length in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit of the length.</param>
      public SolidAngle(double value, SolidAngleUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameSolidAngle; }
      }

      /// <summary>
      /// Gets an enumeration value for solid angle.
      /// </summary>
      public override Quantity Dimension
      {
         get { return Quantity.SolidAngle; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<SolidAngle,SolidAngleUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public SolidAngle ConvertTo(SolidAngleUnit newUnit)
      {
         return (SolidAngle)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertable<SolidAngle,SolidAngleUnit>

      #region operator +

      /// <summary>
      /// Adds two solid angles.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator +(SolidAngle x, SolidAngle y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Adds a solid angle to an integer.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator +(SolidAngle x, int y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Adds a solid angle to an integer.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator +(int x, SolidAngle y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// Adds a solid angle to a double.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator +(double x, SolidAngle y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// Adds a solid angle to a double.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator +(SolidAngle x, double y)
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
      public static SolidAngle operator -(SolidAngle x, SolidAngle y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator -(int x, SolidAngle y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator -(SolidAngle x, int y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator -(double x, SolidAngle y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator -(SolidAngle x, double y)
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
      public static SolidAngle operator *(SolidAngle x, SolidAngle y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator *(SolidAngle x, int y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator *(int x, SolidAngle y)
      {
         return Multiply(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator *(SolidAngle x, double y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator *(double x, SolidAngle y)
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
      public static SolidAngle operator /(SolidAngle x, SolidAngle y)
      {
         return Divide(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator /(SolidAngle x, int y)
      {
         return Divide(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator /(int x, SolidAngle y)
      {
         return Divide(y, x);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator /(SolidAngle x, double y)
      {
         return Divide(x, y);
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static SolidAngle operator /(double x, SolidAngle y)
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
      public static bool operator >(SolidAngle x, SolidAngle y)
      {
         return x.CompareTo(y) > 0;
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(SolidAngle x, SolidAngle y)
      {
         return x.CompareTo(y) < 0;
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(SolidAngle x, SolidAngle y)
      {
         return x.CompareTo(y) >= 0;
      }

      /// <summary>
      ///
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(SolidAngle x, SolidAngle y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<SolidAngle>

      /// <summary>
      /// Compares the SolidAngle object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(SolidAngle other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<SolidAngle>
   }
}