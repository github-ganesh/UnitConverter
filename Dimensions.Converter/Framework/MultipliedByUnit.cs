

using System;



namespace Dimensions.Converter
{
   /// <summary>
   /// Decorator for units that must be multiplied with in composite units.
   /// </summary>
   
   public class MultipliedByUnit : UnitComposite
   {


      /// <summary>
      /// Decorates a unit with a positive power.
      /// </summary>
      /// <param name="unit">The unit that is multiplied with.</param>
      /// <param name="power">The power of that unit that.</param>
      public MultipliedByUnit(UnitBase unit, int power)
         : base(unit, Math.Abs(power))
      {
      }

      #region Overrides of UnitBase


      #endregion
   }
}