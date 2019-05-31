using System;
using System.Collections.Generic;

namespace MTD_Editor
{
    internal class EnumWrapper
    {
        public int Value { get; }

        public string Name { get; }

        private EnumWrapper(object enumValue)
        {
            Value = (int)enumValue;
            Name = enumValue.ToString();
        }

        public static List<EnumWrapper> Wrap(Type enumType)
        {
            var wrappers = new List<EnumWrapper>();
            foreach (object enumValue in Enum.GetValues(enumType))
                wrappers.Add(new EnumWrapper(enumValue));
            return wrappers;
        }
    }
}
