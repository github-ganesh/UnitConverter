using System;
using System.Collections.Generic;
using System.Linq;


namespace Dimensions.Converter
{
   /// <summary>
   /// Provides methods operated on types.
   /// </summary>
   public static class TypeExtension
   {
      private static readonly Dictionary<Type, Dictionary<AssignableTypesOption, IEnumerable<Type>>> TypesDictionary =
         new Dictionary<Type, Dictionary<AssignableTypesOption, IEnumerable<Type>>>();

      /// <summary>
      /// Options for the <see cref="GetAssignableTypes"/> method to define how types that are generic type definitions are treated.
      /// <para>A generic type definition is a template from which other types can be constructed.
      /// For example, from the generic type definition G&lt;T&gt; you can construct and instantiate the type G&lt;int&gt;.</para>
      /// </summary>
      // see also the remarks about Type.IsGenericType property on MSDN
      public enum AssignableTypesOption
      {
         /// <summary>
         /// Exclude generic type definitions.
         /// </summary>
         ExcludeGenericTypeDefinitions,

         /// <summary>
         /// Include generic type definitions.
         /// </summary>
         IncludeGenericTypeDefinitions,

         /// <summary>
         /// Resolve generic type definitions, that is, instead of the generic type definitions
         /// add constructed types for all possible types that satisfy the generic parameter constraints (if there is one).
         /// </summary>
         ResolveGenericTypeDefinitions,
      }

      /// <summary>
      /// Gets all types derived from the specified type that are in the type's assembly.
      /// </summary>
      /// <param name="type">The type to get the derived types from.</param>
      /// <param name="option">Specifies the options.</param>
      /// <returns>The derived types.</returns>
      public static IEnumerable<Type> GetAssignableTypes(this Type type, AssignableTypesOption option)
      {
         Dictionary<AssignableTypesOption, IEnumerable<Type>> typesDict;
         if (!TypesDictionary.TryGetValue(type, out typesDict))
         {
            typesDict = new Dictionary<AssignableTypesOption, IEnumerable<Type>>();
            TypesDictionary.Add(type, typesDict);
         }

         IEnumerable<Type> types;
         if (!typesDict.TryGetValue(option, out types))
         {
            var assignableTypes = type.Assembly.GetTypes().Where(type.IsAssignableFrom);

            switch (option)
            {
               case AssignableTypesOption.ExcludeGenericTypeDefinitions:
                  types = assignableTypes.Where(t => !t.IsGenericTypeDefinition).ToList();
                  break;

               case AssignableTypesOption.IncludeGenericTypeDefinitions:
                  types = assignableTypes.ToList();
                  break;

               case AssignableTypesOption.ResolveGenericTypeDefinitions:
                  var typeList = new List<Type>();
                  var genericTypeDefs = new List<Type>();

                  foreach (var assignableType in assignableTypes)
                  {
                     if (assignableType.IsGenericTypeDefinition)
                     {
                        genericTypeDefs.Add(assignableType);
                     }
                     else
                     {
                        typeList.Add(assignableType);
                     }
                  }

                  foreach (var genericTypeDef in genericTypeDefs)
                  {
                     var typeArgs = genericTypeDef.GetGenericArguments();
                     if (typeArgs.Length > 1)
                     {
                        //continue;
                        throw new NotSupportedException("Cannot resolve more than one generic argument for type '" +
                                                        genericTypeDef.FullName + "'");
                     }

                     if (typeArgs.Length == 1)
                     {
                        var constraints = typeArgs[0].GetGenericParameterConstraints();
                        if (constraints.Length > 1)
                        {
                           //continue;
                           throw new NotSupportedException("Cannot handle more than one generic parameter constraint for type '" +
                                                           genericTypeDef.FullName + "'");
                        }

                        if (constraints.Length == 1)
                        {
                           // it's not sufficient to construct a type using the type given in the constraint (which typically is a base class or interface),
                           // but we need to construct types for all possible types that satisfy the constraint and thus can be used as type parameter
                           // (we don't allow more than one parameter for now, since this would mean creating a type for each combination of the type parameters)
                           var possibleTypeArguments = GetAssignableTypes(constraints[0], AssignableTypesOption.ExcludeGenericTypeDefinitions);
                           typeList.AddRange(possibleTypeArguments.Select(t => genericTypeDef.MakeGenericType(t)));
                        }
                     }
                  }

                  types = typeList;
                  break;

               default:
                  throw new ArgumentOutOfRangeException(nameof(option), option, null);
            }
            typesDict.Add(option, types);
         }
         return types;
      }
   }
}
