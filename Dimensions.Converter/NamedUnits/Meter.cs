





using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The length unit of 1 meter.
   /// </summary>
   
   public sealed class Meter : LengthUnit
   {

      /// <summary>
      /// Creates a new unit of 1 meter
      /// </summary>
      public Meter() 
         : base(1.0, PhysicsResources.SymbolMeter)
      {
      }

      /// <summary>
      /// Creates multiples of the base unit, here meter
      /// </summary>
      /// <param name="multiple">The multiple to apply to the unit of meters.</param>
      public Meter(Multiple multiple) 
         : base(multiple, new Meter())
      {
      }
   }
}