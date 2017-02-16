




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for speed.
   /// </summary>
   
   public class AngularSpeedUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of an angular speed unit.
      /// </summary>
      /// <param name="angle">The unit for the angle travelled.</param>
      /// <param name="time">The timeframe for the angle travelled</param>
      public AngularSpeedUnit(PlaneAngleUnit angle, TimeUnit time)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(angle, 1), new DividedByUnit(time, 1) })
      {
         // angular speed is always angle over time.
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.AngularSpeed</value>
      public override Quantity Quantity
      {
         get { return Quantity.AngularSpeed; }
      }

      #endregion
   }
}