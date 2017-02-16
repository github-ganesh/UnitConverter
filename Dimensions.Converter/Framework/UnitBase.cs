


using System;
using System.Collections.Generic;



namespace Dimensions.Converter
{
   /// <summary>
   /// Base class for all units.
   /// </summary>
   
   
   public abstract class UnitBase : IEquatable<UnitBase>//, IExtensibleDataObject
   {
      
      private readonly double conversionFactor = 1.0;

     
      private readonly Multiple multiple = Multiple.None;

      
      private readonly double offset = 0.0;

     
      private readonly string symbol = string.Empty; // TODO: change this, so that no localized string is stored (and de/serialized!)

      /// <summary>
      /// Creates a new instance of a unit with a given conversion factor
      /// to it's base unit.
      /// Base units are the SI units, either base or derived.
      /// See the special implementation for details.
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to the base unit</param>
      /// <param name="symbol">The localized symbol for the unit</param>
      protected UnitBase(double conversionFactor, string symbol)
         : this(conversionFactor, 0.0, symbol)
      {
      }

      /// <summary>
      /// Creates a new instance of a unit with a given conversion factor
      /// to it's base unit.
      /// Base units are the SI units, either base or derived.
      /// See the special implementation for details.
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to the base unit</param>
      /// <param name="symbol">The localized symbol for the unit</param>
      /// <param name="offset">The offset that is necessary to convert this unit to its base unit.</param>
      protected UnitBase(double conversionFactor, double offset, string symbol)
      {
         this.conversionFactor = conversionFactor;
         this.symbol = symbol;
         this.offset = offset;
      }

      /// <summary>
      /// Creates a new instance of a unit with a given multiple factor
      /// to it's base unit.
      /// Base units are the SI units, either base or derived.
      /// See the special implementation for details.
      /// </summary>
      /// <param name="multiple">The multiple of the base unit</param>
      /// <param name="baseUnit">The base unit for this unit</param>
      /// <exception cref="ArgumentNullException">Thrown, if either <paramref name="multiple"/> or <paramref name="baseUnit"/> is null.</exception>
      protected UnitBase(Multiple multiple, UnitBase baseUnit)
         : this(multiple.Factor, multiple.Symbol + baseUnit.Symbol)
      {
         if (Multiple == null)
         {
            throw new ArgumentNullException("multiple");
         }
         if (baseUnit == null)
         {
            throw new ArgumentNullException("baseUnit");
         }

         this.multiple = multiple;
      }

      /// <summary>
      /// Gets the multiple of the unit.
      /// </summary>
      protected Multiple Multiple
      {
         get { return this.multiple; }
      }

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      public abstract Quantity Quantity { get; }

      /// <summary>
      /// Defines the conversion factor to the base SI unit.
      /// </summary>
      public virtual double ConversionFactor
      {
         get { return this.conversionFactor; }
      }

      /// <summary>
      /// Gets the offset to the base unit.
      /// </summary>
      public virtual double Offset
      {
         get { return this.offset; }
      }

      /// <summary>
      /// Gets the unit system this unit belongs to.
      /// Default is UnitSystem.Universal
      /// </summary>
      /// <value>UnitSystem.Universal</value>
      public virtual UnitSystem UnitSystem
      {
         get { return UnitSystem.Universal; }
      }

      /// <summary>
      /// Gets the short notation of the unit
      /// </summary>
      public string Symbol { get { return symbol; } }

      #region Implementation of IEquatable<UnitBase>

      /// <summary>
      /// Indicates whether the current unit is equal to another unit.
      /// </summary>
      /// <returns>
      /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public bool Equals(UnitBase other)
      {
         if (Object.ReferenceEquals(other, null))
         {
            return false;
         }

         return this.ConversionFactor.DoubleEquals(other.conversionFactor) &&
                this.Quantity == other.Quantity;
      }

      #endregion Implementation of IEquatable<UnitBase>

      #region Overrides of Object

      /// <summary>
      /// Returns the symbol of the unit (the short unit name)
      /// </summary>
      /// <returns>
      /// A string that represents the current object.
      /// </returns>
      public override string ToString()
      {
         return this.Symbol;
      }

