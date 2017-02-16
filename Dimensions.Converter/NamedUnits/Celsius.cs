




using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The temperature unit of 1 Celsius.
   /// </summary>
   
   public sealed class Celsius : TemperatureUnit
   {
      /// <summary>
      /// Creates a new unit of 1 Celsius
      /// This is the base unit for all temperatures.
      /// </summary>
      public Celsius()
         : base(1.0, 0, PhysicsResources.SymbolCelsius)
      {
         
      }
   }
}