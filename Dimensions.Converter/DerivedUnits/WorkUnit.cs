





namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for a Work.
   /// </summary>
   
   public class WorkUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of an Work unit.
      /// Work is power multiplied by time.
      /// </summary>
      /// <param name="power">The unit for the power, the time is multiplied with</param>
      /// <param name="time">The factor of time</param>
      public WorkUnit(PowerUnit power, TimeUnit time)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(power, 1), new MultipliedByUnit(time, 1) })
      {
         // Work is always power multiplied by time, so public.
         // use power for different units.
      }

      /// <summary>
      /// Creates a new instance of a work unit based on voltage and current.
      /// </summary>
      /// <param name="voltageUnit">The unit of the voltage.</param>
      /// <param name="currentUnit">The unit of the current.</param>
      public WorkUnit(VoltageUnit voltageUnit, CurrentUnit currentUnit)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(voltageUnit, 1), new MultipliedByUnit(currentUnit, 1) })
      {
         // Work can also be VA, so public.
      }

      /// <summary>
      /// Creates a new instance of a work unit based on force and travel.
      /// </summary>
      /// <param name="forceUnit">The unit of the force.</param>
      /// <param name="lengthUnit">The length unit of the travel.</param>
      public WorkUnit(ForceUnit forceUnit, LengthUnit lengthUnit)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(forceUnit, 1), new MultipliedByUnit(lengthUnit, 1) })
      {
         // Work can also be Nm, so public.
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Work</value>
      public override Quantity Quantity
      {
         get { return Quantity.Work; }
      }

      #endregion
   }
}