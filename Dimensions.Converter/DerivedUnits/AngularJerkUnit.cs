





namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for angular jerk.
   /// </summary>
   
   public class AngularJerkUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of an angular jerk unit.
      /// </summary>
      /// <param name="angle">The angle unit</param>
      /// <param name="time">The time unit</param>
      public AngularJerkUnit(PlaneAngleUnit angle, TimeUnit time)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(angle, 1), new DividedByUnit(time, 3) })
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.AngularAcceleration</value>
      public override Quantity Quantity
      {
         get { return Quantity.AngularJerk; }
      }

      #endregion Overrides of UnitBase
   }
}