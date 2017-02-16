




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit of voltage.
   /// </summary>
   
   public abstract class VoltageUnit : UnitBase
   {
      /// <summary>
      /// Creates a new instance of a voltage unit.
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to the base unit, here seconds.</param>
      /// <param name="symbol">The localized symbol for the unit.</param>
      protected VoltageUnit(double conversionFactor, string symbol)
         : base(conversionFactor, symbol)
      {
      }

      /// <summary>
      /// Creates a multiple of the base unit.
      /// </summary>
      /// <param name="multiple">The multiple that should be applied to the base unit.</param>
      /// <param name="voltageUnit">The unit for the voltage</param>
      protected VoltageUnit(Multiple multiple, VoltageUnit voltageUnit)
         : base(multiple, voltageUnit)
      {
      }
   }
}