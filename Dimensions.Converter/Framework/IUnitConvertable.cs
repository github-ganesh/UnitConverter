


namespace Dimensions.Converter
{
   /// <summary>
   /// Provides methods to convert a physical quantity into a different
   /// unit system.
   /// </summary>
   /// <typeparam name="TQuantity">The type of the quantity to convert.</typeparam>
   /// <typeparam name="TUnit">The new unit for the quantity.</typeparam>
   public interface IUnitConvertable<TQuantity, TUnit>
      where TQuantity : PhysicalQuantityBase
      where TUnit : UnitBase
   {
      /// <summary>
      /// Converts the value of this quantity into another unit.
      /// This instance is not changed. Use the return value.
      /// </summary>
      /// <param name="newUnit">The new unit this value is converted to.</param>
      /// <returns>A new instance of this quantity in the new unit.</returns>
      TQuantity ConvertTo(TUnit newUnit);
   }
}