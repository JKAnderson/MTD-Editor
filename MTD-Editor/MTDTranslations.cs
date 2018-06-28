using System.Collections.Generic;
using System.Xml;

namespace MTD_Editor
{
    static class MTDTranslations
    {
        private static readonly Dictionary<string, string> descriptions;

        static MTDTranslations()
        {
            descriptions = new Dictionary<string, string>();
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(Properties.Resources.Translations);

            foreach (XmlNode description in xml.SelectNodes("descriptions/description"))
            {
                descriptions[description.FirstChild.InnerText.Trim()] = description.LastChild.InnerText.Trim();
            }
        }

        public static string GetTranslation(string description)
        {
            description = description.Trim();
            if (descriptions.ContainsKey(description))
                return descriptions[description];
            else
                return "";
        }
    }
}
