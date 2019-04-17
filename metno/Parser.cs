using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace metno
{
    public class Parser
    {
        public static object Parse(string input, ParseType parseType, Type typeToSerialize)
        {
            switch (parseType)
            {
                case ParseType.Xml:
                    var serializer = new XmlSerializer(typeToSerialize);
                    using (var reader = new StringReader(input))
                    {
                        input = string.Empty;
                        return serializer.Deserialize(reader);
                    }
                case ParseType.Json:
                    return JsonConvert.DeserializeObject(input, typeToSerialize);
                case ParseType.Rss:
                    var rss = new XmlSerializer(typeToSerialize);
                    using (var reader = new StringReader(input))
                    {
                        input = string.Empty;
                        return rss.Deserialize(reader);
                    }
                default:
                    return null;
            }
        }

        public static string StripHtml(string input)
        {
            var rx = new Regex("<[^>]*>");
            return rx.Replace(input, string.Empty);
        }

    }
}