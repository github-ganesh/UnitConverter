


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;

using Dimensions.Converter.Physics.Dimensions._Framework;


namespace Dimensions.Converter
{
   /// <summary>
   /// Base class for all physical quantities.
   /// </summary>
   

   public abstract class PhysicalQuantityBase : IEquatable<PhysicalQuantityBase>, IComparable<PhysicalQuantityBase>, IFormattable, INotifyPropertyChanged//, IExtensibleDataObject
   {
      private const string ValuePropertyString = "Value";
      private const string UnitPropertyString = "Unit";

      
      private double value;

      private UnitBase unit;

      /// <summary>
      /// Base constructor for all physical quantities.
      /// </summary>
      /// <param name="value">The numerical value of the physical quantity in the given unit.</param>
      /// <param name="unit">The unit of the quantity.</param>
      protected PhysicalQuantityBase(double value, UnitBase unit)
      {
         this.UnitInternal = unit;
         this.value = value;
      }

      /// <summary>
      /// Gets the numeric value of this quantity in the <see cref="Unit"/> of this instance.
      /// </summary>
      public double Value
      {
         get { return this.value; }
         set
         {
            this.value = value;
            //OnPropertyChanged(ValuePropertyString);
         }
      }

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public abstract string Name
      {
         get;
      }

      /// <summary>
      /// Gets the unit of the quantity, as it was defined during construction.
      /// If the unit is set, a conversion of this instance is done to the new unit.
      /// </summary>
      public UnitBase Unit
      {
         get { return UnitInternal; }
         set
         {
            ConvertToInternal(value);
            if (UnitChanged != null)
            {
               UnitChanged(this, new UnitChangedEventArgs(this.unit, value));
            }
           // OnPropertyChanged(UnitPropertyString);
         }
      }

      /// <summary>
      /// Gets an enumeration value this dimension represents.
      /// </summary>
      public abstract Quantity Dimension { get; }

      /// <summary>
      /// For internal use. Set the value of the property directly while bypassing the
      /// conversion.
      /// </summary>
      protected UnitBase UnitInternal
      {
         get { return unit; }
         set { unit = value; }
      }

      /// <summary>
      /// Does a unit conversion on this object instance.
      /// </summary>
      /// <param name="newUnit"></param>
      /// <returns></returns>
      /// <exception cref="ArgumentNullException">Thrown, if <param name="newUnit"> is null.</param></exception>
      protected virtual void ConvertToInternal(UnitBase newUnit)
      {
         if (newUnit == null)
         {
            throw new ArgumentNullException("newUnit");
         }

         if (newUnit == this.UnitInternal)
         {
            // nothing to do
            return;
         }
         var oldUnit = UnitInternal;
         this.UnitInternal = newUnit;
         this.Value = value * GetConversionFactor(oldUnit, newUnit);
      }

      /// <summary>
      /// Gets the conversion factor between two units.
      /// </summary>
      /// <param name="oldUnit">The original unit that shall be converted.</param>
      /// <param name="newUnit">The destination unit for the conversion.</param>
      /// <returns>The factor necessary to convert oldUnit to newUnit.</returns>
      protected double GetConversionFactor(UnitBase oldUnit, UnitBase newUnit)
      {
         // the conversion factor is provided by the units, both of this instance and the new unit instance.
         // both the old and the new unit have a conversion factor to the base unit, so we have to create a conversion
         // factor from old to new.
         // this new factor must be applied to the value and replace the original conversion factor by the new one.

         double c1 = newUnit.ConversionFactor;
         double c2 = oldUnit.ConversionFactor;

         double c3 = c2 / c1;
         return c3;
      }

      /// <summary>
      /// Indicates whether the current object is equal to another object of the same type.
      /// </summary>
      /// <returns>
      /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public bool Equals(PhysicalQuantityBase other)
      {
         if (other == null)
         {
            return false;
         }
         bool valueEquals = this.Value.DoubleEquals(other.Value);
         bool unitEquals = this.Unit.Equals(other.Unit);
         return valueEquals && unitEquals;
      }

