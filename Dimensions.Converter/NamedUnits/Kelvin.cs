






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The temperature unit of 1 Kelvin.
   /// </summary>
   
   public sealed class Kelvin : TemperatureUnit
   {

      /// <summary>
      /// Creates a new unit of 1 Kelvin.
      /// </summary>
      public Kelvin() 
         : base(1.0, 273.15, PhysicsResources.SymbolTemperatureKelvin)
      {
         // Kelvin has an offset of -273.15 to Celsius, the base unit.
      }
   }
}