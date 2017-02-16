





using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The length unit of 1 pound force.
   /// </summary>
   
   public sealed class PoundForce : ForceUnit
   {

      /// <summary>
      /// Creates a new unit of 1 pound force
      /// </summary>
      public PoundForce()
         : base(4.4482216152605, PhysicsResources.SymbolPound)
      {
         // conversion factor given to newton.
         // https://de.wikipedia.org/wiki/Pound-force
      }
   }
}