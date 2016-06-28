using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmlBrowser
{

    class KmlIO
    {
        public static kml read(String sourceFileName)
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(kml));

            kml myKml = new kml();
            FileStream fs = new FileStream(sourceFileName, FileMode.Open);
            myKml = (kml)reader.Deserialize(fs);
            fs.Close();
            
            return myKml;
        }


        public static void write(String FileName, kml kmlData)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(kml));
            FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate);
            writer.Serialize(fs,kmlData);
            fs.Close();
        }


    }


    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/kml/2.2", IsNullable = false)]
    public partial class kml
    {

        private kmlDocument documentField;

        /// <remarks/>
        public kmlDocument Document
        {
            get
            {
                return this.documentField;
            }
            set
            {
                this.documentField = value;
            }
        }





    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocument
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Folder", typeof(kmlFolder))]
        [System.Xml.Serialization.XmlElementAttribute("Style", typeof(kmlStyle))]
        [System.Xml.Serialization.XmlElementAttribute("StyleMap", typeof(kmlMap))]
        [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlFolder
    {

        private string nameField;

        private byte visibilityField;

        private byte openField;

        private kmlFolder[] folderField;

        private kmlPlacemark[] placemarkField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte visibility
        {
            get
            {
                return this.visibilityField;
            }
            set
            {
                this.visibilityField = value;
            }
        }

        /// <remarks/>
        public byte open
        {
            get
            {
                return this.openField;
            }
            set
            {
                this.openField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Folder")]
        public kmlFolder[] Folder
        {
            get
            {
                return this.folderField;
            }
            set
            {
                this.folderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Placemark")]
        public kmlPlacemark[] Placemark
        {
            get
            {
                return this.placemarkField;
            }
            set
            {
                this.placemarkField = value;
            }
        }
    }


    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlCamera
    {

        private decimal longitudeField;

        private decimal latitudeField;

        private decimal altitudeField;

        private decimal headingField;

        private decimal tiltField;

        private decimal rollField;

        private string altitudeModeField;

        /// <remarks/>
        public decimal longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        public decimal latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public decimal altitude
        {
            get
            {
                return this.altitudeField;
            }
            set
            {
                this.altitudeField = value;
            }
        }

        /// <remarks/>
        public decimal heading
        {
            get
            {
                return this.headingField;
            }
            set
            {
                this.headingField = value;
            }
        }

        /// <remarks/>
        public decimal tilt
        {
            get
            {
                return this.tiltField;
            }
            set
            {
                this.tiltField = value;
            }
        }

        /// <remarks/>
        public decimal roll
        {
            get
            {
                return this.rollField;
            }
            set
            {
                this.rollField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.google.com/kml/ext/2.2")]
        public string altitudeMode
        {
            get
            {
                return this.altitudeModeField;
            }
            set
            {
                this.altitudeModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlLineString
    {

        private string coordinatesField;

        /// <remarks/>
        public string coordinates
        {
            get
            {
                return this.coordinatesField;
            }
            set
            {
                this.coordinatesField = value;
            }
        }
    }

 
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlPlacemark
    {

        private string nameField;

        private byte visibilityField;

        private kmlLookAt lookAtField;

        private string styleUrlField;

        private kmlPoint pointField;

        private kmlCamera cameraField;

        private byte openField;

        private bool openFieldSpecified;

        private kmlLineString lineStringField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte visibility
        {
            get
            {
                return this.visibilityField;
            }
            set
            {
                this.visibilityField = value;
            }
        }

        /// <remarks/>
        public kmlLookAt LookAt
        {
            get
            {
                return this.lookAtField;
            }
            set
            {
                this.lookAtField = value;
            }
        }

        /// <remarks/>
        public string styleUrl
        {
            get
            {
                return this.styleUrlField;
            }
            set
            {
                this.styleUrlField = value;
            }
        }

        /// <remarks/>
        public kmlPoint Point
        {
            get
            {
                return this.pointField;
            }
            set
            {
                this.pointField = value;
            }
        }

        public kmlCamera Camera
        {
            get
            {
                return this.cameraField;
            }
            set
            {
                this.cameraField = value;
            }
        }

        /// <remarks/>
        public byte open
        {
            get
            {
                return this.openField;
            }
            set
            {
                this.openField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool openSpecified
        {
            get
            {
                return this.openFieldSpecified;
            }
            set
            {
                this.openFieldSpecified = value;
            }
        }

        public kmlLineString LineString
        {
            get
            {
                return this.lineStringField;
            }
            set
            {
                this.lineStringField = value;
            }
        }

    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlLookAt
    {

        private double longitudeField;

        private double latitudeField;

        private double altitudeField;

        private double headingField;

        private double tiltField;

        private double rangeField;

        private string altitudeModeField;

        /// <remarks/>
        public double longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        public double latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public double altitude
        {
            get
            {
                return this.altitudeField;
            }
            set
            {
                this.altitudeField = value;
            }
        }

        /// <remarks/>
        public double heading
        {
            get
            {
                return this.headingField;
            }
            set
            {
                this.headingField = value;
            }
        }

        /// <remarks/>
        public double tilt
        {
            get
            {
                return this.tiltField;
            }
            set
            {
                this.tiltField = value;
            }
        }

        /// <remarks/>
        public double range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.google.com/kml/ext/2.2")]
        public string altitudeMode
        {
            get
            {
                return this.altitudeModeField;
            }
            set
            {
                this.altitudeModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlPoint
    {

        private byte drawOrderField;

        private string coordinatesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.google.com/kml/ext/2.2")]
        public byte drawOrder
        {
            get
            {
                return this.drawOrderField;
            }
            set
            {
                this.drawOrderField = value;
            }
        }

        /// <remarks/>
        public string coordinates
        {
            get
            {
                return this.coordinatesField;
            }
            set
            {
                this.coordinatesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlStyle
    {

        private kmlIconStyle iconStyleField;

        private kmlLabelStyle labelStyleField;

        private kmlLineStyle lineStyleField;

        private string idField;

        /// <remarks/>
        public kmlIconStyle IconStyle
        {
            get
            {
                return this.iconStyleField;
            }
            set
            {
                this.iconStyleField = value;
            }
        }

        /// <remarks/>
        public kmlLabelStyle LabelStyle
        {
            get
            {
                return this.labelStyleField;
            }
            set
            {
                this.labelStyleField = value;
            }
        }

        /// <remarks/>
        public kmlLineStyle LineStyle
        {
            get
            {
                return this.lineStyleField;
            }
            set
            {
                this.lineStyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlIconStyle
    {

        private string colorField;

        private decimal scaleField;

        private kmlIcon iconField;

        private kmlHotSpot hotSpotField;

        /// <remarks/>
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        public decimal scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }

        /// <remarks/>
        public kmlIcon Icon
        {
            get
            {
                return this.iconField;
            }
            set
            {
                this.iconField = value;
            }
        }

        /// <remarks/>
        public kmlHotSpot hotSpot
        {
            get
            {
                return this.hotSpotField;
            }
            set
            {
                this.hotSpotField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlIcon
    {

        private string hrefField;

        /// <remarks/>
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlHotSpot
    {

        private decimal xField;

        private byte yField;

        private string xunitsField;

        private string yunitsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xunits
        {
            get
            {
                return this.xunitsField;
            }
            set
            {
                this.xunitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yunits
        {
            get
            {
                return this.yunitsField;
            }
            set
            {
                this.yunitsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlLabelStyle
    {

        private string colorField;

        /// <remarks/>
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlLineStyle
    {

        private string colorField;

        private double widthField;

        /// <remarks/>
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        public double width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlMap
    {

        private kmlPair[] pairField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Pair")]
        public kmlPair[] Pair
        {
            get
            {
                return this.pairField;
            }
            set
            {
                this.pairField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlPair
    {

        private string keyField;

        private string styleUrlField;

        /// <remarks/>
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        public string styleUrl
        {
            get
            {
                return this.styleUrlField;
            }
            set
            {
                this.styleUrlField = value;
            }
        }
    }



}

