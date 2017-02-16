



using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the current unit of ampere.
   /// </summary>
   
   public sealed class Ampere : CurrentUnit
   {
      /// <summary>
      /// Creates a new instance of a current unit.
      /// </summary>
      public Ampere()
         : base(1.0, PhysicsResources.SymbolAmpere)
      {
      }

      /// <summary>
      /// Creates a new instance of a current unit.
      /// </summary>
      /// <param name="multiple">The multiple to the base unit.</param>
      public Ampere(Multiple multiple)
         : base(multiple, new Ampere())
      {
      }
   }
}