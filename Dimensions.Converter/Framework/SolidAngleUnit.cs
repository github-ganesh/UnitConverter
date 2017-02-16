





namespace Dimensions.Converter
{
   /// <summary>
   /// Gets a unit for a plane angle
   /// </summary>
   
   public abstract class SolidAngleUnit : UnitBase
   {
      /// <summary>
      /// Creates a new instance of a solid angle unit. Use this
      /// for user defined lengths by creating a deriving class.
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to the base unit, here sr</param>
      /// <param name="symbol">The localized symbol for the unit.</param>
      protected SolidAngleUnit(double conversionFactor, string symbol)
         : base(conversionFactor, symbol)
      {
      }
   }
}