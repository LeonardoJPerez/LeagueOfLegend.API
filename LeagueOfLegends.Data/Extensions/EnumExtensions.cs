using System;
using System.Reflection;
using LeagueOfLegends.Data.Attributes;

namespace LeagueOfLegends.Data.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// To the description string.
        /// </summary>
        /// <param name="enumObj">The enum object.</param>
        /// <returns></returns>
        public static string ToDescriptionString(this Enum enumObj)
        {
            var x = enumObj.GetType();
            var f = x.GetRuntimeField(enumObj.ToString());

            if (f != null)
            {
                foreach (CustomAttributeData item in f.CustomAttributes)
                {
                    if (item.AttributeType == typeof(DisplayEnumAttribute))
                    {
                        return item.ConstructorArguments[0].Value.ToString();
                    }
                }
            }
            return "";
        }
    }
}