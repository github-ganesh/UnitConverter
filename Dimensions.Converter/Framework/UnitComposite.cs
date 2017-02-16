


using System;


using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// Base class for units that are part of a composite unit.
   /// </summary>
   
   public abstract class UnitComposite
      : UnitBase
   {
      #region Overrides of UnitBase

      private Quantity quantity;
      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      public override Quantity Quantity
      {
         get { return this.quantity; }
      }

      #endregion

      /// <summary>
      /// Creates a new instance of a unit composite which are part of
      /// <see cref="CoherentUnitBase"/>
      /// </summary>
      /// <param name="unit">The unit of this composite</param>
      /// <param name="power">The power of this composite in which it appears in the <see cref="CoherentUnitBase"/></param>
      /// <exception cref="ArgumentOutOfRangeException">Thrown, if power is equal to 0.</exception>
      protected UnitComposite(UnitBase unit, int power)
         : base(unit.ConversionFactor, unit.Symbol)
      {
         if (power == 0)
         {
            // a power of 0 is not acceptable, since the result would be a scalar of 1.
            throw new ArgumentOutOfRangeException("power");
         }

         this.Power = power;
         this.quantity = unit.Quantity;
      }

      /// <summary>
      /// Gets the power of this unit. This can be different from 1 in composite units.
      /// </summary>
      /// <example>
      /// - Speed is defined in m/s. m is to the power of 1, s is to the power of -1.
      /// - Acceleration is defined in m/s². m is to the power of 1, s² is to the power of -2.</example>
      public int Power { get; protected set; }


      #region Overrides of Object

      /// <summary>
      /// Returns a string that represents the current object.
      /// </summary>
      /// <returns>
      /// A string that represents the current object.
      /// </returns>
      public override string ToString()
      {
         // power can never be 0
         // here we write the unit symbol

         string stringValue = base.ToString();
         if (Power < 0)
         {
            stringValue += PhysicsResources.SuperScriptMinus;

            switch (Math.Abs(Power))
            {
               case 1:
                  stringValue += PhysicsResources.SuperScript1;
                  break;

               case 2:
                  stringValue += PhysicsResources.SuperScript2;
                  break;

               case 3:
                  stringValue += PhysicsResources.SuperScript3;
                  break;

               case 4:
                  stringValue += PhysicsResources.SuperScript4;
                  break;
            }
         }

         if (Power > 0)
         {
            switch (Math.Abs(Power))
            {
               // 1 does not need to be written unless the power is negative
               case 2:
                  stringValue += PhysicsResources.SuperScript2;
                  break;

               case 3:
                  stringValue += PhysicsResources.SuperScript3;
                  break;

               case 4:
                  stringValue += PhysicsResources.SuperScript4;
                  break;
            }
         }

         return stringValue;
      }

      #endregion Overrides of Object
      
   }
}