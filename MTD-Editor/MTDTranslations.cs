using System.Collections.Generic;
using System.Xml;

namespace MTD_Editor
{
    internal static class MTDTranslations
    {
        private static readonly Dictionary<string, string> descriptions;

        static MTDTranslations()
        {
            descriptions = new Dictionary<string, string>();
            var xml = new XmlDocument();
            xml.LoadXml(Properties.Resources.Translations);
            foreach (XmlNode description in xml.SelectNodes("descriptions/desc"))
            {
                string ja = description.SelectSingleNode("ja").InnerText;
                string en = description.SelectSingleNode("en").InnerText;
                descriptions[ja] = en;
            }
        }

        public static string GetTranslation(string description)
        {
            description = description.TrimEnd();
            if (descriptions.ContainsKey(description))
                return descriptions[description];
            else
                return "";
        }
    }
}