      #region Overrides of Object

      /// <summary>
      /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
      /// </summary>
      /// <returns>
      /// true if the specified object  is equal to the current object; otherwise, false.
      /// </returns>
      /// <param name="obj">The object to compare with the current object. </param>
      public override bool Equals(object obj)
      {
         PhysicalQuantityBase x = this;
         PhysicalQuantityBase y = obj as PhysicalQuantityBase;

         return x.Equals(y);
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
         return ToString().GetHashCode();
      }

      #endregion Overrides of Object

      #endregion Overrides of Object

      /// <summary>
      /// Compares two quantities for equality.
      /// </summary>
      /// <param name="x">The first operand for comparison.</param>
      /// <param name="y">The second operand for comparison.</param>
      /// <returns>True, if x and y are equal, otherwise false.</returns>
      public static bool operator ==(PhysicalQuantityBase x, PhysicalQuantityBase y)
      {
         if (Object.ReferenceEquals(x, null) && Object.ReferenceEquals(y, null))
         {
            return true;
         }
         if (Object.ReferenceEquals(x, null) && !Object.ReferenceEquals(y, null))
         {
            return false;
         }
         if (Object.ReferenceEquals(y, null) && !Object.ReferenceEquals(x, null))
         {
            return false;
         }

         return x.Equals(y);
      }

      /// <summary>
      /// Compares two quantities for non-equality.
      /// </summary>
      /// <param name="x">The first operand for comparison.</param>
      /// <param name="y">The second operand for comparison.</param>
      /// <returns>True, if x and y are different, otherwise false.</returns>
      public static bool operator !=(PhysicalQuantityBase x, PhysicalQuantityBase y)
      {
         return !(x == y);
      }

      /// <summary>
      /// Adds two quantities.
      /// </summary>
      /// <typeparam name="TQuantity"></typeparam>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The sum of the two operands.</returns>
      protected static TQuantity Add<TQuantity>(TQuantity x, TQuantity y)
         where TQuantity : PhysicalQuantityBase
      {
         if (x == null)
         {
            return y;
         }
         if (y == null)
         {
            return x;
         }

         TQuantity result = (TQuantity)x.MemberwiseClone();
         TQuantity yNormalized = (TQuantity)y.ConvertTo(x.Unit);

         result.Value = x.Value + yNormalized.Value;
         return result;
      }

      /// <summary>
      /// Adds an integer to a quantity.
      /// </summary>
      /// <typeparam name="TQuantity"></typeparam>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The sum of the two operands.</returns>
      protected static TQuantity Add<TQuantity>(TQuantity x, int y)
                  where TQuantity : PhysicalQuantityBase
      {
         if (x == null)
         {
            return default(TQuantity);
         }
         TQuantity result = (TQuantity)x.MemberwiseClone();

         result.Value = x.Value + y;
         return result;
      }

      /// <summary>
      /// Adds a double to a quantity.
      /// </summary>
      /// <typeparam name="TQuantity"></typeparam>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The sum of the two operands.</returns>
      protected static TQuantity Add<TQuantity>(TQuantity x, double y)
            where TQuantity : PhysicalQuantityBase
      {
         if (x == null)
         {
            return default(TQuantity);
         }
         TQuantity result = (TQuantity)x.MemberwiseClone();

         result.Value = x.Value + y;
         return result;
      }

      /// <summary>
      /// Subtracts two quantities.
      /// </summary>
      /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The difference of the two operands.</returns>
      protected static TQuantity Subtract<TQuantity>(TQuantity x, TQuantity y)
         where TQuantity : PhysicalQuantityBase
      {
         if (x == null)
         {
            return y;
         }
         if (y == null)
         {
            return x;
         }

         TQuantity result = (TQuantity)x.MemberwiseClone();
         TQuantity yNormalized = (TQuantity)y.ConvertTo(x.Unit);

         result.Value = x.Value - yNormalized.Value;
         return result;
      }

