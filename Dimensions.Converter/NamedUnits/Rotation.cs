


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// The unit of 1 rotation.
   /// </summary>
   
   public sealed class RotationUnit : PlaneAngleUnit
   {
      /// <summary>
      /// Creates a new unit of 1 rotation, which is equivalent to 2 pi rad.
      /// </summary>
      public RotationUnit()
         : base(2.0 * Math.PI, PhysicsResources.SymbolRotation)
      {
      }

      /// <summary>
      /// Creates a new unit of 1 rotation, which is equivalent to 2 pi rad.
      /// </summary>
      public RotationUnit(Multiple multiple)
         : base(multiple, new RotationUnit())
      {
      }

      #region Overrides of PlaneAngleUnit

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Rotation</value>
      public override Quantity Quantity
      {
         get { return Quantity.Rotation; }
      }

      #endregion Overrides of PlaneAngleUnit
   }
}