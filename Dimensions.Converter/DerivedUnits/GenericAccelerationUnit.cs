





namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for acceleration.
   /// </summary>
   
   public class GenericAccelerationUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of an acceleration unit.
      /// </summary>
      /// <param name="unit">The generic unit</param>
      /// <param name="time">The time unit</param>
      public GenericAccelerationUnit(GenericUnit unit, TimeUnit time)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(unit, 1), new DividedByUnit(time, 2) })
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      public override Quantity Quantity
      {
         get { return Quantity.Acceleration; }
      }

      #endregion Overrides of UnitBase
   }
}