      /// <summary>
      /// Subtracts an integer from a quantity.
      /// </summary>
      /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The difference of the two operands.</returns>
      protected static TQuantity Subtract<TQuantity>(TQuantity x, int y)
            where TQuantity : PhysicalQuantityBase
      {
         if (x == null)
         {
            return default(TQuantity);
         }
         TQuantity result = (TQuantity)x.MemberwiseClone();

         result.Value = x.Value - y;
         return result;
      }

      /// <summary>
      /// Subtracts a double from a quantity.
      /// </summary>
      /// <typeparam name="TQuantity"></typeparam>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The difference of the two operands.</returns>
      protected static TQuantity Subtract<TQuantity>(TQuantity x, double y)
            where TQuantity : PhysicalQuantityBase
      {
         if (x == null)
         {
            return default(TQuantity);
         }
         TQuantity result = (TQuantity)x.MemberwiseClone();

         result.Value = x.Value - y;
         return result;
      }

      /// <summary>
      /// Multiplies two physical quantities.
      /// The unit of the left operand is the unit of the return value.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The product of the two operands.</returns>
      protected static TQuantity Multiply<TQuantity>(TQuantity x, TQuantity y)
         where TQuantity : PhysicalQuantityBase
      {
         if (x == null || y == null)
         {
            return null;
         }

         TQuantity result = (TQuantity)x.MemberwiseClone();
         TQuantity yNormalized = (TQuantity)y.ConvertTo(x.Unit);

         result.Value = x.Value * yNormalized.Value;
         return result;
      }

      /// <summary>
      /// Multiplies a quantity by an integer.
      /// </summary>
      /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The product of the two operands.</returns>
      protected static TQuantity Multiply<TQuantity>(TQuantity x, int y)
         where TQuantity : PhysicalQuantityBase
      {
         if (x == null)
         {
            return default(TQuantity);
         }
         TQuantity result = (TQuantity)x.MemberwiseClone();

         result.Value = x.Value * y;
         return result;
      }

      /// <summary>
      /// Multiplies a quantity by a double.
      /// </summary>
      /// <typeparam name="TQuantity"></typeparam>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns>The product of the two operands.</returns>
      protected static TQuantity Multiply<TQuantity>(TQuantity x, double y)
         where TQuantity : PhysicalQuantityBase
      {
         if (x == null)
         {
            return default(TQuantity);
         }
         TQuantity result = (TQuantity)x.MemberwiseClone();

         result.Value = x.Value * y;
         return result;
      }

      /// <summary>
      /// Divides two quantities.
      /// </summary>
      /// <typeparam name="TQuantity"></typeparam>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      protected static TQuantity Divide<TQuantity>(TQuantity x, TQuantity y)
         where TQuantity : PhysicalQuantityBase
      {
         if (x == null || y == null)
         {
            return null;
         }
         TQuantity result = (TQuantity)x.MemberwiseClone();
         TQuantity yNormalized = (TQuantity)y.ConvertTo(x.Unit);

         result.Value = x.Value / yNormalized.Value;
         return result;
      }

      /// <summary>
      /// Divides a quantity by an integer.
      /// </summary>
      /// <typeparam name="TQuantity"></typeparam>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      protected static TQuantity Divide<TQuantity>(TQuantity x, int y)
         where TQuantity : PhysicalQuantityBase
      {
         if (x == null)
         {
            return default(TQuantity);
         }
         TQuantity result = (TQuantity)x.MemberwiseClone();

         result.Value = x.Value / y;
         return result;
      }

