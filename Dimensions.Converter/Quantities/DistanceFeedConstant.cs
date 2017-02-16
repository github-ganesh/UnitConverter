


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Describes a feed constant that is based on distance per rotation.
   /// </summary>
   
   public class DistanceFeedConstant : PhysicalQuantityBase, IUnitConvertable<DistanceFeedConstant, DistanceFeedConstantUnit>, IComparable<DistanceFeedConstant>
   {
      #region static convenience properties

      private static readonly DistanceFeedConstantUnit MillimeterPerRotationUnit = new DistanceFeedConstantUnit(Length.Millimeter, new RotationUnit());

      /// <summary>
      /// Gets a distance feed constant unit of 1 mm per rotation.
      /// </summary>
      public static DistanceFeedConstantUnit MillimeterPerRotation
      {
         get { return MillimeterPerRotationUnit; }
      }

      #endregion

      /// <summary>
      /// Base constructor for all physical quantities.
      /// </summary>
      /// <param name="value">The numerical value of the physical quantity in the given unit.</param>
      /// <param name="unit">The unit of the quantity.</param>
      public DistanceFeedConstant(double value, DistanceFeedConstantUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantityBase

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameDistanceFeedConstant; }
      }

      /// <summary>
      /// Gets an enumeration value this dimension represents.
      /// </summary>
      public override Quantity Dimension
      {
         get { return Quantity.DistanceFeedConstant; }
      }

      #endregion Overrides of PhysicalQuantityBase

      #region Implementation of IUnitConvertable<DistanceFeedConstant,DensitiyUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public DistanceFeedConstant ConvertTo(DistanceFeedConstantUnit newUnit)
      {
         return (DistanceFeedConstant)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertable<DistanceFeedConstant,DensitiyUnit>

      #region Implementation of IComparable<in DistanceFeedConstant>

      /// <summary>
      /// Compares the DistanceFeedConstant object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(DistanceFeedConstant other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<in DistanceFeedConstant>

      #region operator +

      public static DistanceFeedConstant operator +(DistanceFeedConstant x, DistanceFeedConstant y)
      {
         return Add(x, y);
      }

      public static DistanceFeedConstant operator +(DistanceFeedConstant x, int y)
      {
         return Add(x, y);
      }

      public static DistanceFeedConstant operator +(int x, DistanceFeedConstant y)
      {
         return Add(y, x);
      }

      public static DistanceFeedConstant operator +(double x, DistanceFeedConstant y)
      {
         return Add(y, x);
      }

      public static DistanceFeedConstant operator +(DistanceFeedConstant x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static DistanceFeedConstant operator -(DistanceFeedConstant x, DistanceFeedConstant y)
      {
         return Subtract(x, y);
      }

      public static DistanceFeedConstant operator -(int x, DistanceFeedConstant y)
      {
         return Subtract(y, x);
      }

      public static DistanceFeedConstant operator -(DistanceFeedConstant x, int y)
      {
         return Subtract(x, y);
      }

      public static DistanceFeedConstant operator -(double x, DistanceFeedConstant y)
      {
         return Subtract(y, x);
      }

      public static DistanceFeedConstant operator -(DistanceFeedConstant x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static DistanceFeedConstant operator *(DistanceFeedConstant x, DistanceFeedConstant y)
      {
         return Multiply(x, y);
      }

      public static DistanceFeedConstant operator *(DistanceFeedConstant x, int y)
      {
         return Multiply(x, y);
      }

      public static DistanceFeedConstant operator *(int x, DistanceFeedConstant y)
      {
         return Multiply(y, x);
      }

      public static DistanceFeedConstant operator *(DistanceFeedConstant x, double y)
      {
         return Multiply(x, y);
      }

      public static DistanceFeedConstant operator *(double x, DistanceFeedConstant y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static DistanceFeedConstant operator /(DistanceFeedConstant x, DistanceFeedConstant y)
      {
         return Divide(x, y);
      }

      public static DistanceFeedConstant operator /(DistanceFeedConstant x, int y)
      {
         return Divide(x, y);
      }

      public static DistanceFeedConstant operator /(int x, DistanceFeedConstant y)
      {
         return Divide(y, x);
      }

      public static DistanceFeedConstant operator /(DistanceFeedConstant x, double y)
      {
         return Divide(x, y);
      }

      public static DistanceFeedConstant operator /(double x, DistanceFeedConstant y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(DistanceFeedConstant x, DistanceFeedConstant y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(DistanceFeedConstant x, DistanceFeedConstant y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(DistanceFeedConstant x, DistanceFeedConstant y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(DistanceFeedConstant x, DistanceFeedConstant y)
      {
         return x.CompareTo(y) <= 0;
      }
   }
}