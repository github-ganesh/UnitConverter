






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// Creates the length unit of 1 foot
   /// </summary>
   
   public sealed class Foot : LengthUnit
   {
      /// <summary>
      /// Creates a new instance of 1 foot.
      /// </summary>
      public Foot()
         : base(0.3048, PhysicsResources.SymbolFoot)
      {
      }
   }
}