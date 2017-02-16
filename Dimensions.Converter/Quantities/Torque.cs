

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// The physical dimension of torque.
   /// </summary>
   
   public class Torque : PhysicalQuantityBase, IUnitConvertable<Torque, TorqueUnit>, IComparable<Torque>
   {
      #region public convenience properties

      private static readonly TorqueUnit NewtonMeterUnit = new TorqueUnit(Force.Newton, Length.Meter);
      private static readonly TorqueUnit PoundForceFeetUnit = new TorqueUnit(Force.PoundForce, Length.Foot);

      /// <summary>
      /// Gets a unit of 1 Newton meter.
      /// </summary>
      public static TorqueUnit NewtonMeter
      {
         get { return NewtonMeterUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 pound-force feet.
      /// </summary>
      public static TorqueUnit PoundForceFeet
      {
         get { return PoundForceFeetUnit; }
      }

      #endregion

      /// <summary>
      /// Creates a new instance of torque.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public Torque(double value, TorqueUnit unit)
         : base(value, unit)
      {
      }

      /// <summary>
      /// Creates a new instance of torque.
      /// </summary>
      /// <param name="force">The <see cref="Force">force</see> this torque consists of.</param>
      /// <param name="length">The <see cref="Length">length</see> this torque consists of.</param>
      public Torque(Force force, Length length)
          : this(force.Value * length.Value, new TorqueUnit((ForceUnit)force.Unit, (LengthUnit)length.Unit))
      {         
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets an enumeration value for torque.
      /// </summary>
      public override Quantity Dimension
      {
         get { return Quantity.Torque; }
      }

      #endregion Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameTorque; }
      }

      #region Implementation of IUnitConvertable<Torque,TorqueUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Torque ConvertTo(TorqueUnit newUnit)
      {
         return (Torque)base.ConvertTo(newUnit);
      }

      #endregion

      #region operator +

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator +(Torque x, Torque y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator +(Torque x, int y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator +(int x, Torque y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator +(double x, Torque y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator +(Torque x, double y)
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
      public static Torque operator -(Torque x, Torque y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator -(int x, Torque y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator -(Torque x, int y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator -(double x, Torque y)
      {
         return Subtract(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator -(Torque x, double y)
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
      public static Torque operator *(Torque x, Torque y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator *(Torque x, int y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator *(int x, Torque y)
      {
         return Multiply(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator *(Torque x, double y)
      {
         return Multiply(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator *(double x, Torque y)
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
      public static Torque operator /(Torque x, Torque y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator /(Torque x, int y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator /(int x, Torque y)
      {
         return Divide(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator /(Torque x, double y)
      {
         return Divide(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Torque operator /(double x, Torque y)
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
      public static bool operator >(Torque x, Torque y)
      {
         return x.CompareTo(y) > 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(Torque x, Torque y)
      {
         return x.CompareTo(y) < 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(Torque x, Torque y)
      {
         return x.CompareTo(y) >= 0;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(Torque x, Torque y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Torque>

      /// <summary>
      /// Compares the Torque object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Torque other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}