





using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The time unit of 1 hour.
   /// </summary>
   
   public sealed class Hour : TimeUnit
   {
      /// <summary>
      /// Creates a new unit of 1 hour
      /// </summary>
      public Hour()
         : base(60 * 60, PhysicsResources.SymbolHour)
      {
         // conversion factor to the unit of seconds
      }
   }
}