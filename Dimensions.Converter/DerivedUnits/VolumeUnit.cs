





namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for a volume.
   /// </summary>
   
   public class VolumeUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of an volume unit.
      /// </summary>
      /// <param name="width">The unit for 1 dimension, like length: meters</param>
      public VolumeUnit(LengthUnit width)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(width, 3) })
      {
         // volume is always l³, so public.
      }

      /// <summary>
      /// Creates a new volume unit. Use this for custom units
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to be applied to the base unit, here 1 cubic meter</param>
      /// <param name="symbol">The symbol for the unit.</param>
      protected VolumeUnit(double conversionFactor, string symbol)
         : base(conversionFactor, symbol)
      {
      }

      /// <summary>
      /// Creates a new multiple of the base unit.
      /// </summary>
      /// <param name="multiple">The multiple to be applied to the unit.</param>
      /// <param name="unit">The unit of the volume.</param>
      protected VolumeUnit(Multiple multiple, VolumeUnit unit)
         : base(multiple, unit)
      {
         // for custom units.
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Volume</value>
      public override Quantity Quantity
      {
         get { return Quantity.Volume; }
      }

      #endregion
   }
}