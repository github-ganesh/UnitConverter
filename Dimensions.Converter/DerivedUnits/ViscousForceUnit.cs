



using System.Text;


namespace Dimensions.Converter
{
   /// <summary>
   /// Represents a unit for viscous force.
   /// </summary>
   
   public class ViscousForceUnit : DerivedUnit
   {
      private double speed;

      /// <summary>
      /// Creates a new instance of a viscous force unit.
      /// </summary>
      /// <param name="force">The unit of the force.</param>
      /// <param name="speed">The unit of the rotational speed</param>
      public ViscousForceUnit(ForceUnit force, RotationalSpeed speed)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(force, 1), new DividedByUnit(speed.Unit, 1) }, Quantity.ViscousForce)
      {
         this.speed = speed.Value;

      }

      /// <summary>
      /// Creates a new instance of a viscous force unit.
      /// </summary>
      /// <param name="force">The unit of the force.</param>
      /// <param name="speed">The unit of the rotational speed</param>
      public ViscousForceUnit(ForceUnit force, Speed speed)
         : base(new UnitCompositeCollection() { new MultipliedByUnit(force, 1), new DividedByUnit(speed.Unit, 1) }, Quantity.ViscousForce)
      {
         this.speed = speed.Value;
      }

      #region Overrides of UnitBase

      /// <summary>
      /// Gets the quantity this unit can stand for.
      /// </summary>
      /// <value>Quantity.ViscousForce</value>
      public override Quantity Quantity
      {
         get { return Quantity.ViscousForce; }
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