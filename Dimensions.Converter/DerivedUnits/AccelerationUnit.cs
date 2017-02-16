




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for acceleration.
   /// </summary>
   
   public class AccelerationUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of an acceleration unit.
      /// </summary>
      /// <param name="length">The lenth unit</param>
      /// <param name="time">The time unit</param>
      public AccelerationUnit(LengthUnit length, TimeUnit time)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(length, 1), new DividedByUnit(time, 2) })
      {
         // accleration is always the second derivative of distance over time,
         // therefore this ctor can be made public.
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="units"></param>
      /// <param name="time"></param>
      public AccelerationUnit(GenericUnit units, TimeUnit time)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(units, 1), new DividedByUnit(time, 2) })
      {
      }

      /// <summary>
      /// Creates a new instance of an angular acceleration unit.
      /// </summary>
      /// <param name="angle">The angle unit</param>
      /// <param name="time">The time unit</param>
      public AccelerationUnit(PlaneAngleUnit angle, TimeUnit time)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(angle, 1), new DividedByUnit(time, 2) })
      {
         // accleration is always the second derivative of distance over time,
         // therefore this ctor can be made public.
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