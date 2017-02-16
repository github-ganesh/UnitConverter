





namespace Dimensions.Converter
{
   /// <summary>
   /// Gets a unit for a plane angle
   /// </summary>
   
   public abstract class PlaneAngleUnit : UnitBase
   {
      /// <summary>
      /// Creates a new instance of a plane angle unit. Use this
      /// for user defined lengths by creating a deriving class.
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to the base unit, here rad</param>
      /// <param name="symbol">The localized symbol for the unit.</param>
      protected PlaneAngleUnit(double conversionFactor, string symbol)
         : base(conversionFactor, symbol)
      {
      }

      /// <summary>
      /// For deriving units that can offer a multiple of the given unit.
      /// </summary>
      /// <param name="multiple">The multiple that shall be applied to the unit</param>
      /// <param name="angleUnit">The concrete unit for the plane angle.</param>
      protected PlaneAngleUnit(Multiple multiple, PlaneAngleUnit angleUnit)
         : base(multiple, angleUnit)
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      public override Quantity Quantity
      {
         get { return Quantity.Angle; }
      }

      #endregion Overrides of UnitBase
   }
}