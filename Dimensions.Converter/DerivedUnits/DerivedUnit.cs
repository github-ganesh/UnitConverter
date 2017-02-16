




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a generic derived unit.
   /// </summary>
   
   public class DerivedUnit : CoherentUnitBase
   {
      private readonly Quantity quantity;
      /// <summary>
      /// Creates a new instance of an derived unit.
      /// </summary>
      public DerivedUnit(UnitCompositeCollection units, Quantity quantity)
         : base(new UnitCompositeCollection(units))
      {
         this.quantity = quantity;
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      public override Quantity Quantity
      {
         get { return this.quantity; }
      }

      #endregion
   }
}