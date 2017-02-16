





namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for torque.
   /// </summary>
   
   public class TorqueUnit : CoherentUnitBase
   {
      /// <summary>
      /// Creates a new instance of a torque unit.
      /// </summary>
      /// <param name="force">The unit of the force.</param>
      /// <param name="length">The unit of the length</param>
      public TorqueUnit(ForceUnit force, LengthUnit length)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(force, 1), new MultipliedByUnit(length, 1) })
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Torque</value>
      public override Quantity Quantity
      {
         get { return Quantity.Torque; }
      }

      #endregion Overrides of UnitBase
   }
}