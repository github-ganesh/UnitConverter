

using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the physical quantity of temperature.
   /// </summary>
   
   public class Temperature : PhysicalQuantityBase, IUnitConvertable<Temperature, TemperatureUnit>, IComparable<Temperature>
   {
      #region public convenience properties

      private static readonly TemperatureUnit CelsiusUnit = new Celsius();
      private static readonly TemperatureUnit KelvinUnit = new Kelvin();
      private static readonly TemperatureUnit FahrenheitUnit = new Fahrenheit();

      /// <summary>
      /// Gets a unit of 1 Celsius
      /// </summary>
      public static TemperatureUnit Celsius
      {
         get { return CelsiusUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 Kelvin
      /// </summary>
      public static TemperatureUnit Kelvin
      {
         get { return KelvinUnit; }
      }

      /// <summary>
      /// Gets a unit of 1 Fahrenheit
      /// </summary>
      public static TemperatureUnit Fahrenheit
      {
         get { return FahrenheitUnit; }
      }

      #endregion public convenience properties

      /// <summary>
      /// Creates a new instance of temperature.
      /// </summary>
      /// <param name="value">The numeric value of the temperature in the given <paramref name="unit"/>.</param>
      /// <param name="unit">The unit of the length.</param>
      public Temperature(double value, TemperatureUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantity

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameTemperature; }
      }

      /// <summary>
      /// Gets an enumeration value for temperature.
      /// </summary>
      /// <value>Quantity.Temperature</value>
      public override Quantity Dimension
      {
         get { return Quantity.Temperature; }
      }

      #region Overrides of PhysicalQuantityBase

      /// <summary>
      /// Does a unit conversion on this object instance.
      /// </summary>
      /// <param name="newUnit"></param>
      /// <returns></returns>
      /// <exception cref="ArgumentNullException">Thrown, if <param name="newUnit"> is null.</param></exception>
      protected override void ConvertToInternal(UnitBase newUnit)
      {
         TemperatureUnit oldUnit = (TemperatureUnit)this.Unit;

         Temperature t = new Temperature(this.Value, oldUnit);
         // divert over Celsius, because it is the base unit.

         // Fahrenheit -> Celsius
         double valueC = t.Value - oldUnit.Offset; // apply the offset first
         valueC = valueC * GetConversionFactor(oldUnit, Celsius); // then the factor
         Temperature tC = new Temperature(valueC, Celsius); // new temperature in celsius.

         
         // celsius -> Fahrenheit
         double valueNew = tC.Value * GetConversionFactor(Celsius, newUnit); // first the factor
         valueNew = valueNew + newUnit.Offset;  // then the offset.

         this.Value = valueNew;
         this.UnitInternal = newUnit;
      }

      #endregion

      #endregion Overrides of PhysicalQuantity

      #region Implementation of IUnitConvertable<Temperature, TemperatureUnit>

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      public virtual Temperature ConvertTo(TemperatureUnit newUnit)
      {
         return (Temperature) base.ConvertTo(newUnit);
      }

      #endregion Implementation of IUnitConvertable<Temperature, TemperatureUnit>

      #region operator +

      public static Temperature operator +(Temperature x, Temperature y)
      {
         return Add(x, y);
      }

      public static Temperature operator +(Temperature x, int y)
      {
         return Add(x, y);
      }

      public static Temperature operator +(int x, Temperature y)
      {
         return Add(y, x);
      }

      public static Temperature operator +(double x, Temperature y)
      {
         return Add(y, x);
      }

      public static Temperature operator +(Temperature x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -

      public static Temperature operator -(Temperature x, Temperature y)
      {
         return Subtract(x, y);
      }

      public static Temperature operator -(int x, Temperature y)
      {
         return Subtract(y, x);
      }

      public static Temperature operator -(Temperature x, int y)
      {
         return Subtract(x, y);
      }

      public static Temperature operator -(double x, Temperature y)
      {
         return Subtract(y, x);
      }

      public static Temperature operator -(Temperature x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *

      public static Temperature operator *(Temperature x, Temperature y)
      {
         return Multiply(x, y);
      }

      public static Temperature operator *(Temperature x, int y)
      {
         return Multiply(x, y);
      }

      public static Temperature operator *(int x, Temperature y)
      {
         return Multiply(y, x);
      }

      public static Temperature operator *(Temperature x, double y)
      {
         return Multiply(x, y);
      }

      public static Temperature operator *(double x, Temperature y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      public static Temperature operator /(Temperature x, Temperature y)
      {
         return Divide(x, y);
      }

      public static Temperature operator /(Temperature x, int y)
      {
         return Divide(x, y);
      }

      public static Temperature operator /(int x, Temperature y)
      {
         return Divide(y, x);
      }

      public static Temperature operator /(Temperature x, double y)
      {
         return Divide(x, y);
      }

      public static Temperature operator /(double x, Temperature y)
      {
         return Divide(y, x);
      }

      #endregion operator /

      public static bool operator >(Temperature x, Temperature y)
      {
         return x.CompareTo(y) > 0;
      }

      public static bool operator <(Temperature x, Temperature y)
      {
         return x.CompareTo(y) < 0;
      }

      public static bool operator >=(Temperature x, Temperature y)
      {
         return x.CompareTo(y) >= 0;
      }

      public static bool operator <=(Temperature x, Temperature y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<Temperature>

      /// <summary>
      /// Compares the Temperature object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(Temperature other)
      {
         return CompareToInternal(other);
      }

      #endregion
   }
}