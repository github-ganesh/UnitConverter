






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The time unit of 1 second.
   /// </summary>
   
   public sealed class Second : TimeUnit
   {
      /// <summary>
      /// Creates a new unit of 1 second
      /// </summary>
      public Second()
         : base(1.0, PhysicsResources.SymbolSecond)
      {
      }

      /// <summary>
      /// Creates multiples of the base unit, here second
      /// </summary>
      /// <param name="multiple">The multiple to apply to the unit of seconds.</param>
      public Second(Multiple multiple)
         : base(multiple, new Second())
      {
      }
   }
}