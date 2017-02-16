

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of Volume.
   /// </summary>
   
   public class Volume : PhysicalQuantityBase, IUnitConvertable<Volume, VolumeUnit>, IComparable<Volume>
   {
      #region public convenience properties

      private static readonly VolumeUnit CubicMillimeterUnit = new VolumeUnit(Length.Millimeter);
      private static readonly VolumeUnit CubicCentimeterUnit = new VolumeUnit(Length.Centimeter);
      private static readonly VolumeUnit CubicDecimeterUnit = new VolumeUnit(Length.Decimeter);
      private static readonly VolumeUnit CubicMeterUnit = new VolumeUnit(Length.Meter);
      private static readonly VolumeUnit CubicInchUnit = new VolumeUnit(Length.Inch);
      private static readonly VolumeUnit LitreUnit = new Litre();
      private static readonly VolumeUnit MilliLitreUnit = new Litre(Multiple.Milli);

      /// <summary>
      /// Gets a unit of 1 cubic millimeter
      /// </summary>
      public static VolumeUnit CubicMillimeter
      {
         get { return CubicMillimeterUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 cubic centimeter
      /// </summary>
      public static VolumeUnit CubicCentimeter
      {
         get { return CubicCentimeterUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 cubic decimeter
      /// </summary>
      public static VolumeUnit CubicDecimeter
      {
         get { return CubicDecimeterUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 cubic meter
      /// </summary>
      public static VolumeUnit CubicMeter
      {
         get { return CubicMeterUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 cubic inch
      /// </summary>
      public static VolumeUnit CubicInch
      {
         get { return CubicInchUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 litre.
      /// </summary>
      public static VolumeUnit Litre
      {
         get { return LitreUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 millilitre.
      /// </summary>
      public static VolumeUnit MilliLitre
      {
         get { return MilliLitreUnit;}
      }

      #endregion public convenience properties

      /// <summary>
      /// Creates a new instance of volume.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public Volume(double value, VolumeUnit unit)
         : base(value, unit)
      {
      }



      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameVolume; }
      }

      /// <summary>
      /// Gets an enumeration value for volume.
      /// </summary>
      /// <value>Volume</value>
      public override Quantity Dimension
      {
         get { return Quantity.Volume; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<Volume,VolumeUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Volume ConvertTo(VolumeUnit newUnit)
      {
         return (Volume)base.ConvertTo(newUnit);
      }

      #endregion

      #region operator +

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator +(Volume x, Volume y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator +(Volume x, int y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator +(int x, Volume y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator +(double x, Volume y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator +(Volume x, double y)
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
      public static Volume operator -(Volume x, Volume y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator -(int x, Volume y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator -(Volume x, int y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator -(double x, Volume y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator -(Volume x, double y)
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
      public static Volume operator *(Volume x, Volume y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator *(Volume x, int y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator *(int x, Volume y)
      {
         return Multiply(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator *(Volume x, double y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator *(double x, Volume y)
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
      public static Volume operator /(Volume x, Volume y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator /(Volume x, int y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator /(int x, Volume y)
      {
         return Divide(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator /(Volume x, double y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Volume operator /(double x, Volume y)
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
      public static bool operator >(Volume x, Volume y)
      {
         return x.CompareTo(y) > 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(Volume x, Volume y)
      {
         return x.CompareTo(y) < 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(Volume x, Volume y)
      {
         return x.CompareTo(y) >= 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(Volume x, Volume y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Volume>

      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Volume other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}