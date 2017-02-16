




using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The time unit of 1 day.
   /// </summary>
   
   public sealed class Day : TimeUnit
   {
      /// <summary>
      /// Creates a new unit of 1 day
      /// </summary>
      public Day()
         : base(60 * 60 * 24, PhysicsResources.SymbolDay)
      {
         // conversion factor to the unit of second.
      }
   }
}