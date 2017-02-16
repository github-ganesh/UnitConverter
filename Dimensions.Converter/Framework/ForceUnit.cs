





namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for force.
   /// </summary>
   
   public abstract class ForceUnit : UnitBase
   {
      /// <summary>
      /// Creates a new instance of a unit with a given conversion factor
      /// to it's base unit.
      /// Base units are the SI units, either base or derived.
      /// See the special implementation for details.
      /// </summary>
      /// <param name="conversionFactor">The conversion factor to the base unit</param>
      /// <param name="symbol">The localized symbol for the unit</param>
      protected ForceUnit(double conversionFactor, string symbol)
         : base(conversionFactor, symbol)
      {
      }

      /// <summary>
      /// Creates a new instance of a unit with a given multiple factor
      /// to it's base unit.
      /// Base units are the SI units, either base or derived.
      /// See the special implementation for details.
      /// </summary>
      /// <param name="multiple">The multiple of the base unit</param>
      /// <param name="forceUnit">The unit the multiple shall be applied to.</param>
      protected ForceUnit(Multiple multiple, ForceUnit forceUnit)
         : base(multiple, forceUnit)
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Force</value>
      public override Quantity Quantity
      {
         get { return Quantity.Force; }
      }

      #endregion
   }

   ////public class ForceUnit : CoherentUnitBase
   ////{
   ////   /// <summary>
   ////   /// Gets a new instance for Newton.
   ////   /// </summary>
   ////   public static ForceUnit Newton
   ////   {
   ////      // 1 meter times 1 second to the power of -1. (m * s^-1)
   ////      get { return new ForceUnit(LengthUnit.Meter, TimeUnit.Second); }
   ////   }

   ////   /// <summary>
   ////   /// Gets a new instance for kilometers per hour.
   ////   /// </summary>
   ////   public static ForceUnit KiloNewton
   ////   {
   ////      get { return new ForceUnit(LengthUnit.K, TimeUnit.Hour); }
   ////   }

   ////   /// <summary>
   ////   /// Gets a new instance for miles per hour.
   ////   /// </summary>
   ////   public static ForceUnit DecaNewton
   ////   {
   ////      get { return new ForceUnit(LengthUnit.Mile, TimeUnit.Hour); }
   ////   }

   ////   /// <summary>
   ////   /// Creates a new instance of a speed unit.
   ////   /// </summary>
   ////   /// <param name="length">The unit for the distance travelled.</param>
   ////   /// <param name="time">The timeframe for the revolutions</param>
   ////   public ForceUnit(LengthUnit length, TimeUnit time)
   ////      : base(new UnitCompositeCollection() { new MultipliedByUnit(length, 1), new DividedByUnit(time, 1) })
   ////   {
   ////   }

   ////   /// <summary>
   ////   /// Creates a new instance of a speed unit.
   ////   /// </summary>
   ////   /// <param name="mass">The unit for mass to be accelerated.</param>
   ////   /// <param name="acceleration">The unit for the acceleration</param>
   ////   public ForceUnit(MassUnit mass, AccelerationUnit acceleration)
   ////      : base(new UnitCompositeCollection() { new MultipliedByUnit(mass, 1), new MultipliedByUnit(acceleration, 1) })
   ////   {
   ////   }
   ////}
}