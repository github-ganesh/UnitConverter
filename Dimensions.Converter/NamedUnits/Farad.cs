






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The capacitance unit of Farad
   /// </summary>
   
   public sealed class Farad : CapacitanceUnit
   {
      /// <summary>
      /// Creates a new instance of 1 Farad.
      /// </summary>
      public Farad() : base(1.0, PhysicsResources.SymbolFarad)
      {
      }

      /// <summary>
      /// Creates a new multiple of Farad.
      /// </summary>
      /// <param name="multiple">The multiple of the unit.</param>
      public Farad(Multiple multiple) : base(multiple, new Farad())
      {
      }


   }
}