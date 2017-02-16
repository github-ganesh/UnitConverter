


using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit of electric current.
   /// </summary>
   
   public abstract class CurrentUnit : UnitBase, IComparable<CurrentUnit>, IEquatable<CurrentUnit>
   {
      /// <summary>
      /// Creates a new instance of a current unit.
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to the base unit</param>
      /// <param name="symbol">The localized symbol for the unit.</param>
      protected CurrentUnit(double conversionFactor, string symbol)
         : base(conversionFactor, symbol)
      {
      }

      /// <summary>
      /// Creates a new instance of a current unit.
      /// </summary>
      /// <param name="multiple">The multiple to the base unit.</param>
      /// <param name="currentUnit">The unit the multiple shall be applied to.</param>
      protected CurrentUnit(Multiple multiple, CurrentUnit currentUnit)
         : base(multiple, currentUnit)
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      ///<value>Quantity.ElectricCurrent</value>
      public override Quantity Quantity
      {
         get { return Quantity.ElectricCurrent; }
      }

      #endregion Overrides of UnitBase

      #region IComparable<CurrentUnit> Members

      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared.
      /// The return value has the following meanings:
      /// Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.
      /// Zero This object is equal to <paramref name="other"/>.
      /// Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(CurrentUnit other)
      {
         if (other == null)
         {
            return 1;
         }

         return this.ConversionFactor.CompareTo(other.ConversionFactor);
      }

      #endregion IComparable<CurrentUnit> Members

      #region IEquatable<CurrentUnit> Members

      /// <summary>
      /// Indicates whether the current object is equal to another object of the same type.
      /// </summary>
      /// <returns>
      /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public bool Equals(CurrentUnit other)
      {
         return CompareTo(other) == 0;
      }

      #endregion
   }
}