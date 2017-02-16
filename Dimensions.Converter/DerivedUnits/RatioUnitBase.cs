





namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for torque.
   /// </summary>
   
   public abstract class RatioUnitBase : CoherentUnitBase
   {
      /// <summary>
      ///
      /// </summary>
      /// <param name="conversionFactor"></param>
      /// <param name="symbol"></param>
      protected RatioUnitBase(double conversionFactor, string symbol)
         : base(conversionFactor, symbol)
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Torque</value>
      public override Quantity Quantity
      {
         get { return Quantity.Ratio; }
      }

      #endregion Overrides of UnitBase
   }
}