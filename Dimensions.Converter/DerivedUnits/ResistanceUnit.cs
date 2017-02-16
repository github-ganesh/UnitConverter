





namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for electric resistance.
   /// </summary>
   
   public class ResistanceUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of a resistance unit.
      /// </summary>
      /// <param name="voltage">The voltage difference</param>
      /// <param name="current">The electric current.</param>
      public ResistanceUnit(VoltageUnit voltage, CurrentUnit current)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(voltage, 1), new DividedByUnit(current, 1) })
      {
         // resistance is always voltage over current, so public
      }

      /// <summary>
      /// Creates a new instance of a resistance unit.
      /// </summary>
      /// <param name="multiple">The conversion factor to the base unit, here seconds.</param>
      /// <param name="resistanceUnit">The unit of the resistance.</param>
      protected ResistanceUnit(Multiple multiple, ResistanceUnit resistanceUnit)
         : base(multiple, resistanceUnit)
      {
      }

      /// <summary>
      /// Creates a new instance of a resistance unit.
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to apply to this unit.</param>
      /// <param name="symbol">The symbol for this unit.</param>
      protected ResistanceUnit(double conversionFactor, string symbol)
         : base(conversionFactor, symbol)
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.ElectricResistance</value>
      public override Quantity Quantity
      {
         get { return Quantity.ElectricResistance; }
      }

      #endregion Overrides of UnitBase
   }
}