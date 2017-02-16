





namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for inertia.
   /// </summary>
   
   public class InertiaUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of an inertia unit.
      /// </summary>
      /// <param name="massUnit">The unit for the mass.</param>
      /// <param name="areaUnit">The unit for the area.</param>
      public InertiaUnit(MassUnit massUnit, AreaUnit areaUnit)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(massUnit, 1), new MultipliedByUnit(areaUnit, 1) })
      {
         // inertia is always mass times area
      }

      /// <summary>
      /// Creates a new instance of an inertia unit.
      /// </summary>
      /// <param name="massUnit">The unit for the mass.</param>
      /// <param name="lengthUnit">The unit for the length, that will be squared.</param>
      public InertiaUnit(MassUnit massUnit, LengthUnit lengthUnit)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(massUnit, 1), new MultipliedByUnit(lengthUnit, 2)})
      { }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Inertia</value>
      public override Quantity Quantity
      {
         get { return Quantity.Inertia; }
      }

      #endregion Overrides of UnitBase
   }
}