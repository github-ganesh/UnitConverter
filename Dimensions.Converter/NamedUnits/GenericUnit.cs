





using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a generic unit.
   /// </summary>
   
   public sealed class GenericUnit : UnitBase
   {
      /// <summary>
      /// Creates a new instance of a generic unit.
      /// </summary>
      public GenericUnit()
         : base(1.0, PhysicsResources.NameGenericUnit)
      {
      }

      /// <summary>
      /// Creates a new instance of a generic unit.
      /// </summary>
      /// <param name="multiple">The multiple to the base unit.</param>
      public GenericUnit(Multiple multiple)
         : base(multiple, new GenericUnit())
      {
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Generic</value>
      public override Quantity Quantity
      {
         get { return Quantity.None; }
      }

      #endregion Overrides of UnitBase
   }
}