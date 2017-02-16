






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The temperature unit of 1 Fahrenheit.
   /// </summary>
   
   public sealed class Fahrenheit : TemperatureUnit
   {

      /// <summary>
      /// Creates a new unit of 1 Fahrenheit
      /// </summary>
      public Fahrenheit() 
         : base(1.0/1.8, 32, PhysicsResources.SymbolFahrenheit)
      {
        
      }   
   }
}