






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The length unit of 1 Newton.
   /// </summary>
   
   public sealed class Newton : ForceUnit
   {

      /// <summary>
      /// Creates a new unit of 1 Newton
      /// </summary>
      public Newton() 
         : base(1.0, PhysicsResources.SymbolNewton)
      {
      }

      /// <summary>
      /// Creates multiples of the base unit, here Newton
      /// </summary>
      /// <param name="multiple">The multiple to apply to the unit of Newton.</param>
      public Newton(Multiple multiple) : base(multiple, new Newton())
      {
      }
   }
}