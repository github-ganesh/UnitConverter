






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// Creates the length unit of 1 inch
   /// </summary>
   
   public sealed class Inch : LengthUnit
   {
      /// <summary>
      /// Creates a new instance of 1 inch.
      /// </summary>
      public Inch()
         : base(0.0254, PhysicsResources.SymbolInch)
      {
      }
   }
}