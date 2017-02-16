

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of electric current.
   /// </summary>
   
   public class Current : PhysicalQuantityBase, IUnitConvertable<Current, CurrentUnit>, IComparable<Current>
   {
      #region static convenience properties

      private static readonly CurrentUnit AmpereUnit = new Ampere();
      private static readonly CurrentUnit MilliAmpereUnit = new Ampere(Multiple.Milli);

      /// <summary>
      /// Gets a time unit of 1 ampere. This is also the base unit.
      /// </summary>
      public static CurrentUnit Ampere
      {
         get { return AmpereUnit; }
      }

      /// <summary>
      /// Gets a time unit of 1 milliampere
      /// </summary>
      public static CurrentUnit MilliAmpere
      {
         get { return MilliAmpereUnit; }
      }

      #endregion static convenience properties

      /// <summary>
      /// Creates a new instance of electric current.
      /// </summary>
      /// <param name="value">The numeric value of the current in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit of the current.</param>
      public Current(double value, CurrentUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameCurrent; }
      }

      /// <summary>
      /// Gets an enumeration value for electric current.
      /// </summary>
      /// <value>Quantity.ElectricCurrent</value>
      public override Quantity Dimension
      {
         get { return Quantity.ElectricCurrent; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<Current,CurrentUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Current ConvertTo(CurrentUnit newUnit)
      {
         return (Current)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertable<Current,CurrentUnit>

      #region operator +

      public static Current operator +(Current x, Current y)
      {
         return Add(x, y);
      }

      public static Current operator +(Current x, int y)
      {
         return Add(x, y);
      }

      public static Current operator +(int x, Current y)
      {
         return Add(y, x);
      }

      public static Current operator +(double x, Current y)
      {
         return Add(y, x);
      }

      public static Current operator +(Current x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static Current operator -(Current x, Current y)
      {
         return Subtract(x, y);
      }

      public static Current operator -(int x, Current y)
      {
         return Subtract(y, x);
      }

      public static Current operator -(Current x, int y)
      {
         return Subtract(x, y);
      }

      public static Current operator -(double x, Current y)
      {
         return Subtract(y, x);
      }

      public static Current operator -(Current x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static Current operator *(Current x, Current y)
      {
         return Multiply(x, y);
      }

      public static Current operator *(Current x, int y)
      {
         return Multiply(x, y);
      }

      public static Current operator *(int x, Current y)
      {
         return Multiply(y, x);
      }

      public static Current operator *(Current x, double y)
      {
         return Multiply(x, y);
      }

      public static Current operator *(double x, Current y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static Current operator /(Current x, Current y)
      {
         return Divide(x, y);
      }

      public static Current operator /(Current x, int y)
      {
         return Divide(x, y);
      }

      public static Current operator /(int x, Current y)
      {
         return Divide(y, x);
      }

      public static Current operator /(Current x, double y)
      {
         return Divide(x, y);
      }

      public static Current operator /(double x, Current y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(Current x, Current y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(Current x, Current y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(Current x, Current y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(Current x, Current y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Current>

      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Current other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}