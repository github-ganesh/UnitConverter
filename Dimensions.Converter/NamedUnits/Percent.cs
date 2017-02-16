






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the pseudo unit of per cent.
   /// </summary>
   
   public sealed class Percent : RatioUnitBase
   {
      /// <summary>
      /// Creates a new instance of a percent unit.
      /// </summary>
      public Percent()
         : base(100.0, PhysicsResources.SymbolPercent)
      {
      }

      #region overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      public override Quantity Quantity
      {
         get { return Quantity.Ratio; }
      }

      #endregion overrides of UnitBase
   }
}