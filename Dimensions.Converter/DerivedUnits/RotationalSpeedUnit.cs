

using System;



namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for rotational speed.
   /// </summary>
   
   public class RotationalSpeedUnit : AngularSpeedUnit
   {
      private double rotations;

      /// <summary>
      /// Constructor for 1 revolution per duration
      /// </summary>
      /// <param name="time">The time unit for the revolutions</param>
      public RotationalSpeedUnit(TimeUnit time)
         : base(new RotationUnit(), time)
      {
         // speed is always number of revolutions over time.
      }

      /// <summary>
      /// Constructor for an arbitrary number of revolutions per duration.
      /// </summary>
      /// <param name="rotations">The the number of rotations per time</param>
      /// <param name="time">The time unit for the revolutions</param>
      public RotationalSpeedUnit(double rotations, TimeUnit time)
         : base(new RotationUnit(), time)
      {
         this.rotations = rotations;
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
         string rotationsString = String.Empty;
         if (rotations > 0)
         {
            rotationsString = rotations.ToString();
         }
         return rotationsString + base.ToString();
      }

      #endregion
   }
}