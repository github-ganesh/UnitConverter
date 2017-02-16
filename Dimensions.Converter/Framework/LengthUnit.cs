


using System;



namespace Dimensions.Converter
{
   /// <summary>
   /// Gets a unit for length
   /// </summary>
   
   public abstract class LengthUnit : UnitBase, IComparable<LengthUnit>
   {
      /// <summary>
      /// Creates a new instance of a length unit. Use this
      /// for user defined lengths by creating a deriving class.
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to the base unit, here meter</param>
      /// <param name="symbol">The localized symbol for the unit.</param>
      protected LengthUnit(double conversionFactor, string symbol)
         : base(conversionFactor, symbol)
      {
      }

      /// <summary>
      /// Creates multiples of the base unit, here meter
      /// </summary>
      /// <param name="multiple">The multiple to apply to the base unit of meters.</param>
      /// <param name="unit">The unit the multiple shall be applied to.</param>
      protected LengthUnit(Multiple multiple, LengthUnit unit)
         : base(multiple, unit)
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      public override Quantity Quantity
      {
         get { return Quantity.Length; }
      }

      #endregion

      #region IComparable<LengthUnit> Members

      public int CompareTo(LengthUnit other)
      {
         if (other == null)
         {
            return 1;
         }

         return this.ConversionFactor.CompareTo(other.ConversionFactor);
      }

      #endregion
   }
}