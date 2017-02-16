

using System;


using Dimensions.Converter.Properties;

namespace Dimensions.Converter
{
   /// <summary>
   /// Provides information on multiples to the base 10.
   /// </summary>
   
   public class Multiple : IEquatable<Multiple>
   {
      #region get instances

      private static readonly Multiple NoneMultiple = new Multiple(MultiplePower.None);
      private static readonly Multiple FemtoMultiple = new Multiple(MultiplePower.Femto);
      private static readonly Multiple PicoMultiple = new Multiple(MultiplePower.Pico);
      private static readonly Multiple NanoMultiple = new Multiple(MultiplePower.Nano);
      private static readonly Multiple MicroMultiple = new Multiple(MultiplePower.Micro);
      private static readonly Multiple MilliMultiple = new Multiple(MultiplePower.Milli);
      private static readonly Multiple CentiMultiple = new Multiple(MultiplePower.Centi);
      private static readonly Multiple DeciMultiple = new Multiple(MultiplePower.Deci);
      private static readonly Multiple DecaMultiple = new Multiple(MultiplePower.Deca);
      private static readonly Multiple HectoMultiple = new Multiple(MultiplePower.Hecto);
      private static readonly Multiple KiloMultiple = new Multiple(MultiplePower.Kilo);
      private static readonly Multiple MegaMultiple = new Multiple(MultiplePower.Mega);
      private static readonly Multiple GigaMultiple = new Multiple(MultiplePower.Giga);
      private static readonly Multiple TeraMultiple = new Multiple(MultiplePower.Tera);

      /// <summary>
      /// Gets a neutral multiple.
      /// </summary>
      public static Multiple None
      {
         get { return NoneMultiple; }
      }

      /// <summary>
      /// Gets the Multiple of Femto
      /// </summary>
      public static Multiple Femto
      {
         get { return FemtoMultiple; }
      }

      /// <summary>
      /// Gets the Multiple of Pico
      /// </summary>
      public static Multiple Pico
      {
         get { return PicoMultiple; }
      }

      /// <summary>
      /// Gets the Multiple of Nano
      /// </summary>
      public static Multiple Nano
      {
         get { return NanoMultiple; }
      }

      /// <summary>
      /// Gets the Multiple of Micro
      /// </summary>
      public static Multiple Micro
      {
         get { return MicroMultiple; }
      }

      /// <summary>
      /// Gets the Multiple of Milli
      /// </summary>
      public static Multiple Milli
      {
         get { return MilliMultiple; }
      }

      /// <summary>
      /// Gets the Multiple of Centi
      /// </summary>
      public static Multiple Centi
      {
         get { return CentiMultiple; }
      }

      /// <summary>
      /// Gets the Multiple of Deci
      /// </summary>
      public static Multiple Deci
      {
         get { return DeciMultiple; }
      }

      /// <summary>
      /// Gets the Multiple of Deca
      /// </summary>
      public static Multiple Deca
      {
         get { return DecaMultiple; }
      }

      /// <summary>
      /// Gets the Multiple of Hecto
      /// </summary>
      public static Multiple Hecto
      {
         get { return HectoMultiple; }
      }

      /// <summary>
      /// Gets the Multiple of Kilo
      /// </summary>
      public static Multiple Kilo
      {
         get { return KiloMultiple; }
      }

      /// <summary>
      /// Gets the Multiple of Mega
      /// </summary>
      public static Multiple Mega
      {
         get { return MegaMultiple; }
      }

      /// <summary>
      /// Gets the Multiple of Giga
      /// </summary>
      public static Multiple Giga
      {
         get { return GigaMultiple; }
      }

      /// <summary>
      /// Gets the Multiple of Tera
      /// </summary>
      public static Multiple Tera
      {
         get { return TeraMultiple; }
      }

      #endregion

      private Multiple(MultiplePower value)
      {
         MultiplePower = value;
      }

      private MultiplePower multiplePower;

      private double factor;

     
      private MultiplePower MultiplePower
      {
         get { return multiplePower; }
         set
         {
            multiplePower = value;
            factor = Math.Pow(10, (double)value);
         }
      }

      /// <summary>
      /// Gets the Factor of the multiple
      /// </summary>
      public double Factor { get { return factor; } }

      /// <summary>
      /// Gets the symbol of the factor, that can be used as a prefix for units.
      /// </summary>
      public string Symbol { get { return GetSymbol(); } }

      /// <summary>
      /// Gets the name of the multiple
      /// </summary>
      public string Name { get { return GetName(); } }

