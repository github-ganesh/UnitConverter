






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// represents the mass unit of ton.
   /// </summary>
   
   public sealed class Ton : MassUnit
   {
      /// <summary>
      /// creates a new instance of a ton.
      /// </summary>
      public Ton()
         : base(1.0, PhysicsResources.SymbolTon)
      {        
      }

      /// <summary>
      /// Creates an new multiple of a ton.
      /// </summary>
      /// <param name="multiple">The multiple that shall be applied to ton. Should be > 10 only.</param>
      public Ton(Multiple multiple) : base(multiple, new Ton())
      { }
   }
}