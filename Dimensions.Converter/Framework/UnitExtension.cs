


namespace Dimensions.Converter
{
   /// <summary>
   /// Provides methods to extract information from <see cref="Unit"/>
   /// </summary>
   public static class UnitExtension
   {
      /// <summary>
      /// Gets the unit system the given <see cref="Unit"/> belongs to.
      /// </summary>
      /// <param name="unit">The unit to examine</param>
      /// <returns>The unit sytem the <paramref name="unit"/> belongs to</returns>
      public static UnitSystem GetUnitSystem(this Unit unit)
      {
         return (UnitSystem)((int)unit & (0xFFFF << 24));
      }
   }
}