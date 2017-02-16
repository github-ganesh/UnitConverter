






namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for jerk.
   /// </summary>
   
   public class GenericJerkUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new unit for jerk.
      /// </summary>
      /// <param name="units"></param>
      /// <param name="time"></param>
      public GenericJerkUnit(GenericUnit units, TimeUnit time)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(units, 1), new DividedByUnit(time, 3) })
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