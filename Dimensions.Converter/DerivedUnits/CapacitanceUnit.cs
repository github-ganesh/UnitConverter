





namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit of capacitance.
   /// </summary>
   
   public class CapacitanceUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of a capacitance unit.
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to the base unit, here Farad.</param>
      /// <param name="symbol">The localized symbol for the unit.</param>
      protected CapacitanceUnit(double conversionFactor, string symbol)
         : base(conversionFactor, symbol)
      {
      }

      /// <summary>
      /// Creates a new instance of a capacitance unit.
      /// </summary>
      /// <param name="multiple">The multiple of the unit.</param>
      /// <param name="unit">The unit the multiple shall be applied to.</param>
      protected CapacitanceUnit(Multiple multiple, CapacitanceUnit unit)
         : base(multiple, unit)
      {
      }

      /// <summary>
      /// Creates a new instance of capacitance based on electric charge and voltage.
      /// </summary>
      /// <param name="chargeUnit">The unit of the electric charge.</param>
      /// <param name="voltageUnit">The unit of the voltage.</param>
      public CapacitanceUnit(ElectricChargeUnit chargeUnit, VoltageUnit voltageUnit)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(chargeUnit, 1), new DividedByUnit(voltageUnit, 1) })
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Capacitance</value>
      public override Quantity Quantity
      {
         get { return Quantity.Capacitance; }
      }

      #endregion Overrides of UnitBase
   }
}