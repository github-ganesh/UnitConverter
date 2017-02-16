

using System;
using System.Collections.Generic;

using Dimensions.Converter.Physics.Dimensions._Framework;
using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// The unitcomposite collection is in charge of 
   /// </summary>
   /// <remarks>Never call Sort() on the internal list. Array.Sort() is not stable.</remarks>
   public class UnitCompositeCollection : IEnumerable<UnitComposite>, IFormattable
   {
      private readonly List<UnitComposite> composites = new List<UnitComposite>();

      /// <summary>
      /// Creates a new instance of a unit composite collection.
      /// </summary>
      public UnitCompositeCollection()
      {        
      }

      /// <summary>
      /// Creates a new instance of a unit composite collection.
      /// </summary>
      public UnitCompositeCollection(IEnumerable<UnitComposite> composites)
      {
         if (composites == null)
         {
            throw new ArgumentNullException("composites");
         }

         this.composites = new List<UnitComposite>(composites);
      }

      /// <summary>
      /// Adds a new unit sorted into the list.
      /// </summary>
      /// <param name="composite"></param>
      public void Add(UnitComposite composite)
      {
         if (composite == null)
         {
            return;
         }

         AddInternal(composite);
      }


      private void AddInternal(UnitComposite composite)
      {
         // joins same units of multiplied by and joins same units of divided by
         // and adds the powers.
         //int index = composites.BinarySearch(composite, new UnitCompositeComparer());

         int index = composites.LinearSearch(composite);
         

         if (index >= 0)
         {
            // a unit of the same kind was found. 
            // add the powers, since x^y * x^z = x^(y+z)
            UnitComposite existing = composites[index];
            UnitComposite toAdd = composite;

            int existingPower = existing.Power;
            int toAddPower = toAdd.Power;

            int sum = existingPower + toAddPower;
            if (sum == 0)
            {
               // a power of zero removes the unit
               composites.RemoveAt(index);
            }

            else if (sum < 0)
            {
               composites.RemoveAt(index);
               composites.Insert(index, new MultipliedByUnit(toAdd, Math.Abs(sum)));
            }
            else // sum > 0
            {
               composites.RemoveAt(index);
               composites.Insert(index, new MultipliedByUnit(toAdd, Math.Abs(sum)));
            }
         }
         else
         {
            // the unit was not found. Here a simple add is sufficient,
            // the sum of powers doesn't need to be considered since there are
            // no others.
            composites.Add(composite);
         }
      }

      /// <summary>
      /// Adds a new divided by unit.
      /// </summary>
      /// <param name="unit"></param>
      /// <param name="power"></param>
      public void DividedBy(UnitBase unit, int power)
      {
         if (unit == null)
         {
            return;
         }
         if (power == 0) 
         {
            // power of 0 equals to 1, so no unit.
            return;
         }

         AddInternal(new DividedByUnit(unit, power));
      }

      /// <summary>
      /// Adds a new multiplied by unit.
      /// </summary>
      /// <param name="unit"></param>
      /// <param name="power"></param>
      public void MultipliedBy(UnitBase unit, int power)
      {
         if (unit == null)
         {
            return;
         }
         if (power == 0)
         {
            // power of 0 equals to 1, so no unit.
            return; 
         }
         AddInternal(new MultipliedByUnit(unit, power));
      }

      /// <summary>
      /// Gets the quantity that results from this collection.
      /// </summary>
      public Quantity Quantity
      {
         // TODO: Here we have to have a look at the units, and the quantities  they describe.
         get { return Quantity.None; }
      }

      /// <summary>
      /// Gets the conversion factor of this unit to the base units.
      /// Creates the product of all conversion factors while respecting their power.
      /// </summary>
      /// <returns>The conversion factor for coherent units.</returns>
      public double ConversionFactor
      {
         get
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
      }

      /// <summary>
      /// Returns an enumerator that iterates through the collection.
      /// </summary>
      /// <returns>
      /// A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.
      /// </returns>
      /// <filterpriority>1</filterpriority>
      public IEnumerator<UnitComposite> GetEnumerator()
      {
         return composites.GetEnumerator();
      }

      /// <summary>
      /// Returns an enumerator that iterates through a collection.
      /// </summary>
      /// <returns>
      /// An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
      /// </returns>
      /// <filterpriority>2</filterpriority>
      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }

      #region Overrides of Object

      /// <summary>
      /// Returns a string that represents the current object.
      /// </summary>
      /// <returns>
      /// A string that represents the current object.
      /// </returns>
      public override string ToString()
      {
         return ToString("", new UnitFormatProvider());
      }

      #endregion

      #region IFormattable Members

      /// <summary>
      /// Formats the value of the current instance using the specified format.
      /// </summary>
      /// <returns>
      /// The value of the current instance in the specified format.
      /// </returns>
      /// <param name="format">The format to use.-or- A null reference (Nothing in Visual Basic) to use the default format defined for the type of the <see cref="T:System.IFormattable"/> implementation. </param><param name="formatProvider">The provider to use to format the value.-or- A null reference (Nothing in Visual Basic) to obtain the numeric format information from the current locale setting of the operating system. </param><filterpriority>2</filterpriority>
      public string ToString(string format, IFormatProvider formatProvider)
      {
         string result = String.Empty; // the neutral element for multiplication.

         foreach (UnitComposite b in composites)
         {
            result += b + PhysicsResources.DotOperator;
            // TODO: group the list of composites by factors and divisors
            // this should be done by the collection of unit composites
         }

         int lastDotIndex = result.LastIndexOf(PhysicsResources.DotOperator, StringComparison.InvariantCulture);
         if (lastDotIndex > 0)
         {
            result = result.Remove(lastDotIndex);
         }
         return result;
      }

      #endregion
   }

   /// <summary>
   /// Provides extension methods 
   /// </summary>
   public static class UnitCompositeExtension
   {
      /// <summary>
      /// Searches in the collection for a unit that is a unit for the same physical dimension as
      /// the <paramref name="unit"/> is for.
      /// </summary>
      /// <param name="collection">The collection to search.</param>
      /// <param name="unit">The unit to search for.</param>
      /// <returns>The index of the first occurrance in the collection. If no item in the collection matches the criteria, this method returns -1.</returns>
      public static int LinearSearch(this IEnumerable<UnitComposite> collection, UnitBase unit)
      {
         int index = 0;
         foreach (UnitComposite c in collection)
         {
            if (unit.Quantity.Equals(c.Quantity))
            {
               return index;
            }
            index++;
         }
         return -1;
      }
   }
}