




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for electric inductance.
   /// </summary>
   
   public class InductanceUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of inductance based on current and time.
      /// </summary>
      public InductanceUnit(CurrentUnit currentUnit, TimeUnit timeUnit) 
         : base(new UnitCompositeCollection(){new MultipliedByUnit(currentUnit, 1), new MultipliedByUnit(timeUnit, 1) })
      {
         // electric charge can be based on current and time, so public.
      }

      /// <summary>
      /// Constructor for base units.
      /// </summary>
      /// <param name="multiple">The multiple that shall be applied to the base unit</param>
      /// <param name="baseUnit">The base unit.</param>
      protected InductanceUnit(Multiple multiple, UnitBase baseUnit) 
         : base(multiple, baseUnit)
      {
      }

      /// <summary>
      /// For coherent units that have a dedicated symbol too.
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to the base unit, here Henry.</param>
      /// <param name="symbol">The symbol for the unit.</param>
      protected InductanceUnit(double conversionFactor, string symbol)
         : base(conversionFactor, symbol)
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Inductance</value>
      public override Quantity Quantity
      {
         get { return Quantity.Inductance; }
      }

      #endregion
   }
}