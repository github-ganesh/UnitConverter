





using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The length unit of 1 Rad.
   /// </summary>
   
   public sealed class Rad : PlaneAngleUnit
   {

      /// <summary>
      /// Creates a new unit of 1 Rad
      /// </summary>
      public Rad() 
         : base(1.0, PhysicsResources.SymbolRad)
      {
      }

   }
}