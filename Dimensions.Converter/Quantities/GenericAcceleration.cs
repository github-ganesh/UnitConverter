


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of generic acceleration.
   /// </summary>
   
   public class GenericAcceleration : PhysicalQuantityBase, IUnitConvertable<GenericAcceleration, GenericAccelerationUnit>, IComparable<GenericAcceleration>
   {
      #region static convenience properties

      private static readonly GenericAccelerationUnit UnitsPerSquareSecondUnit = new GenericAccelerationUnit(new GenericUnit(), Time.Second);

      /// <summary>
      /// Gets a unit for units per square second.
      /// </summary>
      public static GenericAccelerationUnit UnitsPerSquareSecond
      {
         get { return UnitsPerSquareSecondUnit; }
      }



      #endregion static convenience properties

      /// <summary>
      /// Creates a new instance of Acceleration.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public GenericAcceleration(double value, GenericAccelerationUnit unit)
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

      #region Implementation of IUnitConvertible<GenericAcceleration,GenericAccelerationUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public GenericAcceleration ConvertTo(GenericAccelerationUnit newUnit)
      {
         return (GenericAcceleration)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertible<GenericAcceleration,GenericAccelerationUnit>

      #region operator +

      /// <summary>
      /// Adds two generic accelerations.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The sum of the two operands.</returns>
      public static GenericAcceleration operator +(GenericAcceleration x, GenericAcceleration y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Adds an integer to a generic acceleration.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The sum of the two operands.</returns>
      public static GenericAcceleration operator +(GenericAcceleration x, int y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// Adds an integer to a generic acceleration.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The sum of the two operands.</returns>
      public static GenericAcceleration operator +(int x, GenericAcceleration y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// Adds a generic acceleration to a double.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The sum of the two operands.</returns>
      public static GenericAcceleration operator +(double x, GenericAcceleration y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The sum of the two operands.</returns>
      public static GenericAcceleration operator +(GenericAcceleration x, double y)
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
      public static GenericAcceleration operator -(GenericAcceleration x, GenericAcceleration y)
      {
         return Subtract(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericAcceleration operator -(int x, GenericAcceleration y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericAcceleration operator -(GenericAcceleration x, int y)
      {
         return Subtract(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericAcceleration operator -(double x, GenericAcceleration y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericAcceleration operator -(GenericAcceleration x, double y)
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
      public static GenericAcceleration operator *(GenericAcceleration x, GenericAcceleration y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericAcceleration operator *(GenericAcceleration x, int y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericAcceleration operator *(int x, GenericAcceleration y)
      {
         return Multiply(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericAcceleration operator *(GenericAcceleration x, double y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericAcceleration operator *(double x, GenericAcceleration y)
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
      public static GenericAcceleration operator /(GenericAcceleration x, GenericAcceleration y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericAcceleration operator /(GenericAcceleration x, int y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericAcceleration operator /(int x, GenericAcceleration y)
      {
         return Divide(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericAcceleration operator /(GenericAcceleration x, double y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static GenericAcceleration operator /(double x, GenericAcceleration y)
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
      public static bool operator >(GenericAcceleration x, GenericAcceleration y)
      {
         return x.CompareTo(y) > 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(GenericAcceleration x, GenericAcceleration y)
      {
         return x.CompareTo(y) < 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(GenericAcceleration x, GenericAcceleration y)
      {
         return x.CompareTo(y) >= 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(GenericAcceleration x, GenericAcceleration y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<GenericAcceleration>

      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(GenericAcceleration other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<GenericAcceleration>
   }
}