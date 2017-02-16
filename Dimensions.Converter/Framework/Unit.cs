


namespace Dimensions.Converter
{
   /// <summary>
   /// Enumeration of units.
   /// </summary>
   public enum Unit
   {
      /// <summary>
      /// No unit
      /// </summary>
      None = 0,

      /// <summary>
      /// The US customary unit of inch
      /// </summary>
      Inch = 1 & (UnitSystem.USCustomary << 24) & Quantity.Length,

      /// <summary>
      /// The US customary unit of foot
      /// </summary>
      Foot = 2 & UnitSystem.USCustomary & Quantity.Length,

      /// <summary>
      /// The empirial unit of foot
      /// </summary>
      Yard = 3 & UnitSystem.USCustomary & Quantity.Length,


      /// <summary>
      /// The US customary unit of foot
      /// </summary>
      Mile = 4 & UnitSystem.USCustomary & Quantity.Length,

      /// <summary>
      /// The SI unit of meter
      /// </summary>
      Meter = 5 & UnitSystem.SI & Quantity.Length,

      /// <summary>
      /// The universal unit of an angle.
      /// </summary>
      Rad = 6 & UnitSystem.Universal,

      /// <summary>
      /// The universal unit of solid angle.
      /// </summary>
      Steradian = 7 & UnitSystem.Universal,

      /// <summary>
      /// The empirial unit of pound
      /// </summary>
      Pound = 8 & UnitSystem.USCustomary & Quantity.Mass,

      /// <summary>
      /// The SI unit of newton
      /// </summary>
      Newton = 9 & UnitSystem.SI & Quantity.Force,

      /// <summary>
      /// The SI unit of Coulomb
      /// </summary>
      Coulomb = 10 & UnitSystem.SI & Quantity.ElectricCharge, // SI base unit

      /// <summary>
      /// The SI unit of Farad
      /// </summary>
      Farad = 11 & UnitSystem.SI & Quantity.Capacitance,  // base unit

      /// <summary>
      /// The SI unit of Henry
      /// </summary>
      Henry = 12 & UnitSystem.SI & Quantity.Inductance,   // base unit

      /// <summary>
      /// The SI unit of Ohm
      /// </summary>
      Ohm = 13 & UnitSystem.SI & Quantity.ElectricResistance,     // base unit

      /// <summary>
      /// The SI unit of Volt
      /// </summary>
      Volt = 14 & UnitSystem.SI & Quantity.Voltage,    // base unit

      /// <summary>
      /// The SI unit of Ampere
      /// </summary>
      Ampere = 15 & UnitSystem.SI & Quantity.ElectricCurrent,  // base unit

      /// <summary>
      /// The SI unit of Watt
      /// </summary>
      Watt = 16 & UnitSystem.SI & Quantity.Power, // base unit

      /// <summary>
      /// The SI unit of Second
      /// </summary>
      Second = 17 & UnitSystem.Universal & Quantity.Time,  // base unit

      /// <summary>
      /// The SI unit of Minute
      /// </summary>
      Minute = 18 & UnitSystem.Universal & Quantity.Time, // factor of 60 to second

      /// <summary>
      /// The SI unit of Hour
      /// </summary>
      Hour = 19 & UnitSystem.Universal & Quantity.Time,    // factor of 60 to Minute to second

   }
}