      /// <summary>
      /// Indicates whether the current object is equal to another object of the same type.
      /// </summary>
      /// <returns>
      /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
      /// </returns>
      /// <param name="other">An object to compare with this object.</param>
      public bool Equals(Multiple other)
      {
         return this.MultiplePower.Equals(other.MultiplePower);
      }


      /// <summary>
      /// 
      /// </summary>
      /// <param name="multiple"></param>
      /// <param name="other"></param>
      /// <returns></returns>
      public static bool operator ==(Multiple multiple, Multiple other)
      {
         if (object.ReferenceEquals(multiple, null) && object.ReferenceEquals(other, null))
         {
            return true;
         }
         if (object.ReferenceEquals(multiple, null) && !object.ReferenceEquals(other, null))
         {
            return false;
         }
         if (!object.ReferenceEquals(multiple, null) && object.ReferenceEquals(other, null))
         {
            return false;
         }

         return multiple.Equals(other);
      }


      /// <summary>
      /// 
      /// </summary>
      /// <param name="multiple"></param>
      /// <param name="other"></param>
      /// <returns></returns>
      public static bool operator !=(Multiple multiple, Multiple other)
      {
         return !(multiple == other);
      }

      #region Overrides of Object

      /// <summary>
      /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
      /// </summary>
      /// <returns>
      /// true if the specified object  is equal to the current object; otherwise, false.
      /// </returns>
      /// <param name="obj">The object to compare with the current object. </param>
      public override bool Equals(object obj)
      {
         Multiple m = obj as Multiple;
         return Equals(m);
      }

      /// <summary>
      /// Serves as a hash function for a particular type. 
      /// </summary>
      /// <returns>
      /// A hash code for the current <see cref="T:System.Object"/>.
      /// </returns>
      public override int GetHashCode()
      {
         return MultiplePower.GetHashCode();
      }

      #endregion

      #region Resource helpers

      private string GetSymbol()
      {
         switch (multiplePower)
         {
            case MultiplePower.None:
               return string.Empty;
            case MultiplePower.Tera:
               return PhysicsResources.MultipleSymbolTera;
            case MultiplePower.Giga:
               return PhysicsResources.MultipleSymbolGiga;
            case MultiplePower.Mega:
               return PhysicsResources.MultipleSymbolMega;
            case MultiplePower.Kilo:
               return PhysicsResources.MultipleSymbolKilo;
            case MultiplePower.Hecto:
               return PhysicsResources.MultipleSymbolHecto;
            case MultiplePower.Deca:
               return PhysicsResources.MultipleSymbolDeca;
            case MultiplePower.Deci:
               return PhysicsResources.MultipleSymbolDeci;
            case MultiplePower.Centi:
               return PhysicsResources.MultipleSymbolCenti;
            case MultiplePower.Milli:
               return PhysicsResources.MultipleSymbolMilli;
            case MultiplePower.Micro:
               return PhysicsResources.MultipleSymbolMicro;
            case MultiplePower.Nano:
               return PhysicsResources.MultipleSymbolNano;
            case MultiplePower.Pico:
               return PhysicsResources.MultipleSymbolPico;
            case MultiplePower.Femto:
               return PhysicsResources.MultipleSymbolFemto;
            default:
               throw new ArgumentOutOfRangeException();
         }
      }

      private string GetName()
      {
         switch (multiplePower)
         {
            case MultiplePower.None:
               return string.Empty;
            case MultiplePower.Tera:
               return PhysicsResources.MultipleNameTera;
            case MultiplePower.Giga:
               return PhysicsResources.MultipleNameGiga;
            case MultiplePower.Mega:
               return PhysicsResources.MultipleNameMega;
            case MultiplePower.Kilo:
               return PhysicsResources.MultipleNameKilo;
            case MultiplePower.Hecto:
               return PhysicsResources.MultipleNameHecto;
            case MultiplePower.Deca:
               return PhysicsResources.MultipleNameDeca;
            case MultiplePower.Deci:
               return PhysicsResources.MultipleNameDeci;
            case MultiplePower.Centi:
               return PhysicsResources.MultipleNameCenti;
            case MultiplePower.Milli:
               return PhysicsResources.MultipleNameMilli;
            case MultiplePower.Micro:
               return PhysicsResources.MultipleNameMicro;
            case MultiplePower.Nano:
               return PhysicsResources.MultipleNameNano;
            case MultiplePower.Pico:
               return PhysicsResources.MultipleNamePico;
            case MultiplePower.Femto:
               return PhysicsResources.MultipleNameFemto;
            default:
               throw new ArgumentOutOfRangeException();
         }
      }

      #endregion
   }
}