

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a physical quantity of electric charge.
   /// </summary>
   
   public class ElectricCharge : PhysicalQuantityBase, IUnitConvertable<ElectricCharge, ElectricChargeUnit>, IComparable<ElectricCharge>
   {
      #region static convenience properties

      private static readonly ElectricChargeUnit AmpereSecondUnit = new ElectricChargeUnit(Current.Ampere, Time.Second);
      private static readonly ElectricChargeUnit CoulombUnit = new Coulomb();

      /// <summary>
      /// Gets the unit of 1 Ampere Second.
      /// </summary>
      public static ElectricChargeUnit AmpereSecond
      {
         get { return AmpereSecondUnit; }
      }

      /// <summary>
      /// Gets the unit of 1 Coulomb.
      /// </summary>
      public static ElectricChargeUnit Coulomb
      {
         get { return CoulombUnit; }
      }

      #endregion

      /// <summary>
      /// Creates a new instance of electric charge.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public ElectricCharge(double value, ElectricChargeUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets an enumeration value for electric charge.
      /// </summary>
      /// <value>Quantity.ElectricCharge</value>
      public override Quantity Dimension
      {
         get { return Quantity.ElectricCharge; }
      }

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameElectricCharge; }
      }

      #endregion Overrides of PhysicalQuantity

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public ElectricCharge ConvertTo(ElectricChargeUnit newUnit)
      {
         return (ElectricCharge)base.ConvertTo(newUnit);
      }

      #region operator +
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator +(ElectricCharge x, ElectricCharge y)
      {
         return Add(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator +(ElectricCharge x, int y)
      {
         return Add(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator +(int x, ElectricCharge y)
      {
         return Add(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator +(double x, ElectricCharge y)
      {
         return Add(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator +(ElectricCharge x, double y)
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
      public static ElectricCharge operator -(ElectricCharge x, ElectricCharge y)
      {
         return Subtract(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator -(int x, ElectricCharge y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator -(ElectricCharge x, int y)
      {
         return Subtract(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator -(double x, ElectricCharge y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator -(ElectricCharge x, double y)
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
      public static ElectricCharge operator *(ElectricCharge x, ElectricCharge y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator *(ElectricCharge x, int y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator *(int x, ElectricCharge y)
      {
         return Multiply(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator *(ElectricCharge x, double y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator *(double x, ElectricCharge y)
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
      public static ElectricCharge operator /(ElectricCharge x, ElectricCharge y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator /(ElectricCharge x, int y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator /(int x, ElectricCharge y)
      {
         return Divide(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator /(ElectricCharge x, double y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ElectricCharge operator /(double x, ElectricCharge y)
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
      public static bool operator >(ElectricCharge x, ElectricCharge y)
      {
         return x.CompareTo(y) > 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(ElectricCharge x, ElectricCharge y)
      {
         return x.CompareTo(y) < 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(ElectricCharge x, ElectricCharge y)
      {
         return x.CompareTo(y) >= 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(ElectricCharge x, ElectricCharge y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<ElectricCharge>

      /// <summary>
      /// Compares the ElectricCharge object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(ElectricCharge other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}