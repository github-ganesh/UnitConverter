



namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for power.
   /// </summary>
   
   public class PowerUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of a unit with a given conversion factor
      /// to it's base unit.
      /// Base units are the SI units, either base or derived.
      /// See the special implementation for details.
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to the base unit</param>
      /// <param name="symbol">The localized symbol for the unit</param>
      protected PowerUnit(double conversionFactor, string symbol)
         : base(conversionFactor, symbol)
      {
         // for deriving power units.
      }

      /// <summary>
      /// Creates a multiple of a power unit.
      /// </summary>
      /// <param name="multiple">The multiple that shall be applied to the <paramref name="powerUnit"/></param>
      /// <param name="powerUnit">The unit of power</param>
      protected PowerUnit(Multiple multiple, PowerUnit powerUnit)
         : base(multiple, powerUnit)
      {
         // for deriving power units.
      }

      /// <summary>
      /// Creates a new instance of a electric power.
      /// </summary>
      /// <param name="voltage">The unit for the voltage</param>
      /// <param name="current">The unit for the current</param>
      protected PowerUnit(VoltageUnit voltage, CurrentUnit current)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(voltage, 1), new MultipliedByUnit(current, 1) })
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Power</value>
      public override Quantity Quantity
      {
         get { return Quantity.Power; }
      }

      #endregion Overrides of UnitBase
   }
}