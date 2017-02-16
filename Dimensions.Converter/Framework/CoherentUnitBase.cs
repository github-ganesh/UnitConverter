

using System;
using System.Collections.Generic;



namespace Dimensions.Converter
{
   /// <summary>
   /// Describes coherent units, that is, those that are composed of other base units.
   /// </summary>
   
   public abstract class CoherentUnitBase : UnitBase
   {
      /// <summary>
      /// Use this constructor for composite units.
      /// </summary>
      protected CoherentUnitBase(IEnumerable<UnitComposite> composites)
         : base(GetConversionFactor(composites), composites.ToString())
      {
         this.Composites = composites;
      }

      /// <summary>
      /// Constructor for both coherent and base units
      /// </summary>
      /// <param name="baseUnit">The base unit.</param>
      protected CoherentUnitBase(UnitBase baseUnit)
         : this(new UnitCompositeCollection() { new MultipliedByUnit(baseUnit, 1) })
      { }

      /// <summary>
      /// Constructor for base units.
      /// </summary>
      /// <param name="multiple">The multiple that shall be applied to the base unit</param>
      /// <param name="baseUnit">The base unit.</param>
      protected CoherentUnitBase(Multiple multiple, UnitBase baseUnit)
         : base(multiple, baseUnit)
      { }

      /// <summary>
      /// For coherent units that have a dedicated symbol too.
      /// </summary>
      /// <param name="conversionFactor"></param>
      /// <param name="symbol"></param>
      protected CoherentUnitBase(double conversionFactor, string symbol)
         : base(conversionFactor, symbol)
      {
      }

      /// <summary>
      /// The list of composites this coherent unit is composed of.
      /// </summary>
      public IEnumerable<UnitComposite> Composites { get; protected set; }

      #region Overrides of UnitBase

      /// <summary>
      /// Defines the conversion factor to the base SI unit.
      /// </summary>
      public override double ConversionFactor
      {
         get
         {
            if (this.Composites == null)
            {
               return base.ConversionFactor;
            }
            return GetConversionFactor(this.Composites);
         }
      }

      #endregion Overrides of UnitBase

      /// <summary>
      /// Gets the conversion factor of this unit to the base units.
      /// Creates the product of all conversion factors while respecting their power.
      /// </summary>
      /// <param name="composites"></param>
      /// <returns>The conversion factor for coherent units.</returns>
      protected static double GetConversionFactor(IEnumerable<UnitComposite> composites)
      {
         double result = 1.0; // the neutral element for multiplication.

         foreach (UnitComposite b in composites)
         {
            // the conversion factor can be considered as the product of all composites while respecting their power.
            double c = Math.Pow(b.ConversionFactor, b.Power);
            result = result * c;
         }

         return result;
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Returns the symbol of the unit (the short unit name)
      /// </summary>
      /// <returns>
      /// A string that represents the current object.
      /// </returns>
      public override string ToString()
      {
         if (this.Composites == null)
         {
            return this.Symbol;
         }
         return this.Composites.ToString();
      }

      #endregion
   }
}