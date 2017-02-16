




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for an area.
   /// </summary>
   
   public class AreaUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of an area unit based on the provided <paramref name="width"/>
      /// </summary>
      /// <param name="width">A unit of length, that will be used to the power of 2.</param>
      public AreaUnit(LengthUnit width)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(width, 2) })
      {
         // area is always length squared, so make public.
      }

      /// <summary>
      /// Creates a new instance of an area unit based on the provided units for width and length.
      /// </summary>
      /// <param name="widthUnit">The unit of the width</param>
      /// <param name="lengthUnit">The unit of the height</param>
      public AreaUnit(LengthUnit widthUnit, LengthUnit lengthUnit)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(widthUnit, 1), new MultipliedByUnit(lengthUnit, 1)})
      {
         
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Area</value>
      public override Quantity Quantity
      {
         get { return Quantity.Area; }
      }

      #endregion
   }
}