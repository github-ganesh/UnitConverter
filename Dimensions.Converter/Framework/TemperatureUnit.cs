



namespace Dimensions.Converter
{
   /// <summary>
   /// Gets a unit for temperature
   /// </summary>
   
   public abstract class TemperatureUnit : UnitBase
   {

      /// <summary>
      /// Creates a new instance of a temperature unit. Use this
      /// for user defined lengths by creating a deriving class.
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to the base unit, here Kelvin</param>
      /// <param name="offset">A static offset to the base unit</param>
      /// <param name="symbol">The localized symbol for the unit.</param>
      protected TemperatureUnit(double conversionFactor, double offset, string symbol)
         : base(conversionFactor, offset, symbol)
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      public override Quantity Quantity
      {
         get { return Quantity.Temperature; }
      }

      #endregion
   }
}