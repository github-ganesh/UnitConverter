using System;

namespace Dimensions.Converter.Physics.Dimensions._Framework
{
   /// <summary>
   /// Event arguments for events when a unit is changed.
   /// </summary>
   public class UnitChangedEventArgs : EventArgs
   {
      private UnitBase oldUnit;
      private UnitBase newUnit;

      /// <summary>
      /// Creates a new instance of unit changed event arguments.
      /// </summary>
      /// <param name="oldUnit">The unit before the change.</param>
      /// <param name="newUnit">The unit after the change.</param>
      public UnitChangedEventArgs(UnitBase oldUnit, UnitBase newUnit)
      {
         this.NewUnit = newUnit;
         this.OldUnit = oldUnit;
      }

      /// <summary>
      /// Gets or sets the new unit
      /// </summary>
      public UnitBase NewUnit
      {
         get { return newUnit; }
         set { newUnit = value; }
      }

      /// <summary>
      /// Gets or sets the old unit
      /// </summary>
      public UnitBase OldUnit
      {
         get { return oldUnit; }
         set { oldUnit = value; }
      }
   }
}
