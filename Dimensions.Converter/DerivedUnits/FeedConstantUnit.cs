





namespace Dimensions.Converter
{
   /// <summary>
   /// A unit for feed constants based on distance.
   /// </summary>
   
   public abstract class FeedConstantUnit : DerivedUnit
   {


      /// <summary>
      /// Creates a new distance feed constant unit based distance per rotation
      /// </summary>
      /// <param name="units">The distance feed per rotation</param>
      protected FeedConstantUnit(UnitCompositeCollection units) :         
         base(units, Quantity.FeedConstant)         
      {
      }
   }
}