





using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The time unit of 1 Volt.
   /// </summary>
   
   public sealed class Volt : VoltageUnit
   {

      /// <summary>
      /// Creates a new unit of 1 Volt
      /// </summary>
      public Volt() 
         : base(1, PhysicsResources.SymbolVolt)
      {
      }

      /// <summary>
      /// Creats an new unit of a multiple of Volt
      /// </summary>
      /// <param name="multiple">The multiple that shall be applied to Volt.</param>
      public Volt(Multiple multiple) : base(multiple, new Volt())
      {
         
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      public override Quantity Quantity
      {
         get { return Quantity.Voltage; }
      }

      #endregion
   }
}