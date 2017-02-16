





namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for density.
   /// </summary>
   
   public class DensitiyUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of a density unit.
      /// </summary>
      /// <param name="mass">The unit for the mass.</param>
      /// <param name="volume">The unit for the volume.</param>
      public DensitiyUnit(MassUnit mass, VolumeUnit volume)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(mass, 1), new DividedByUnit(volume, 1) })
      {
         // density is always mass per volume, so public
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Density</value>
      public override Quantity Quantity
      {
         get { return Quantity.Density; }
      }

      #endregion
   }
}