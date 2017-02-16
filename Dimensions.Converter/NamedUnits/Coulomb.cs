





using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The capacitance unit of Farad
   /// </summary>
   
   public sealed class Coulomb : ElectricChargeUnit
   {
      /// <summary>
      /// Constructor for base units.
      /// </summary>
      /// <param name="multiple">The multiple that shall be applied to the base unit</param>
      public Coulomb(Multiple multiple)
         : base(multiple, new Coulomb())
      {
      }

      /// <summary>
      /// For coherent units that have a dedicated symbol too.
      /// </summary>
      public Coulomb()
         : base(1.0, PhysicsResources.SymbolCoulomb)
      {
      }
   }
}