






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The time unit of 1 Watt.
   /// </summary>
   
   public sealed class Watt : PowerUnit
   {

      /// <summary>
      /// Creates a new unit of 1 Watt
      /// </summary>
      public Watt() 
         : base(1, PhysicsResources.SymbolWatt)
      {
      }

      /// <summary>
      /// Creats an new unit of a multiple of Watt
      /// </summary>
      /// <param name="multiple">The multiple that shall be applied to Watt.</param>
      public Watt(Multiple multiple) : base(multiple, new Watt())
      {
         
      }
   }
}