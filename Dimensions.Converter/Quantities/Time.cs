


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// The physical dimension of time.
   /// Definied in seconds.
   /// </summary>
   
   public class Time : PhysicalQuantityBase, IUnitConvertable<Time, TimeUnit>, IComparable<Time>
   {
      #region public convenience properties

      private static readonly TimeUnit MilliSecondUnit = new Second(Multiple.Milli);
      private static readonly TimeUnit SecondUnit = new Second();
      private static readonly TimeUnit MinuteUnit = new Minute();
      private static readonly TimeUnit HourUnit = new Hour();
      private static readonly TimeUnit DayUnit = new Day();

      /// <summary>
      /// Gets a time unit of 1 milli second.
      /// </summary>
      public static TimeUnit MilliSecond
      {
         get { return MilliSecondUnit; }
      }

      /// <summary>
      /// Gets a time unit of 1 second. This is also the base unit.
      /// </summary>
      public static TimeUnit Second
      {
         get { return SecondUnit; }
      }

      /// <summary>
      /// Gets a time unit of 1 minute.
      /// </summary>
      public static TimeUnit Minute
      {
         get { return MinuteUnit; }
      }

      /// <summary>
      /// Gets a time unit of 1 hour.
      /// </summary>
      public static TimeUnit Hour
      {
         get { return HourUnit; }
      }

      /// <summary>
      /// Gets a time unit of 1 day.
      /// </summary>
      public static TimeUnit Day
      {
         get { return DayUnit; }
      }

      #endregion public convenience properties

      /// <summary>
      /// Creates a new instance of time.
      /// </summary>
      /// <param name="value"></param>
      /// <param name="unit"></param>
      public Time(double value, TimeUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets an enumeration value for time.
      /// </summary>
      public override Quantity Dimension
      {
         get { return Quantity.Time; }
      }

      public override string Name
      {
         get { return PhysicsResources.NameTime; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<Time,TimeUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Time ConvertTo(TimeUnit newUnit)
      {
         return (Time)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertable<Time,TimeUnit>

      #region operator +

      public static Time operator +(Time x, Time y)
      {
         return Add(x, y);
      }

      public static Time operator +(Time x, int y)
      {
         return Add(x, y);
      }

      public static Time operator +(int x, Time y)
      {
         return Add(y, x);
      }

      public static Time operator +(double x, Time y)
      {
         return Add(y, x);
      }

      public static Time operator +(Time x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static Time operator -(Time x, Time y)
      {
         return Subtract(x, y);
      }

      public static Time operator -(int x, Time y)
      {
         return Subtract(y, x);
      }

      public static Time operator -(Time x, int y)
      {
         return Subtract(x, y);
      }

      public static Time operator -(double x, Time y)
      {
         return Subtract(y, x);
      }

      public static Time operator -(Time x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static Time operator *(Time x, Time y)
      {
         return Multiply(x, y);
      }

      public static Time operator *(Time x, int y)
      {
         return Multiply(x, y);
      }

      public static Time operator *(int x, Time y)
      {
         return Multiply(y, x);
      }

      public static Time operator *(Time x, double y)
      {
         return Multiply(x, y);
      }

      public static Time operator *(double x, Time y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static Time operator /(Time x, Time y)
      {
         return Divide(x, y);
      }

      public static Time operator /(Time x, int y)
      {
         return Divide(x, y);
      }

      public static Time operator /(int x, Time y)
      {
         return Divide(y, x);
      }

      public static Time operator /(Time x, double y)
      {
         return Divide(x, y);
      }

      public static Time operator /(double x, Time y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(Time x, Time y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(Time x, Time y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(Time x, Time y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(Time x, Time y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Time>

      /// <summary>
      /// Compares the Time object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Time other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}