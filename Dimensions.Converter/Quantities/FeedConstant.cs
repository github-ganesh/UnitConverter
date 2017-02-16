


using Dimensions.Converter.Properties;
using System;




namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a feed constant based on angle per rotation.
   /// </summary>
   
   public class FeedConstant
      : PhysicalQuantityBase, IComparable<FeedConstant>
   {
      #region static convenience properties

      private static readonly AngularFeedConstantUnit DegreePerRotationUnit = new AngularFeedConstantUnit(PlaneAngle.Degree, new RotationUnit());
      private static readonly DistanceFeedConstantUnit MillimeterPerRotationUnit = new DistanceFeedConstantUnit(Length.Millimeter, new RotationUnit());
      private static readonly DistanceFeedConstantUnit InchPerRotationUnit = new DistanceFeedConstantUnit(Length.Inch, new RotationUnit());
      private static readonly GenericFeedConstantUnit UnitsPerRotationUnit = new GenericFeedConstantUnit(new GenericUnit(), new RotationUnit());

      /// <summary>
      /// Gets an angular feed constant unit of 1 degree per rotation.
      /// </summary>
      public static AngularFeedConstantUnit DegreePerRotation
      {
         get { return DegreePerRotationUnit; }
      }

      /// <summary>
      /// Gets an distance feed constant unit of 1 millimeter per rotation.
      /// </summary>
      public static DistanceFeedConstantUnit MillimeterPerRotation
      {
         get { return MillimeterPerRotationUnit; }
      }

      /// <summary>
      /// Gets a distance feed constant unit of 1 inch per rotation.
      /// </summary>
      public static DistanceFeedConstantUnit InchPerRotation
      {
         get { return InchPerRotationUnit; }
      }

      /// <summary>
      /// Gets an angular feed constant unit of 1 unit per rotation.
      /// </summary>
      public static GenericFeedConstantUnit UnitsPerRotation
      {
         get { return UnitsPerRotationUnit; }
      }

      #endregion

      /// <summary>
      /// Base constructor for all physical quantities.
      /// </summary>
      /// <param name="value">The numerical value of the physical quantity in the given unit.</param>
      /// <param name="unit">The unit of the quantity.</param>
      public FeedConstant(double value, FeedConstantUnit unit)
         : base(value, unit)
      {
      }

      #region Overrides of PhysicalQuantityBase

      /// <summary>
      /// Gets the localized name of the quantity.
      /// </summary>
      public override string Name
      {
         get { return PhysicsResources.NameFeedConstant; }
      }

      /// <summary>
      /// Gets an enumeration value this dimension represents.
      /// </summary>
      public override Quantity Dimension
      {
         get { return Quantity.FeedConstant; }
      }

      #endregion Overrides of PhysicalQuantityBase

      #region operator +

      /// <summary>
      /// Performs an add operation on two feed constants.
      /// </summary>
      /// <param name="x">A feed constant to perform the addition</param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator +(FeedConstant x, FeedConstant y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator +(FeedConstant x, int y)
      {
         return Add(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator +(int x, FeedConstant y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator +(double x, FeedConstant y)
      {
         return Add(y, x);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator +(FeedConstant x, double y)
      {
         return Add(x, y);
      }

      #endregion operator +

      #region operator -
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator -(FeedConstant x, FeedConstant y)
      {
         return Subtract(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator -(int x, FeedConstant y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator -(FeedConstant x, int y)
      {
         return Subtract(x, y);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator -(double x, FeedConstant y)
      {
         return Subtract(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator -(FeedConstant x, double y)
      {
         return Subtract(x, y);
      }

      #endregion operator -

      #region operator *
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator *(FeedConstant x, FeedConstant y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator *(FeedConstant x, int y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator *(int x, FeedConstant y)
      {
         return Multiply(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator *(FeedConstant x, double y)
      {
         return Multiply(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator *(double x, FeedConstant y)
      {
         return Multiply(y, x);
      }

      #endregion operator *

      #region operator /

      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator /(FeedConstant x, FeedConstant y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator /(FeedConstant x, int y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator /(int x, FeedConstant y)
      {
         return Divide(y, x);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator /(FeedConstant x, double y)
      {
         return Divide(x, y);
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static FeedConstant operator /(double x, FeedConstant y)
      {
         return Divide(y, x);
      }

      #endregion operator /
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >(FeedConstant x, FeedConstant y)
      {
         return x.CompareTo(y) > 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <(FeedConstant x, FeedConstant y)
      {
         return x.CompareTo(y) < 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator >=(FeedConstant x, FeedConstant y)
      {
         return x.CompareTo(y) >= 0;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <returns></returns>
      public static bool operator <=(FeedConstant x, FeedConstant y)
      {
         return x.CompareTo(y) <= 0;
      }

      #region Implementation of IComparable<FeedConstant>

      /// <summary>
      /// Compares the current object with another object of the same type.
      /// </summary>
      /// <returns>
      /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public int CompareTo(FeedConstant other)
      {
         return CompareToInternal(other);
      }

      #endregion Implementation of IComparable<FeedConstant>
   }
}