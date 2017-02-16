


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// The physical dimension of density.
   /// </summary>
   
   public class Density : PhysicalQuantityBase, IUnitConvertable<Density, DensitiyUnit>, IComparable<Density>
   {
      #region static convenience properties

      private static readonly DensitiyUnit KilogramPerCubicMeterUnit = new DensitiyUnit(Mass.Kilogram, Volume.CubicMeter);
      private static readonly DensitiyUnit KilogramPerCubicDecimeterUnit = new DensitiyUnit(Mass.Kilogram, Volume.CubicDecimeter);
      private static readonly DensitiyUnit GramPerCubicCentimeterUnit = new DensitiyUnit(Mass.Gram, Volume.CubicCentimeter);

      /// <summary>
      /// Gets a unit of 1 kilogram per cubic meter
      /// </summary>
      public static DensitiyUnit KilogramPerCubicMeter
      {
         get { return KilogramPerCubicMeterUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 kilogram per cubic decimeter
      /// </summary>
      public static DensitiyUnit KilogramPerCubicDecimeter
      {
         get { return KilogramPerCubicDecimeterUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 gram per cubic centimeter
      /// </summary>
      public static DensitiyUnit GramPerCubicCentimeter
      {
         get { return GramPerCubicCentimeterUnit; }
      }

      #endregion

      /// <summary>
      /// Creates a new instance of density.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public Density(double value, DensitiyUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameDensity; }
      }


      /// <summary>
      /// Gets an enumeration value this dimension represents.
      /// </summary>
      /// <value>Quantity.Density</value>
      public override Quantity Dimension
      {
         get { return Quantity.Density; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<Density,DensitiyUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Density ConvertTo(DensitiyUnit newUnit)
      {
         return (Density)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertable<Density,DensitiyUnit>

      #region operator +

      public static Density operator +(Density x, Density y)
      {
         return Add(x, y);
      }

      public static Density operator +(Density x, int y)
      {
         return Add(x, y);
      }

      public static Density operator +(int x, Density y)
      {
         return Add(y, x);
      }

      public static Density operator +(double x, Density y)
      {
         return Add(y, x);
      }

      public static Density operator +(Density x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static Density operator -(Density x, Density y)
      {
         return Subtract(x, y);
      }

      public static Density operator -(int x, Density y)
      {
         return Subtract(y, x);
      }

      public static Density operator -(Density x, int y)
      {
         return Subtract(x, y);
      }

      public static Density operator -(double x, Density y)
      {
         return Subtract(y, x);
      }

      public static Density operator -(Density x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static Density operator *(Density x, Density y)
      {
         return Multiply(x, y);
      }

      public static Density operator *(Density x, int y)
      {
         return Multiply(x, y);
      }

      public static Density operator *(int x, Density y)
      {
         return Multiply(y, x);
      }

      public static Density operator *(Density x, double y)
      {
         return Multiply(x, y);
      }

      public static Density operator *(double x, Density y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static Density operator /(Density x, Density y)
      {
         return Divide(x, y);
      }

      public static Density operator /(Density x, int y)
      {
         return Divide(x, y);
      }

      public static Density operator /(int x, Density y)
      {
         return Divide(y, x);
      }

      public static Density operator /(Density x, double y)
      {
         return Divide(x, y);
      }

      public static Density operator /(double x, Density y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(Density x, Density y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(Density x, Density y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(Density x, Density y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(Density x, Density y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Density>

      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Density other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}