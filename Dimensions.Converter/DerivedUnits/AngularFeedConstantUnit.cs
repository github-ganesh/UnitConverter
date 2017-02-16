




namespace Dimensions.Converter
{
   /// <summary>
   /// A unit for feed constants based on angular degrees.
   /// </summary>
   
   public class AngularFeedConstantUnit : FeedConstantUnit
   {
      /// <summary>
      /// Creates a new angular feed constant unit based on angle per rotation.
      /// </summary>
      /// <param name="angleUnit">The angle feed per rotation</param>
      /// <param name="rotations">The rotations the angle feed is based on.</param>
      public AngularFeedConstantUnit(PlaneAngleUnit angleUnit, RotationUnit rotations) :
         base(new UnitCompositeCollection(){new MultipliedByUnit(angleUnit, 1), new DividedByUnit(rotations, 1)})         
      {

      }

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      public override Quantity Quantity
      {
         get { return Quantity.AngularFeedConstant; }
      }
   }
}