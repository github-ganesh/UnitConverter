


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of intertia.
   /// </summary>
   
   public class Inertia : PhysicalQuantityBase, IUnitConvertable<Inertia, InertiaUnit>, IComparable<Inertia>
   {
      #region public convenience properties

      private static readonly InertiaUnit KilogramSquareMeterUnit = new InertiaUnit(Mass.Kilogram, Area.SquareMeter);
      private static readonly InertiaUnit KilogramSquareCentimeterUnit = new InertiaUnit(Mass.Kilogram, Area.SquareCentimeter);

      /// <summary>
      /// Gets an inertia unit of 1 kilogram square meter.
      /// </summary>
      public static InertiaUnit KilogramSquareMeter
      {
         get { return KilogramSquareMeterUnit; }
      }

      /// <summary>
      /// Gets an inertia unit of 1 kilogram square centimeter.
      /// </summary>
      public static InertiaUnit KilogramSquareCentimeter
      {
         get { return KilogramSquareCentimeterUnit; }
      }

      #endregion

      /// <summary>
      /// Creates a new instance of inertia.
      /// </summary>
      /// <param name="value">The numeric value of the length in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit of the inertia.</param>
      public Inertia(double value, InertiaUnit unit)
         : base(value, unit)
      {
      }

      /// <summary>
      /// Creates a new instance of inertia.
      /// </summary>
      /// <param name="mass">The <see cref="Mass">mass</see> this inertia consists of.</param>
      /// <param name="area">The <see cref="Length">length</see> this inertia consists of.</param>
      public Inertia(Mass mass, Area area)
         : this(mass.Value * Math.Pow(area.Value, 2), new InertiaUnit((MassUnit)mass.Unit, (AreaUnit)area.Unit))
      {
      }

      /// <summary>
      /// Creates a new instance of inertia.
      /// </summary>
      /// <param name="mass">The <see cref="Mass">mass</see> this inertia consists of.</param>
      /// <param name="length">The <see cref="Length">length</see> this inertia consists of.</param>
      public Inertia(Mass mass, Length length)
         : this(mass.Value * Math.Pow(length.Value, 2), new InertiaUnit((MassUnit)mass.Unit, (AreaUnit)length.Unit))
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameInertia; }
      }

      /// <summary>
      /// Gets the kind of dimension.
      /// </summary>
      /// <value><see cref="Dimension"/></value>
      public override Quantity Dimension
      {
         get { return Quantity.Inertia; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<Inertia,InertiaUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Inertia ConvertTo(InertiaUnit newUnit)
      {
         return (Inertia)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertable<Inertia,InertiaUnit>

      #region operator +

      public static Inertia operator +(Inertia x, Inertia y)
      {
         return Add(x, y);
      }

      public static Inertia operator +(Inertia x, int y)
      {
         return Add(x, y);
      }

      public static Inertia operator +(int x, Inertia y)
      {
         return Add(y, x);
      }

      public static Inertia operator +(double x, Inertia y)
      {
         return Add(y, x);
      }

      public static Inertia operator +(Inertia x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static Inertia operator -(Inertia x, Inertia y)
      {
         return Subtract(x, y);
      }

      public static Inertia operator -(int x, Inertia y)
      {
         return Subtract(y, x);
      }

      public static Inertia operator -(Inertia x, int y)
      {
         return Subtract(x, y);
      }

      public static Inertia operator -(double x, Inertia y)
      {
         return Subtract(y, x);
      }

      public static Inertia operator -(Inertia x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static Inertia operator *(Inertia x, Inertia y)
      {
         return Multiply(x, y);
      }

      public static Inertia operator *(Inertia x, int y)
      {
         return Multiply(x, y);
      }

      public static Inertia operator *(int x, Inertia y)
      {
         return Multiply(y, x);
      }

      public static Inertia operator *(Inertia x, double y)
      {
         return Multiply(x, y);
      }

      public static Inertia operator *(double x, Inertia y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static Inertia operator /(Inertia x, Inertia y)
      {
         return Divide(x, y);
      }

      public static Inertia operator /(Inertia x, int y)
      {
         return Divide(x, y);
      }

      public static Inertia operator /(int x, Inertia y)
      {
         return Divide(y, x);
      }

      public static Inertia operator /(Inertia x, double y)
      {
         return Divide(x, y);
      }

      public static Inertia operator /(double x, Inertia y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(Inertia x, Inertia y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(Inertia x, Inertia y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(Inertia x, Inertia y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(Inertia x, Inertia y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Inertia>

      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Inertia other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<Inertia>
   }
}