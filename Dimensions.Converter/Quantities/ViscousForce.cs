


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// The physical dimension of viscous force.
   /// </summary>
   
   public class ViscousForce : PhysicalQuantityBase, IUnitConvertable<ViscousForce, ViscousForceUnit>, IComparable<ViscousForce>
   {
      #region public convenience properties

      private static readonly ViscousForceUnit newtonPer1000RevolutionsPerMinute = new ViscousForceUnit(Force.Newton, new RotationalSpeed(1000, AngularSpeed.RevolutionsPerMinute));
      private static readonly ViscousForceUnit poundForcePer1000RevolutionsPerMinute = new ViscousForceUnit(Force.PoundForce, new RotationalSpeed(1000, AngularSpeed.RevolutionsPerMinute));

      private static readonly ViscousForceUnit poundForcePerMeterPerSecond = new ViscousForceUnit(Force.PoundForce, new Speed(1, Speed.MetersPerSecond));
      private static readonly ViscousForceUnit newtonPerMeterPerSecond = new ViscousForceUnit(Force.PoundForce, new Speed(1, Speed.MetersPerSecond));


      /// <summary>
      /// Gets a new instance for meters per second.
      /// </summary>
      public static ViscousForceUnit PoundForcePerMeterPerSecond
      {
         // 1 meter times 1 second to the power of -1. (m * s^-1)
         get { return poundForcePerMeterPerSecond; }
      }

      /// <summary>
      /// Gets a new instance for meters per second.
      /// </summary>
      public static ViscousForceUnit NewtonPerMeterPerSecond
      {
         // 1 meter times 1 second to the power of -1. (m * s^-1)
         get { return newtonPerMeterPerSecond; }
      }

      /// <summary>
      /// Gets a new instance for meters per second.
      /// </summary>
      public static ViscousForceUnit NewtonPer1000RevolutionsPerMinute
      {
         // 1 meter times 1 second to the power of -1. (m * s^-1)
         get { return newtonPer1000RevolutionsPerMinute; }
      }

      /// <summary>
      /// Gets a new instance of 1 pound-force feet.
      /// </summary>
      public static ViscousForceUnit PoundForcePer1000RevolutionsPerMinute
      {
         get { return poundForcePer1000RevolutionsPerMinute; }
      }



      #endregion

      /// <summary>
      /// Creates a new instance of viscous force.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public ViscousForce(double value, ViscousForceUnit unit)
         : base(value, unit)
      {
      }

      /// <summary>
      /// Creates a new instance of viscous force.
      /// </summary>
      /// <param name="force">The <see cref="Force">force</see> this viscous force consists of.</param>
      /// <param name="speed">The <see cref="Speed">speed</see> this viscous force consists of.</param>
      public ViscousForce(Force force, RotationalSpeed speed)
          : this(force.Value / speed.Value, new ViscousForceUnit((ForceUnit)force.Unit, speed))
      {         
      }
      

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets an enumeration value for viscous force.
      /// </summary>
      public override Quantity Dimension
      {
         get { return Quantity.ViscousForce; }
      }

      #endregion Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameViscousForce; }
      }

      #region Implementation of IUnitConvertable<ViscousForce,ViscousForceUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public ViscousForce ConvertTo(ViscousForceUnit newUnit)
      {
         return (ViscousForce)base.ConvertTo(newUnit);
      }

      #endregion

      #region operator +

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator +(ViscousForce x, ViscousForce y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator +(ViscousForce x, int y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator +(int x, ViscousForce y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator +(double x, ViscousForce y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator +(ViscousForce x, double y)
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
      public static ViscousForce operator -(ViscousForce x, ViscousForce y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator -(int x, ViscousForce y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator -(ViscousForce x, int y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator -(double x, ViscousForce y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator -(ViscousForce x, double y)
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
      public static ViscousForce operator *(ViscousForce x, ViscousForce y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator *(ViscousForce x, int y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator *(int x, ViscousForce y)
      {
         return Multiply(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator *(ViscousForce x, double y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator *(double x, ViscousForce y)
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
      public static ViscousForce operator /(ViscousForce x, ViscousForce y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator /(ViscousForce x, int y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator /(int x, ViscousForce y)
      {
         return Divide(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator /(ViscousForce x, double y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static ViscousForce operator /(double x, ViscousForce y)
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
      public static bool operator >(ViscousForce x, ViscousForce y)
      {
         return x.CompareTo(y) > 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(ViscousForce x, ViscousForce y)
      {
         return x.CompareTo(y) < 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(ViscousForce x, ViscousForce y)
      {
         return x.CompareTo(y) >= 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(ViscousForce x, ViscousForce y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<ViscousForce>

      /// <summary>
      /// Compares the Viscous force object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(ViscousForce other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}