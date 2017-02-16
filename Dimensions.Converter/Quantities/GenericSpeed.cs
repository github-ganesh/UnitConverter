


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// The physical dimension of speed.
   /// </summary>
   
   public class GenericSpeed : PhysicalQuantityBase, IUnitConvertable<GenericSpeed, GenericSpeedUnit>, IComparable<GenericSpeed>
   {
      #region public convenience properties

      private static readonly GenericSpeedUnit UnitsPerSecondUnit = new GenericSpeedUnit(new GenericUnit(), Time.Second);

      /// <summary>
      /// Gets a new instance for units per second.
      /// </summary>
      public static GenericSpeedUnit UnitsPerSecond
      {
         
         get { return UnitsPerSecondUnit; }
      }

      #endregion public convenience properties

      /// <summary>
      /// Creates a new instance of speed.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public GenericSpeed(double value, GenericSpeedUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameSpeed; }
      }

      /// <summary>
      /// Gets an enumeration value for speed.
      /// </summary>
      /// <value><see cref="Quantity.Speed"/></value>
      public override Quantity Dimension
      {
         get { return Quantity.Speed; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<GenericSpeed,GenericSpeedUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public GenericSpeed ConvertTo(GenericSpeedUnit newUnit)
      {
         return (GenericSpeed)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertable<GenericSpeed,GenericSpeedUnit>

      #region operator +

      /// <summary>
      /// Adds two generic speeds.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The sum of the two operands.</returns>
      public static GenericSpeed operator +(GenericSpeed x, GenericSpeed y)
      {
         return Add(x, y);
      }
      /// <summary>
      /// Adds an integer to a generic speed.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The sum of the two operands.</returns>
      public static GenericSpeed operator +(GenericSpeed x, int y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Adds a generic speed to an integer.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The sum of the two operands.</returns>
      public static GenericSpeed operator +(int x, GenericSpeed y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// Adds a generic speed to a double.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The sum of the two operands.</returns>
      public static GenericSpeed operator +(double x, GenericSpeed y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// Adds a double to a generic speed.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The sum of the two operands.</returns>
      public static GenericSpeed operator +(GenericSpeed x, double y)
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
      public static GenericSpeed operator -(GenericSpeed x, GenericSpeed y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericSpeed operator -(int x, GenericSpeed y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericSpeed operator -(GenericSpeed x, int y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericSpeed operator -(double x, GenericSpeed y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericSpeed operator -(GenericSpeed x, double y)
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
      public static GenericSpeed operator *(GenericSpeed x, GenericSpeed y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericSpeed operator *(GenericSpeed x, int y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericSpeed operator *(int x, GenericSpeed y)
      {
         return Multiply(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericSpeed operator *(GenericSpeed x, double y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericSpeed operator *(double x, GenericSpeed y)
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
      public static GenericSpeed operator /(GenericSpeed x, GenericSpeed y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericSpeed operator /(GenericSpeed x, int y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericSpeed operator /(int x, GenericSpeed y)
      {
         return Divide(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericSpeed operator /(GenericSpeed x, double y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericSpeed operator /(double x, GenericSpeed y)
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
      public static bool operator >(GenericSpeed x, GenericSpeed y)
      {
         return x.CompareTo(y) > 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(GenericSpeed x, GenericSpeed y)
      {
         return x.CompareTo(y) < 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(GenericSpeed x, GenericSpeed y)
      {
         return x.CompareTo(y) >= 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(GenericSpeed x, GenericSpeed y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<GenericSpeed>

      /// <summary>
      /// Compares the GenericSpeed object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(GenericSpeed other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<GenericSpeed>
   }
}