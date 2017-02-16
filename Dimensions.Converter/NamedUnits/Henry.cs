






using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The inductance unit of Henry
   /// </summary>
   
   public sealed class Henry : InductanceUnit
   {
      /// <summary>
      ///  Creates a new instance of the unit of 1 Henry
      /// </summary>
      /// <param name="multiple">The multiple that shall be applied to the base unit</param>
      public Henry(Multiple multiple)
         : base(multiple, new Henry())
      {
      }

      /// <summary>
      /// Creates a new instance of the unit of 1 Henry
      /// </summary>
      public Henry()
         : base(1.0, PhysicsResources.SymbolHenry)
      {
      }
   }
}