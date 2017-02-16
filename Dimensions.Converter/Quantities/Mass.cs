


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// The physical dimension of mass.
   /// Defined in kg.
   /// </summary>
   
   public class Mass : PhysicalQuantityBase, IUnitConvertable<Mass, MassUnit>, IComparable<Mass>
   {
      #region public convenience properties

      private static readonly MassUnit MilligramUnit = new Gram(Multiple.Milli);
      private static readonly MassUnit GramUnit = new Gram();
      private static readonly MassUnit KilogramUnit = new Gram(Multiple.Kilo);
      private static readonly MassUnit TonUnit = new Ton();
      private static readonly MassUnit KiloTonUnit = new Ton(Multiple.Kilo);

      /// <summary>
      /// Gets a unit of 1 Milligram
      /// </summary>
      public static MassUnit Milligram
      {
         get { return MilligramUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 Gram
      /// </summary>
      public static MassUnit Gram
      {
         get { return GramUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 Kilogram. This is the base unit
      /// </summary>
      public static MassUnit Kilogram
      {
         get { return KilogramUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 ton.
      /// </summary>
      public static MassUnit Ton
      {
         get { return TonUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 kilo ton.
      /// </summary>
      public static MassUnit KiloTon
      {
         get { return KiloTonUnit; }
      }

      #endregion

      /// <summary>
      /// Creates a new instance of mass.
      /// </summary>
      /// <param name="value">Numeric value of the dimension.</param>
      /// <param name="unit">The unit of this dimension.</param>
      public Mass(double value, MassUnit unit)
         : base(value, unit)
      {
      }

      /// <summary>
      /// Creates a new instance of a mass quantity based on the volume and density of
      /// a body.
      /// </summary>
      /// <param name="density">The density of the material the body consists of.</param>
      /// <param name="volume">The volume of the body.</param>
      public Mass(Density density, Volume volume)
         : base(density.Value * volume.Value, new MassUnit((DensitiyUnit)density.Unit, (VolumeUnit)volume.Unit))
      {
         
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameMass; }
      }

      /// <summary>
      /// Gets an enumeration value for mass.
      /// </summary>
      public override Quantity Dimension
      {
         get { return Quantity.Mass; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<Mass,MassUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Mass ConvertTo(MassUnit newUnit)
      {
         return (Mass)base.ConvertTo(newUnit);
      }

      #endregion

      #region operator +

      public static Mass operator +(Mass x, Mass y)
      {
         return Add(x, y);
      }

      public static Mass operator +(Mass x, int y)
      {
         return Add(x, y);
      }

      public static Mass operator +(int x, Mass y)
      {
         return Add(y, x);
      }

      public static Mass operator +(double x, Mass y)
      {
         return Add(y, x);
      }

      public static Mass operator +(Mass x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static Mass operator -(Mass x, Mass y)
      {
         return Subtract(x, y);
      }

      public static Mass operator -(int x, Mass y)
      {
         return Subtract(y, x);
      }

      public static Mass operator -(Mass x, int y)
      {
         return Subtract(x, y);
      }

      public static Mass operator -(double x, Mass y)
      {
         return Subtract(y, x);
      }

      public static Mass operator -(Mass x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static Mass operator *(Mass x, Mass y)
      {
         return Multiply(x, y);
      }

      public static Mass operator *(Mass x, int y)
      {
         return Multiply(x, y);
      }

      public static Mass operator *(int x, Mass y)
      {
         return Multiply(y, x);
      }

      public static Mass operator *(Mass x, double y)
      {
         return Multiply(x, y);
      }

      public static Mass operator *(double x, Mass y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static Mass operator /(Mass x, Mass y)
      {
         return Divide(x, y);
      }

      public static Mass operator /(Mass x, int y)
      {
         return Divide(x, y);
      }

      public static Mass operator /(int x, Mass y)
      {
         return Divide(y, x);
      }

      public static Mass operator /(Mass x, double y)
      {
         return Divide(x, y);
      }

      public static Mass operator /(double x, Mass y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(Mass x, Mass y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(Mass x, Mass y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(Mass x, Mass y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(Mass x, Mass y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Mass>

      /// <summary>
      /// Compares the Mass object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Mass other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}