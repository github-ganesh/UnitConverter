



using System.Text;


namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for torque.
   /// </summary>
   
   public class ViscousTorqueUnit : DerivedUnit
   {
      private double speed;

      /// <summary>
      /// Creates a new instance of a viscous torque unit.
      /// </summary>
      /// <param name="torque">The unit of the torque.</param>
      /// <param name="speed">The unit of the rotational speed</param>
      public ViscousTorqueUnit(TorqueUnit torque, RotationalSpeed speed)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(torque, 1), new DividedByUnit(speed.Unit, 1) }, Quantity.ViscousTorque)
      {
         this.speed = speed.Value;

      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.Torque</value>
      public override Quantity Quantity
      {
         get { return Quantity.ViscousTorque; }
      }

      /// <summary>
      /// Returns the symbol of the unit (the short unit name)
      /// </summary>
      /// <returns>
      /// A string that represents the current object.
      /// </returns>
      public override string ToString()
      {
         StringBuilder sb = new StringBuilder();
         int i = 0;
         foreach (var unitComposite in Composites)
         {
            if (i == 0)
            {
               sb.Append(unitComposite);
               sb.Append("/");
            }
            if (i == 1)
            {
               sb.Append("(");
               sb.Append(speed);
               sb.Append(unitComposite.ToString());
               sb.Append(")");
            }
            i++;
         }
         return sb.ToString();
      }

      #endregion Overrides of UnitBase
   }
}