





namespace Dimensions.Converter
{
   /// <summary>
   /// Gets a unit for MassUnit
   /// </summary>
   
   public class MassUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of a mass unit.
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to the base unit, here Gram.</param>
      /// <param name="symbol">The localized symbol for the unit.</param>
      protected MassUnit(double conversionFactor, string symbol)
         : base(conversionFactor, symbol)
      {
      }

      /// <summary>
      /// Creates multiples of the base unit, here gram.
      /// </summary>
      /// <param name="multiple">The multiple to apply to the base unit of gram.</param>
      /// <param name="unit">The unit the multiple shall be applied to.</param>
      protected MassUnit(Multiple multiple, MassUnit unit)
         : base(multiple, unit)
      {
      }

      /// <summary>
      /// Creates a new mass unit based on density and volume.
      /// </summary>
      /// <param name="densitiyUnit"></param>
      /// <param name="volumeUnit"></param>
      public MassUnit(DensitiyUnit densitiyUnit, VolumeUnit volumeUnit)
         : base(new UnitCompositeCollection { new MultipliedByUnit(densitiyUnit, 1), new MultipliedByUnit(volumeUnit, 1) })
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Mass</value>
      public override Quantity Quantity
      {
         get { return Quantity.Mass; }
      }

      #endregion Overrides of UnitBase
   }
}