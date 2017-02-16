





using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The length unit of 1 Sr.
   /// </summary>
   
   public sealed class Steradiant : SolidAngleUnit
   {

      /// <summary>
      /// Creates a new unit of 1 Sr
      /// </summary>
      public Steradiant() 
         : base(1.0, PhysicsResources.SymbolSr)
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      public override Quantity Quantity
      {
         get { return Quantity.SolidAngle; }
      }

      #endregion
   }
}