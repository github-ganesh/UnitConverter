





namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit of time.
   /// </summary>
   
   public abstract class TimeUnit : UnitBase
   {
      /// <summary>
      /// Creates a new instance of a time unit.
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to the base unit, here seconds.</param>
      /// <param name="symbol">The localized symbol for the unit.</param>
      protected TimeUnit(double conversionFactor, string symbol)
         : base(conversionFactor, symbol)
      {
      }

      /// <summary>
      /// Creates a new instance of a time unit as a multiple of the base unit, here seconds.
      /// </summary>
      /// <param name="multiple">The multiple to apply to the unit.</param>
      /// <param name="unit">The unit of time.</param>
      protected TimeUnit(Multiple multiple, TimeUnit unit)
         : base(multiple, unit)
      {
      }

      /// <summary>
      /// Creates a new instance of a time unit as a multiple of the base unit, here seconds.
      /// </summary>
      /// <param name="multiple">The multiple to apply to the base unit.</param>
      protected TimeUnit(Multiple multiple)
         : base(multiple, Time.Second)
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Time</value>
      public override Quantity Quantity
      {
         get { return Quantity.Time; }
      }

      #endregion
   }
}