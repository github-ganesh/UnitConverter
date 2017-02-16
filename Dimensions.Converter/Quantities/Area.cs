

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of area.
   /// </summary>
   
   public class Area : PhysicalQuantityBase, IUnitConvertable<Area, AreaUnit>, IComparable<Area>
   {
      #region static convenience properties

      private static readonly AreaUnit SquareMillimeterUnit = new AreaUnit(Length.Millimeter);
      private static readonly AreaUnit SquareCentimeterUnit = new AreaUnit(Length.Centimeter);
      private static readonly AreaUnit SquareDecimeterUnit = new AreaUnit(Length.Decimeter);
      private static readonly AreaUnit SquareMeterUnit = new AreaUnit(Length.Meter);
      private static readonly AreaUnit SquareKilometerUnit = new AreaUnit(Length.Kilometer);
      private static readonly AreaUnit SquareInchUnit = new AreaUnit(Length.Inch);
      private static readonly AreaUnit SquareFootUnit = new AreaUnit(Length.Foot);
      private static readonly AreaUnit SquareYardUnit = new AreaUnit(Length.Yard);
      private static readonly AreaUnit SquareMileUnit = new AreaUnit(Length.Mile);

      /// <summary>
      /// Gets a unit of 1 square millimeter
      /// </summary>
      public static AreaUnit SquareMillimeter
      {
         get { return SquareMillimeterUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 square centimeter
      /// </summary>
      public static AreaUnit SquareCentimeter
      {
         get { return SquareCentimeterUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 square decimeter
      /// </summary>
      public static AreaUnit SquareDecimeter
      {
         get { return SquareDecimeterUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 square decimeter
      /// </summary>
      public static AreaUnit SquareMeter
      {
         get { return SquareMeterUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 square kilometer
      /// </summary>
      public static AreaUnit SquareKilometer
      {
         get { return SquareKilometerUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 square inch.
      /// </summary>
      public static AreaUnit SquareInch
      {
         get { return SquareInchUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 square foot.
      /// </summary>
      public static AreaUnit SquareFoot
      {
         get { return SquareFootUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 square yard.
      /// </summary>
      public static AreaUnit SquareYard
      {
         get { return SquareYardUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 square mile.
      /// </summary>
      public static AreaUnit SquareMile
      {
         get { return SquareMileUnit; }
      }

      #endregion static convenience properties

      /// <summary>
      /// Creates a new instance of Area.
      /// </summary>
      /// <param name="value">The numerical value in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit the numerical value is in.</param>
      public Area(double value, AreaUnit unit)
         : base(value, unit)
      {
      }
      /// <summary>
      /// Creates a new instance of area.
      /// </summary>
      /// <param name="width">The width of the area.</param>
      /// <param name="length">The length of the area.</param>
      public Area(Length width, Length length)
         : this((width * length).Value, (AreaUnit)(width * length).Unit) // multiplication needed to consider the unit.
      {
         
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameArea; }
      }

      /// <summary>
      /// Gets an enumeration value this dimension represents.
      /// </summary>
      /// <value>Quantity.Area</value>
      public override Quantity Dimension
      {
         get { return Quantity.Area; }
      }

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertible<Area,AreaUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public Area ConvertTo(AreaUnit newUnit)
      {
         return (Area)base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertible<Area,AreaUnit>

      #region operator +
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator +(Area x, Area y)
      {
         return Add(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator +(Area x, int y)
      {
         return Add(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator +(int x, Area y)
      {
         return Add(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator +(double x, Area y)
      {
         return Add(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator +(Area x, double y)
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
      public static Area operator -(Area x, Area y)
      {
         return Subtract(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator -(int x, Area y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator -(Area x, int y)
      {
         return Subtract(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator -(double x, Area y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator -(Area x, double y)
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
      public static Area operator *(Area x, Area y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator *(Area x, int y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator *(int x, Area y)
      {
         return Multiply(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator *(Area x, double y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator *(double x, Area y)
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
      public static Quotient operator /(Area x, Area y)
      {
         Area a = Divide(x, y);
         double v = a.Value;

         return new Quotient(v, new RatioUnit());

      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator /(Area x, int y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator /(int x, Area y)
      {
         return Divide(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static Area operator /(Area x, double y)
      {
         return Divide(x, y);
      }

      public static Area operator /(double x, Area y)
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
      public static bool operator >(Area x, Area y)
      {
         return x.CompareTo(y) > 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(Area x, Area y)
      {
         return x.CompareTo(y) < 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(Area x, Area y)
      {
         return x.CompareTo(y) >= 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(Area x, Area y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Area>

      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Area other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<Area>
   }
}