      /// <summary>
      /// Returns the symbol of the unit (the short unit name)
      /// </summary>
      /// <returns>
      /// A string that represents the current object.
      /// </returns>
      public virtual string ToString(IFormatProvider formatProvider)
      {
         return this.Symbol;
      }

      /// <summary>
      /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
      /// </summary>
      /// <returns>
      /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
      /// </returns>
      /// <param name="obj">The object to compare with the current object. </param>
      public override bool Equals(object obj)
      {
         UnitBase u = obj as UnitBase;
         if (Object.ReferenceEquals(u, null))
         {
            return false;
         }
         return Equals(u);
      }

      /// <summary>
      /// Checks two units for equality.
      /// </summary>
      /// <param name="x">A unit to be compared.</param>
      /// <param name="y">A unit to be compared.</param>
      /// <returns></returns>
      public static bool operator ==(UnitBase x, UnitBase y)
      {
         if (Object.ReferenceEquals(x, null) && Object.ReferenceEquals(y, null))
         {
            return true;
         }
         if (Object.ReferenceEquals(x, null) && !Object.ReferenceEquals(y, null))
         {
            return false;
         }
         if (!Object.ReferenceEquals(x, null) && Object.ReferenceEquals(y, null))
         {
            return false;
         }
         return x.Equals(y);
      }

      /// <summary>
      /// Checks two units for inequality.
      /// </summary>
      /// <param name="x">A unit to be compared.</param>
      /// <param name="y">A unit to be compared.</param>
      /// <returns></returns>
      public static bool operator !=(UnitBase x, UnitBase y)
      {
         return !(x == y);
      }

      /// <summary>
      /// Generates a new unit as it is created when 2 units are multiplied.
      /// </summary>
      /// <param name="x">The first unit</param>
      /// <param name="y">The second unit.</param>
      /// <returns></returns>
      public static UnitBase operator *(UnitBase x, UnitBase y)
      {
         if (x == null)
         {
            return null;
         }
         return x.MultiplyWith(y);
      }

      /// <summary>
      /// Generates a new unit as it is created when 2 units are divided.
      /// </summary>
      /// <param name="x">The first unit</param>
      /// <param name="y">The second unit.</param>
      /// <returns></returns>
      public static UnitBase operator /(UnitBase x, UnitBase y)
      {
         if (x == null)
         {
            return null;
         }
         return x.DivideBy(y);
      }

      /// <summary>
      /// Multiplies this unit with another. Call this from the operator *.
      /// </summary>
      /// <param name="y">The unit this unit shall be multiplied with.</param>
      /// <returns>A new unit where this unit is multiplied with the other.</returns>
      protected virtual UnitBase MultiplyWith(UnitBase y)
      {
         UnitCompositeCollection c = new UnitCompositeCollection();
         c.MultipliedBy(this, 1);
         c.MultipliedBy(y, 1);
         return new DerivedUnit(c, Quantity.None);
      }

      /// <summary>
      /// Divides this unit by another. Call this from the operator /.
      /// </summary>
      /// <param name="y">The unit this unit shall be divided by.</param>
      /// <returns>A new unit where this unit is divided by the other.</returns>
      protected virtual UnitBase DivideBy(UnitBase y)
      {
         UnitCompositeCollection c = new UnitCompositeCollection();
         c.MultipliedBy(this, 1);
         c.DividedBy(y, 1);
         return new DerivedUnit(c, Quantity.None);
      }

      #region Overrides of Object

      /// <summary>
      /// Serves as a hash function for a particular type.
      /// </summary>
      /// <returns>
      /// A hash code for the current <see cref="T:System.Object"/>.
      /// </returns>
      public override int GetHashCode()
      {
         return this.ToString().GetHashCode();
      }

      #endregion Overrides of Object

      #endregion Overrides of Object

      #region Serialization support

      //ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }

      // ReSharper disable once UnusedMethodReturnValue.Local
      private static IEnumerable<Type> GetKnownTypes()
      {
         return typeof(UnitBase).GetAssignableTypes(TypeExtension.AssignableTypesOption.ResolveGenericTypeDefinitions);
      }

      #endregion
   }
}