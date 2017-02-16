





namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for jerk.
   /// </summary>
   
   public class JerkUnit<T> : CoherentUnitBase where T : PhysicalQuantityBase
   {
      /// <summary>
      /// Creates a new instance of a jerk unit.
      /// </summary>
      /// <param name="length">The lenth unit</param>
      /// <param name="time">The time unit</param>
      public JerkUnit(T length, TimeUnit time)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(length.Unit, 1), new DividedByUnit(time, 3) })
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      public override Quantity Quantity
      {
         get { return Quantity.Jerk; }
      }

      #endregion Overrides of UnitBase
   }
}