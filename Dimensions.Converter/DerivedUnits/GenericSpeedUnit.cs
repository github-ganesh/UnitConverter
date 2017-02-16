





namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for speed.
   /// </summary>
   
   public class GenericSpeedUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of a speed unit.
      /// </summary>
      /// <param name="unit">The unit for the distance travelled.</param>
      /// <param name="time">The timeframe for the distance travelled</param>
      public GenericSpeedUnit(GenericUnit unit, TimeUnit time)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(unit, 1), new DividedByUnit(time, 1) })
      {
         // speed is always distance (length) over time.
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Speed</value>
      public override Quantity Quantity
      {
         get { return Quantity.Speed; }
      }

      #endregion Overrides of UnitBase
   }
}