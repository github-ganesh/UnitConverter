


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// The length unit of 1 degree.
   /// </summary>
   
   public sealed class AngleDegree : PlaneAngleUnit
   {
      /// <summary>
      /// Creates a new unit of 1 degree
      /// </summary>
      public AngleDegree()
         : base(2.0 * Math.PI / 360.0, PhysicsResources.SymbolAngleDegree)
      {
      }
   }
}