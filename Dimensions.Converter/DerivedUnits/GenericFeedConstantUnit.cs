





namespace Dimensions.Converter
{
   /// <summary>
   /// A unit for feed constants based on angular degrees.
   /// </summary>
   
   public class GenericFeedConstantUnit : FeedConstantUnit
   {
      /// <summary>
      /// Creates a new angular feed constant unit based on units per rotation.
      /// </summary>
      /// <param name="genericUnit">The angle feed per rotation</param>
      /// <param name="rotations">The rotations the angle feed is based on.</param>
      public GenericFeedConstantUnit(GenericUnit genericUnit, RotationUnit rotations) :
         base(new UnitCompositeCollection(){new MultipliedByUnit(genericUnit, 1), new DividedByUnit(rotations, 1)})         
      {

      }

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      public override Quantity Quantity
      {
         get { return Quantity.GeneralFeedConstant; }
      }
   }
}