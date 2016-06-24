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

            return myKml;
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
        [System.Xml.Serialization.XmlElementAttribute("Folder", typeof(kmlDocumentFolder))]
        [System.Xml.Serialization.XmlElementAttribute("Style", typeof(kmlDocumentStyle))]
        [System.Xml.Serialization.XmlElementAttribute("StyleMap", typeof(kmlDocumentStyleMap))]
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
    public partial class kmlDocumentFolder
    {

        private string nameField;

        private byte visibilityField;

        private byte openField;

        private kmlDocumentFolderFolder[] folderField;

        private kmlDocumentFolderPlacemark[] placemarkField;

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
        public kmlDocumentFolderFolder[] Folder
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
        public kmlDocumentFolderPlacemark[] Placemark
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
    public partial class kmlDocumentFolderFolder
    {

        private string nameField;

        private byte visibilityField;

        private kmlDocumentFolderFolderFolder folderField;

        private kmlDocumentFolderFolderPlacemark[] placemarkField;

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
        public kmlDocumentFolderFolderFolder Folder
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
        public kmlDocumentFolderFolderPlacemark[] Placemark
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
    public partial class kmlDocumentFolderFolderFolder
    {

        private string nameField;

        private byte visibilityField;

        private byte openField;

        private kmlDocumentFolderFolderFolderPlacemark[] placemarkField;

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
        [System.Xml.Serialization.XmlElementAttribute("Placemark")]
        public kmlDocumentFolderFolderFolderPlacemark[] Placemark
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
    public partial class kmlDocumentFolderFolderFolderPlacemark
    {

        private string nameField;

        private byte visibilityField;

        private kmlDocumentFolderFolderFolderPlacemarkLookAt lookAtField;

        private kmlDocumentFolderFolderFolderPlacemarkCamera cameraField;

        private byte openField;

        private bool openFieldSpecified;

        private string styleUrlField;

        private kmlDocumentFolderFolderFolderPlacemarkPoint pointField;

        private kmlDocumentFolderFolderFolderPlacemarkLineString lineStringField;

        private string idField;

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
        public kmlDocumentFolderFolderFolderPlacemarkLookAt LookAt
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
        public kmlDocumentFolderFolderFolderPlacemarkCamera Camera
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
        public kmlDocumentFolderFolderFolderPlacemarkPoint Point
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

        /// <remarks/>
        public kmlDocumentFolderFolderFolderPlacemarkLineString LineString
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
    public partial class kmlDocumentFolderFolderFolderPlacemarkLookAt
    {

        private decimal longitudeField;

        private decimal latitudeField;

        private byte altitudeField;

        private decimal headingField;

        private decimal tiltField;

        private decimal rangeField;

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
        public byte altitude
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
        public decimal range
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
    public partial class kmlDocumentFolderFolderFolderPlacemarkCamera
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
    public partial class kmlDocumentFolderFolderFolderPlacemarkPoint
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
    public partial class kmlDocumentFolderFolderFolderPlacemarkLineString
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
    public partial class kmlDocumentFolderFolderPlacemark
    {

        private string nameField;

        private byte visibilityField;

        private kmlDocumentFolderFolderPlacemarkCamera cameraField;

        private kmlDocumentFolderFolderPlacemarkLookAt lookAtField;

        private string styleUrlField;

        private kmlDocumentFolderFolderPlacemarkLineString lineStringField;

        private kmlDocumentFolderFolderPlacemarkPoint pointField;

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
        public kmlDocumentFolderFolderPlacemarkCamera Camera
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
        public kmlDocumentFolderFolderPlacemarkLookAt LookAt
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
        public kmlDocumentFolderFolderPlacemarkLineString LineString
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

        /// <remarks/>
        public kmlDocumentFolderFolderPlacemarkPoint Point
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderPlacemarkCamera
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
    public partial class kmlDocumentFolderFolderPlacemarkLookAt
    {

        private decimal longitudeField;

        private decimal latitudeField;

        private byte altitudeField;

        private decimal headingField;

        private decimal tiltField;

        private decimal rangeField;

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
        public byte altitude
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
        public decimal range
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
    public partial class kmlDocumentFolderFolderPlacemarkLineString
    {

        private byte tessellateField;

        private string coordinatesField;

        /// <remarks/>
        public byte tessellate
        {
            get
            {
                return this.tessellateField;
            }
            set
            {
                this.tessellateField = value;
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
    public partial class kmlDocumentFolderFolderPlacemarkPoint
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
    public partial class kmlDocumentFolderPlacemark
    {

        private string nameField;

        private byte visibilityField;

        private kmlDocumentFolderPlacemarkLookAt lookAtField;

        private string styleUrlField;

        private kmlDocumentFolderPlacemarkPoint pointField;

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
        public kmlDocumentFolderPlacemarkLookAt LookAt
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
        public kmlDocumentFolderPlacemarkPoint Point
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderPlacemarkLookAt
    {

        private decimal longitudeField;

        private decimal latitudeField;

        private byte altitudeField;

        private decimal headingField;

        private decimal tiltField;

        private decimal rangeField;

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
        public byte altitude
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
        public decimal range
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
    public partial class kmlDocumentFolderPlacemarkPoint
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
    public partial class kmlDocumentStyle
    {

        private kmlDocumentStyleIconStyle iconStyleField;

        private kmlDocumentStyleLabelStyle labelStyleField;

        private kmlDocumentStyleLineStyle lineStyleField;

        private string idField;

        /// <remarks/>
        public kmlDocumentStyleIconStyle IconStyle
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
        public kmlDocumentStyleLabelStyle LabelStyle
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
        public kmlDocumentStyleLineStyle LineStyle
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
    public partial class kmlDocumentStyleIconStyle
    {

        private string colorField;

        private decimal scaleField;

        private kmlDocumentStyleIconStyleIcon iconField;

        private kmlDocumentStyleIconStyleHotSpot hotSpotField;

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
        public kmlDocumentStyleIconStyleIcon Icon
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
        public kmlDocumentStyleIconStyleHotSpot hotSpot
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
    public partial class kmlDocumentStyleIconStyleIcon
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
    public partial class kmlDocumentStyleIconStyleHotSpot
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
    public partial class kmlDocumentStyleLabelStyle
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
    public partial class kmlDocumentStyleLineStyle
    {

        private string colorField;

        private byte widthField;

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
        public byte width
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
    public partial class kmlDocumentStyleMap
    {

        private kmlDocumentStyleMapPair[] pairField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Pair")]
        public kmlDocumentStyleMapPair[] Pair
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
    public partial class kmlDocumentStyleMapPair
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

