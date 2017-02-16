






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the volume of 1 litre.
   /// </summary>
   
   public sealed class Litre : VolumeUnit
   {
      /// <summary>
      /// Creates the unit of 1 litre.
      /// </summary>
      public Litre()
         : base(0.001, PhysicsResources.SymbolLitre)
      {
      }

      /// <summary>
      /// Creates a multiple of 1 litre.
      /// </summary>
      /// <param name="multiple">The multiple to be applied to 1 litre.</param>
      public Litre(Multiple multiple)
         : base(multiple, new Litre())
      {
      }
   }
}