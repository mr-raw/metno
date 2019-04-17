using System.Collections.Generic;
using System.Xml.Serialization;

namespace metno
{
    public class NowcastDataTypes
    {
        [XmlRoot(ElementName = "model")]
        public class Model
        {
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
            [XmlAttribute(AttributeName = "termin")]
            public string Termin { get; set; }
            [XmlAttribute(AttributeName = "runended")]
            public string Runended { get; set; }
            [XmlAttribute(AttributeName = "nextrun")]
            public string Nextrun { get; set; }
            [XmlAttribute(AttributeName = "from")]
            public string From { get; set; }
            [XmlAttribute(AttributeName = "to")]
            public string To { get; set; }
        }

        [XmlRoot(ElementName = "meta")]
        public class Meta
        {
            [XmlElement(ElementName = "model")]
            public Model Model { get; set; }
        }

        [XmlRoot(ElementName = "precipitation")]
        public class Precipitation
        {
            [XmlAttribute(AttributeName = "unit")]
            public string Unit { get; set; }
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }

        [XmlRoot(ElementName = "location")]
        public class Location
        {
            [XmlElement(ElementName = "precipitation")]
            public Precipitation Precipitation { get; set; }
            [XmlAttribute(AttributeName = "latitude")]
            public string Latitude { get; set; }
            [XmlAttribute(AttributeName = "longitude")]
            public string Longitude { get; set; }
        }

        [XmlRoot(ElementName = "time")]
        public class Time
        {
            [XmlElement(ElementName = "location")]
            public Location Location { get; set; }
            [XmlAttribute(AttributeName = "datatype")]
            public string Datatype { get; set; }
            [XmlAttribute(AttributeName = "from")]
            public string From { get; set; }
            [XmlAttribute(AttributeName = "to")]
            public string To { get; set; }
        }

        [XmlRoot(ElementName = "product")]
        public class Product
        {
            [XmlElement(ElementName = "time")]
            public List<Time> Time { get; set; }
            [XmlAttribute(AttributeName = "class")]
            public string Class { get; set; }
        }

        [XmlRoot(ElementName = "weatherdata")]
        public class Weatherdata
        {
            [XmlElement(ElementName = "meta")]
            public Meta Meta { get; set; }
            [XmlElement(ElementName = "product")]
            public Product Product { get; set; }
            [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xsi { get; set; }
            [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string NoNamespaceSchemaLocation { get; set; }
            [XmlAttribute(AttributeName = "created")]
            public string Created { get; set; }
        }
    }
}
