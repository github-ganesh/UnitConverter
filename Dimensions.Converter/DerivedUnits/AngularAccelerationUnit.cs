




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for acceleration.
   /// </summary>
   
   public class AngularAccelerationUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of an angular acceleration unit.
      /// </summary>
      /// <param name="angle">The angle unit</param>
      /// <param name="time">The time unit</param>
      public AngularAccelerationUnit(PlaneAngleUnit angle, TimeUnit time)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(angle, 1), new DividedByUnit(time, 2) })
      {
         // accleration is always the second derivative of distance over time,
         // therefore this ctor can be made public.
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.AngularAcceleration</value>
      public override Quantity Quantity
      {
         get { return Quantity.AngularAcceleration; }
      }

      #endregion Overrides of UnitBase
   }
}