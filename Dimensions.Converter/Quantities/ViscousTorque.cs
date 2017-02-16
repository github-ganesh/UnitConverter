


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// The physical dimension of viscous torque.
   /// </summary>
   
   public class ViscousTorque : PhysicalQuantityBase, IUnitConvertable<ViscousTorque, ViscousTorqueUnit>, IComparable<ViscousTorque>
   {
      #region public convenience properties

      /// <summary>
      /// Gets a new instance for meters per second.
      /// </summary>
      public static ViscousTorqueUnit NewtonMeterPer1000RevolutionsperMinute
      {
         // 1 meter times 1 second to the power of -1. (m * s^-1)
         get { return new ViscousTorqueUnit(Torque.NewtonMeter, new RotationalSpeed(1000, AngularSpeed.RevolutionsPerMinute)); }
      }

      /// <summary>
      /// Gets a new instance of 1 pound-force feet.
      /// </summary>
      public static ViscousTorqueUnit PoundForceFeetPer1000RevolutionsPerMinute
      {
         get { return new ViscousTorqueUnit(Torque.PoundForceFeet, new RotationalSpeed(1000, AngularSpeed.RevolutionsPerMinute)); }
      }

      #endregion

      /// <summary>
      /// Creates a new instance of viscous torque.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public ViscousTorque(double value, ViscousTorqueUnit unit)
         : base(value, unit)
      {
      }

      /// <summary>
      /// Creates a new instance of viscous torque.
      /// </summary>
      /// <param name="torque">The <see cref="Torque">torque</see> this viscous torque consists of.</param>
      /// <param name="speed">The <see cref="Speed">speed</see> this viscous torque consists of.</param>
      public ViscousTorque(Torque torque, RotationalSpeed speed)
          : this(torque.Value / speed.Value, new ViscousTorqueUnit((TorqueUnit)torque.Unit, speed))
      {         
      }
      

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets an enumeration value for torque.
      /// </summary>
      public override Quantity Dimension
      {
         get { return Quantity.ViscousTorque; }
      }

      #endregion Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameViscousTorque; }
      }

      #region Implementation of IUnitConvertable<ViscousTorque,ViscousTorqueUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public ViscousTorque ConvertTo(ViscousTorqueUnit newUnit)
      {
         return (ViscousTorque)base.ConvertTo(newUnit);
      }

      #endregion

      #region operator +

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator +(ViscousTorque x, ViscousTorque y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator +(ViscousTorque x, int y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator +(int x, ViscousTorque y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator +(double x, ViscousTorque y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator +(ViscousTorque x, double y)
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
      public static ViscousTorque operator -(ViscousTorque x, ViscousTorque y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator -(int x, ViscousTorque y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator -(ViscousTorque x, int y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator -(double x, ViscousTorque y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator -(ViscousTorque x, double y)
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
      public static ViscousTorque operator *(ViscousTorque x, ViscousTorque y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator *(ViscousTorque x, int y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator *(int x, ViscousTorque y)
      {
         return Multiply(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator *(ViscousTorque x, double y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator *(double x, ViscousTorque y)
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
      public static ViscousTorque operator /(ViscousTorque x, ViscousTorque y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator /(ViscousTorque x, int y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator /(int x, ViscousTorque y)
      {
         return Divide(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator /(ViscousTorque x, double y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousTorque operator /(double x, ViscousTorque y)
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
      public static bool operator >(ViscousTorque x, ViscousTorque y)
      {
         return x.CompareTo(y) > 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(ViscousTorque x, ViscousTorque y)
      {
         return x.CompareTo(y) < 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(ViscousTorque x, ViscousTorque y)
      {
         return x.CompareTo(y) >= 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(ViscousTorque x, ViscousTorque y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<ViscousTorque>

      /// <summary>
      /// Compares the Torque object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(ViscousTorque other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}