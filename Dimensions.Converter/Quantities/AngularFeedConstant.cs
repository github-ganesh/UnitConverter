

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Describes a feed constant that is based on angle per rotation.
   /// </summary>
   
   public class AngularFeedConstant : PhysicalQuantityBase, IUnitConvertable<AngularFeedConstant, AngularFeedConstantUnit>, IComparable<AngularFeedConstant>
   {
      #region static convenience properties

      private static readonly AngularFeedConstantUnit DegreePerRotationUnit = new AngularFeedConstantUnit(PlaneAngle.Degree, new RotationUnit());

      /// <summary>
      /// Gets a distance feed constant unit of 1 degree per rotation.
      /// </summary>
      public static AngularFeedConstantUnit DegreePerRotation
      {
         get { return DegreePerRotationUnit; }
      }

      #endregion

      /// <summary>
      /// Base constructor for all physical quantities.
      /// </summary>
      /// <param name="value">The numerical value of the physical quantity in the given unit.</param>
      /// <param name="unit">The unit of the quantity.</param>
      public AngularFeedConstant(double value, AngularFeedConstantUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantityBase

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameAngularFeedConstant; }
      }

      /// <summary>
      /// Gets an enumeration value this dimension represents.
      /// </summary>
      public override Quantity Dimension
      {
         get { return Quantity.AngularFeedConstant; }
      }

      #endregion Overrides of PhysicalQuantityBase

      #region Implementation of IUnitConvertable<AngularFeedConstant,DensitiyUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public AngularFeedConstant ConvertTo(AngularFeedConstantUnit newUnit)
      {
         return (AngularFeedConstant)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertable<AngularFeedConstant,DensitiyUnit>

      #region Implementation of IComparable<in AngularFeedConstant>

      /// <summary>
      /// Compares the AngularFeedConstant object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(AngularFeedConstant other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<in AngularFeedConstant>

      #region operator +

      /// <summary>
      /// Adds two angular feed constants.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularFeedConstant operator +(AngularFeedConstant x, AngularFeedConstant y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Adds an angular feed constant with an integer.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularFeedConstant operator +(AngularFeedConstant x, int y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Adds an angular feed constant with an integer.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularFeedConstant operator +(int x, AngularFeedConstant y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// Adds an angular feed constant with a double.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularFeedConstant operator +(double x, AngularFeedConstant y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// Adds an angular feed constant with a double.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static AngularFeedConstant operator +(AngularFeedConstant x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static AngularFeedConstant operator -(AngularFeedConstant x, AngularFeedConstant y)
      {
         return Subtract(x, y);
      }

      public static AngularFeedConstant operator -(int x, AngularFeedConstant y)
      {
         return Subtract(y, x);
      }

      public static AngularFeedConstant operator -(AngularFeedConstant x, int y)
      {
         return Subtract(x, y);
      }

      public static AngularFeedConstant operator -(double x, AngularFeedConstant y)
      {
         return Subtract(y, x);
      }

      public static AngularFeedConstant operator -(AngularFeedConstant x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static AngularFeedConstant operator *(AngularFeedConstant x, AngularFeedConstant y)
      {
         return Multiply(x, y);
      }

      public static AngularFeedConstant operator *(AngularFeedConstant x, int y)
      {
         return Multiply(x, y);
      }

      public static AngularFeedConstant operator *(int x, AngularFeedConstant y)
      {
         return Multiply(y, x);
      }

      public static AngularFeedConstant operator *(AngularFeedConstant x, double y)
      {
         return Multiply(x, y);
      }

      public static AngularFeedConstant operator *(double x, AngularFeedConstant y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static AngularFeedConstant operator /(AngularFeedConstant x, AngularFeedConstant y)
      {
         return Divide(x, y);
      }

      public static AngularFeedConstant operator /(AngularFeedConstant x, int y)
      {
         return Divide(x, y);
      }

      public static AngularFeedConstant operator /(int x, AngularFeedConstant y)
      {
         return Divide(y, x);
      }

      public static AngularFeedConstant operator /(AngularFeedConstant x, double y)
      {
         return Divide(x, y);
      }

      public static AngularFeedConstant operator /(double x, AngularFeedConstant y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(AngularFeedConstant x, AngularFeedConstant y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(AngularFeedConstant x, AngularFeedConstant y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(AngularFeedConstant x, AngularFeedConstant y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(AngularFeedConstant x, AngularFeedConstant y)
      {
         return x.CompareTo(y) <= 0;
      }
   }
}