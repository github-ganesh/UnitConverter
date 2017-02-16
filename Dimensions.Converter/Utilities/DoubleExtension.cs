

using System;


namespace Dimensions.Converter
{
   /// <summary>
   /// Provides methods operated on double values.
   /// </summary>
   public static class DoubleExtension
   {
      private static readonly double tolerance = 0.00000001;

      /// <summary>
      /// Checks two double values for equality while accepting tolerance
      /// and taking care of edge cases.
      /// </summary>
      /// <param name="value"></param>
      /// <param name="other"></param>
      /// <returns></returns>
      public static bool DoubleEquals(this double value, double other)
      {
         // TODO: Watch out for edge cases
         if (other.Equals(0.0) && value.Equals(0.0))
         {
            return true;
         }
         if (Double.IsInfinity(value) && Double.IsInfinity(other) ||
             Double.IsNaN(value) && Double.IsNaN(other))
         {
            return true;
         }

         // compare the relative error with the tolerance
         if (Math.Abs((value - other) / other) < tolerance)
         {
            return true;
         }

         return false;
      }
   }
}