




namespace Dimensions.Converter
{
   /// <summary>
   /// A unit for feed constants based on distance.
   /// </summary>
   
   public class DistanceFeedConstantUnit : FeedConstantUnit
   {
      /// <summary>
      /// Creates a new distance feed constant unit based distance per rotation
      /// </summary>
      /// <param name="distanceUnit">The distance feed per rotation</param>
      /// <param name="rotations">The rotations the distance feed is based on.</param>
      public DistanceFeedConstantUnit(LengthUnit distanceUnit, RotationUnit rotations) :
         base(new UnitCompositeCollection(){new MultipliedByUnit(distanceUnit, 1), new DividedByUnit(rotations, 1)})
      {
      }

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      public override Quantity Quantity
      {
         get { return Quantity.DistanceFeedConstant; }
      }
   }
}