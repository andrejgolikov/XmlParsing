using System;
using System.Collections;
using System.Xml.Serialization;

namespace XmlParsing.Models
{
    //[Serializable()]
    [XmlRoot(ElementName = "datagram")]
    public class Datagram
    {
        #region Attributes
        
        [XmlAttribute("id")]
        public Guid Id { get; set; }

        #endregion


        #region NestedTags
        
        [XmlElement(Type = typeof(Tag11))]
        public ArrayList tag11;

        #endregion
    }

    public class Tag11
    {
        #region NestedTags
        
        [XmlElement(ElementName = "tag12")]
        public Tag12 Tag12;

        [XmlElement(ElementName = "tag22")]
        public DateTime Tag22;

        #endregion
    }

    public class Tag12
    {
        #region Attributes

        [XmlAttribute("stringAttr1")]
        public string StringAttr1 { get; set; }

        #endregion


        #region Value

        [XmlText(typeof(Guid))]
        public Guid Value;

        #endregion
    }
}

/*
<datagram>
    <tag11 master_id="3e68fc8b-5de7-4fd8-8f4e-69752731f8fd" firm_id="KBP">
        <tag12 stringAttribute="stringAttributeValue">11ed1b93-f619-4c73-ba07-46d75670c445</tag12>
    </tag11>
    <tag11 master_id="e2652b72-4048-4060-affa-ab09a1566279" firm_id="TSKIB">
        <tag12 stringAttribute="stringAttributeValue">9cbde049-0720-411a-aaff-c4cd75d245d4</tag12>
    </tag11>
</datagram>
 */
