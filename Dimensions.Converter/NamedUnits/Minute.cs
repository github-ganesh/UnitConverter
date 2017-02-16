






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The time unit of 1 Minute.
   /// </summary>
   
   public sealed class Minute : TimeUnit
   {

      /// <summary>
      /// Creates a new unit of 1 Minute
      /// </summary>
      public Minute() 
         : base(60, PhysicsResources.SymbolMinute)
      {
         // conversion factor to the unit of second.
      }
   }
}