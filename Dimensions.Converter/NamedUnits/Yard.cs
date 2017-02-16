






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the length unit of 1 yard
   /// </summary>
   
   public sealed class Yard : LengthUnit
   {
      /// <summary>
      /// Creates a new instance of 1 yard
      /// </summary>
      public Yard()
         : base(0.9144, PhysicsResources.SymbolYard)
      {
        
      }
   }
}