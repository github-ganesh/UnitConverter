


using System;



namespace Dimensions.Converter
{
   /// <summary>
   /// Enumeration of known unit systems
   /// </summary>
   
   [Flags]
   public enum UnitSystem
   {
      /// <summary>
      /// No unit system selected
      /// </summary>
      
      None = 0,

      /// <summary>
      /// SI units
      /// </summary>
      
      SI = 1, 

      /// <summary>
      /// Empirial units
      /// </summary>
      
      USCustomary = 2,

      /// <summary>
      /// For example
      /// </summary>
      
      Empirial = 4,

      /// <summary>
      /// Units can belong to both unit systems, such as time units.
      /// </summary>
      
      Universal = SI | USCustomary | Empirial, // add other unit systems here as well.
   }

   public interface IUnitSystem : IFormatProvider
   {
      UnitSystem System { get; }
   }
}