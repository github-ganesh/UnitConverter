






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the mass unit of a gram.
   /// </summary>
   
   public class Gram : MassUnit
   {
      /// <summary>
      /// Creates a new instance of a 1 gram.
      /// </summary>
      public Gram() 
         : base(1.0, PhysicsResources.SymbolGram)
      {
      }

      /// <summary>
      /// Creates multiples of the base unit, here gram.
      /// </summary>
      /// <param name="multiple">The multiple to apply to the base unit of gram.</param>
      public Gram(Multiple multiple) 
         : base(multiple, new Gram())
      {
      }
   }
}