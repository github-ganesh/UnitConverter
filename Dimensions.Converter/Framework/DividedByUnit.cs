





namespace Dimensions.Converter
{
   /// <summary>
   /// Decorator for units that must be divided by in composite units.
   /// </summary>
   
   public class DividedByUnit : UnitComposite
   {
      private readonly Quantity quantity;
      /// <summary>
      /// Decorates a unit with a negative power.
      /// </summary>
      /// <param name="unit"></param>
      /// <param name="power"></param>
      public DividedByUnit(UnitBase unit, int power)
         : base(unit, -(power))
      {
         // there is deliberately no Math.Abs(power).
         // negative powers are already divided by and can become multipled by then.
         this.quantity = unit.Quantity;
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      public override Quantity Quantity
      {
         get { return quantity; }
      }

      #endregion
   }
}