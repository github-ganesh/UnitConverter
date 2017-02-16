





using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the length unit of 1 mile
   /// </summary>
   
   public sealed class Mile : LengthUnit
   {
      /// <summary>
      /// Creates a new instance of 1 mile
      /// </summary>
      public Mile()
         : base(1609.344, PhysicsResources.SymbolMile)
      {
         
      }
   }
}