      /// <summary>
      /// Divides a quantity by a double.
      /// </summary>
      /// <typeparam name="TQuantity"></typeparam>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      protected static TQuantity Divide<TQuantity>(TQuantity x, double y)
         where TQuantity : PhysicalQuantityBase
      {
         if (x == null)
         {
            return default(TQuantity);
         }
         TQuantity result = (TQuantity)x.MemberwiseClone();

         result.Value = x.Value / y;
         return result;
      }

      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      protected PhysicalQuantityBase ConvertTo(UnitBase newUnit)
      {
         PhysicalQuantityBase a = (PhysicalQuantityBase)this.MemberwiseClone();
         a.ConvertToInternal(newUnit);

         return a;
      }

      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings:
      /// Value Meaning Less than zero This object is less than the <paramref name="other"/>
      /// parameter.Zero This object is equal to <paramref name="other"/>.
      /// Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      protected int CompareToInternal(PhysicalQuantityBase other)
      {
         if (other == null)
         {
            return 1;
         }
         // normalization
         PhysicalQuantityBase otherNormalized = (PhysicalQuantityBase)other.MemberwiseClone();
         otherNormalized = otherNormalized.ConvertTo(this.Unit);

         // same unit, values comparable
         return this.Value.CompareTo(otherNormalized.Value);
      }


      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>. 
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      int IComparable<PhysicalQuantityBase>.CompareTo(PhysicalQuantityBase other)
      {
         return CompareToInternal(other);
      }
      

      /// <summary>
      /// Returns a string that represents the current object.
      /// </summary>
      /// <returns>
      /// A string that represents the current object.
      /// </returns>
      /// <filterpriority>2</filterpriority>
      public override string ToString()
      {
         string stringRepresentation = this.Value.ToString(CultureInfo.InvariantCulture) + " ";
         stringRepresentation += this.Unit.ToString();

         return stringRepresentation;
      }

      /// <summary>
      /// Formats the value of the current instance using the specified format.
      /// </summary>
      /// <returns>
      /// The value of the current instance in the specified format.
      /// </returns>
      /// <param name="format">The format to use.-or- A null reference (Nothing in Visual Basic) to use the default
      /// format defined for the type of the <see cref="T:System.IFormattable"/> implementation.
      /// </param><param name="formatProvider">The provider to use to format the value.-or- A null reference
      /// (Nothing in Visual Basic) to obtain the numeric format information from the current locale setting
      /// of the operating system. </param>
      /// <filterpriority>2</filterpriority>
      public string ToString(string format, IFormatProvider formatProvider)
      {
         return this.Value.ToString(format, formatProvider) + " " + this.Unit.ToString();
      }

      /// <summary>
      /// Do not use
      /// </summary>
      /// <param name="assembly"></param>
      /// <param name="baseType"></param>
      /// <returns></returns>
      [Obsolete("No replacement")]
      public IEnumerable<Type> FindDerivedTypes(Assembly assembly, Type baseType)
      {
         return assembly.GetTypes().Where(t => baseType.IsAssignableFrom(t));
      }

      /// <summary>
      /// Raised whenever the unit has been changed.
      /// </summary>
      public event EventHandler<UnitChangedEventArgs> UnitChanged;

      /// <summary>
      /// Do not use
      /// </summary>
      [Obsolete("No replacement")]
      public event PropertyChangedEventHandler PropertyChanged;

      /// <summary>
      /// Do not use
      /// </summary>
      /// <param name="propertyName"></param>
      [Obsolete("No replacement")]
      protected virtual void OnPropertyChanged(string propertyName)
      {
         PropertyChangedEventHandler handler = PropertyChanged;
         if (handler != null)
         {
            handler(this, new PropertyChangedEventArgs(propertyName));
         }
      }

      #region Serialization support

      

      // ReSharper disable once UnusedMethodReturnValue.Local
      private static IEnumerable<Type> GetKnownTypes()
      {
         return typeof(PhysicalQuantityBase).GetAssignableTypes(TypeExtension.AssignableTypesOption.ResolveGenericTypeDefinitions);
      }

      #endregion
   }
}