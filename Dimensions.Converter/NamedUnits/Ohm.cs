






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// Represents the resistance unit of Ohm.
   /// </summary>
   
   public sealed class Ohm : ResistanceUnit
   {
      /// <summary>
      /// Creates the unit of Ohm.
      /// </summary>
      public Ohm()
         : base(1.0, PhysicsResources.SymbolOhm)
      {
      }

      /// <summary>
      /// Creates a new instance of 1 Ohm.
      /// </summary>
      /// <param name="multiple">The multiple that shall be applied to the unit.</param>
      public Ohm(Multiple multiple)
         : base(multiple, new Ohm())
      {
      }
   }
}