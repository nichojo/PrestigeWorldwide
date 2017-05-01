namespace PrestigeWorldwide.TravelObject
{
    public partial class Response
    {

        private string timestampField;

        private string num_bytesField;

        private Error[] errorField;

        private Warning[] warningField;

        private Trip[] tripField;

        private ActivityObject[] activityObjectField;

        private AirObject[] airObjectField;

        private CarObject[] carObjectField;

        private CruiseObject[] cruiseObjectField;

        private DirectionsObject[] directionsObjectField;

        private LodgingObject[] lodgingObjectField;

        private MapObject[] mapObjectField;

        private NoteObject[] noteObjectField;

        private RailObject[] railObjectField;

        private RestaurantObject[] restaurantObjectField;

        private TransportObject[] transportObjectField;

        private WeatherObject[] weatherObjectField;

        private PointsProgram[] pointsProgramField;

        private Profile[] profileField;

        private string page_numField;

        private string page_sizeField;

        private string max_pageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string num_bytes
        {
            get
            {
                return this.num_bytesField;
            }
            set
            {
                this.num_bytesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Error")]
        public Error[] Error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Warning")]
        public Warning[] Warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Trip")]
        public Trip[] Trip
        {
            get
            {
                return this.tripField;
            }
            set
            {
                this.tripField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActivityObject")]
        public ActivityObject[] ActivityObject
        {
            get
            {
                return this.activityObjectField;
            }
            set
            {
                this.activityObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AirObject")]
        public AirObject[] AirObject
        {
            get
            {
                return this.airObjectField;
            }
            set
            {
                this.airObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CarObject")]
        public CarObject[] CarObject
        {
            get
            {
                return this.carObjectField;
            }
            set
            {
                this.carObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CruiseObject")]
        public CruiseObject[] CruiseObject
        {
            get
            {
                return this.cruiseObjectField;
            }
            set
            {
                this.cruiseObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DirectionsObject")]
        public DirectionsObject[] DirectionsObject
        {
            get
            {
                return this.directionsObjectField;
            }
            set
            {
                this.directionsObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LodgingObject")]
        public LodgingObject[] LodgingObject
        {
            get
            {
                return this.lodgingObjectField;
            }
            set
            {
                this.lodgingObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MapObject")]
        public MapObject[] MapObject
        {
            get
            {
                return this.mapObjectField;
            }
            set
            {
                this.mapObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NoteObject")]
        public NoteObject[] NoteObject
        {
            get
            {
                return this.noteObjectField;
            }
            set
            {
                this.noteObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RailObject")]
        public RailObject[] RailObject
        {
            get
            {
                return this.railObjectField;
            }
            set
            {
                this.railObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RestaurantObject")]
        public RestaurantObject[] RestaurantObject
        {
            get
            {
                return this.restaurantObjectField;
            }
            set
            {
                this.restaurantObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportObject")]
        public TransportObject[] TransportObject
        {
            get
            {
                return this.transportObjectField;
            }
            set
            {
                this.transportObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WeatherObject")]
        public WeatherObject[] WeatherObject
        {
            get
            {
                return this.weatherObjectField;
            }
            set
            {
                this.weatherObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointsProgram")]
        public PointsProgram[] PointsProgram
        {
            get
            {
                return this.pointsProgramField;
            }
            set
            {
                this.pointsProgramField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Profile")]
        public Profile[] Profile
        {
            get
            {
                return this.profileField;
            }
            set
            {
                this.profileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string page_num
        {
            get
            {
                return this.page_numField;
            }
            set
            {
                this.page_numField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string page_size
        {
            get
            {
                return this.page_sizeField;
            }
            set
            {
                this.page_sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string max_page
        {
            get
            {
                return this.max_pageField;
            }
            set
            {
                this.max_pageField = value;
            }
        }
    }

    public partial class Error
    {

        private string codeField;

        private decimal detailed_error_codeField;

        private bool detailed_error_codeSpecifiedField;

        private string descriptionField;

        private string entity_typeField;

        private System.DateTime timestampField1;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public decimal detailed_error_code
        {
            get
            {
                return this.detailed_error_codeField;
            }
            set
            {
                this.detailed_error_codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool detailed_error_codeSpecified
        {
            get
            {
                return this.detailed_error_codeSpecifiedField;
            }
            set
            {
                this.detailed_error_codeSpecifiedField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string entity_type
        {
            get
            {
                return this.entity_typeField;
            }
            set
            {
                this.entity_typeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime timestamp
        {
            get
            {
                return this.timestampField1;
            }
            set
            {
                this.timestampField1 = value;
            }
        }
    }

    public partial class Warning
    {

        private string descriptionField1;

        private string entity_typeField1;

        private System.DateTime timestampField2;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField1;
            }
            set
            {
                this.descriptionField1 = value;
            }
        }

        /// <remarks/>
        public string entity_type
        {
            get
            {
                return this.entity_typeField1;
            }
            set
            {
                this.entity_typeField1 = value;
            }
        }

        /// <remarks/>
        public System.DateTime timestamp
        {
            get
            {
                return this.timestampField2;
            }
            set
            {
                this.timestampField2 = value;
            }
        }
    }

    public partial class Trip
    {

        private ClosenessMatch[] closenessMatchesField;

        private Invitee[] tripInviteesField;

        private TripCrsRemark[] tripCrsRemarksField;

        private string idField;

        private string relative_urlField;

        private System.DateTime start_dateField;

        private bool start_dateSpecifiedField;

        private System.DateTime end_dateField;

        private bool end_dateSpecifiedField;

        private string descriptionField2;

        private string display_nameField;

        private string image_urlField;

        private bool is_privateField;

        private bool is_privateSpecifiedField;

        private string primary_locationField;

        private Address primaryLocationAddressField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(ElementName = "Match", IsNullable = false)]
        public ClosenessMatch[] ClosenessMatches
        {
            get
            {
                return this.closenessMatchesField;
            }
            set
            {
                this.closenessMatchesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public Invitee[] TripInvitees
        {
            get
            {
                return this.tripInviteesField;
            }
            set
            {
                this.tripInviteesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public TripCrsRemark[] TripCrsRemarks
        {
            get
            {
                return this.tripCrsRemarksField;
            }
            set
            {
                this.tripCrsRemarksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
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

        /// <remarks/>
        public string relative_url
        {
            get
            {
                return this.relative_urlField;
            }
            set
            {
                this.relative_urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime start_date
        {
            get
            {
                return this.start_dateField;
            }
            set
            {
                this.start_dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool start_dateSpecified
        {
            get
            {
                return this.start_dateSpecifiedField;
            }
            set
            {
                this.start_dateSpecifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime end_date
        {
            get
            {
                return this.end_dateField;
            }
            set
            {
                this.end_dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool end_dateSpecified
        {
            get
            {
                return this.end_dateSpecifiedField;
            }
            set
            {
                this.end_dateSpecifiedField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField2;
            }
            set
            {
                this.descriptionField2 = value;
            }
        }

        /// <remarks/>
        public string display_name
        {
            get
            {
                return this.display_nameField;
            }
            set
            {
                this.display_nameField = value;
            }
        }

        /// <remarks/>
        public string image_url
        {
            get
            {
                return this.image_urlField;
            }
            set
            {
                this.image_urlField = value;
            }
        }

        /// <remarks/>
        public bool is_private
        {
            get
            {
                return this.is_privateField;
            }
            set
            {
                this.is_privateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool is_privateSpecified
        {
            get
            {
                return this.is_privateSpecifiedField;
            }
            set
            {
                this.is_privateSpecifiedField = value;
            }
        }

        /// <remarks/>
        public string primary_location
        {
            get
            {
                return this.primary_locationField;
            }
            set
            {
                this.primary_locationField = value;
            }
        }

        /// <remarks/>
        public Address PrimaryLocationAddress
        {
            get
            {
                return this.primaryLocationAddressField;
            }
            set
            {
                this.primaryLocationAddressField = value;
            }
        }
    }

    public partial class ClosenessMatch
    {

        private string profile_refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string profile_ref
        {
            get
            {
                return this.profile_refField;
            }
            set
            {
                this.profile_refField = value;
            }
        }
    }

    public partial class Invitee
    {

        private string profile_refField1;

        private bool is_read_onlyField;

        private bool is_travelerField;

        private bool is_ownerField;

        private bool is_ownerSpecifiedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string profile_ref
        {
            get
            {
                return this.profile_refField1;
            }
            set
            {
                this.profile_refField1 = value;
            }
        }

        /// <remarks/>
        public bool is_read_only
        {
            get
            {
                return this.is_read_onlyField;
            }
            set
            {
                this.is_read_onlyField = value;
            }
        }

        /// <remarks/>
        public bool is_traveler
        {
            get
            {
                return this.is_travelerField;
            }
            set
            {
                this.is_travelerField = value;
            }
        }

        /// <remarks/>
        public bool is_owner
        {
            get
            {
                return this.is_ownerField;
            }
            set
            {
                this.is_ownerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool is_ownerSpecified
        {
            get
            {
                return this.is_ownerSpecifiedField;
            }
            set
            {
                this.is_ownerSpecifiedField = value;
            }
        }
    }

    public partial class TripCrsRemark
    {

        private string record_locatorField;

        private string notesField;

        /// <remarks/>
        public string record_locator
        {
            get
            {
                return this.record_locatorField;
            }
            set
            {
                this.record_locatorField = value;
            }
        }

        /// <remarks/>
        public string notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }
    }

    public partial class Address
    {

        private string addressField;

        private string addr1Field;

        private string addr2Field;

        private string cityField;

        private string stateField;

        private string zipField;

        private string countryField;

        private decimal latitudeField;

        private bool latitudeSpecifiedField;

        private decimal longitudeField;

        private bool longitudeSpecifiedField;

        /// <remarks/>
        public string address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public string addr1
        {
            get
            {
                return this.addr1Field;
            }
            set
            {
                this.addr1Field = value;
            }
        }

        /// <remarks/>
        public string addr2
        {
            get
            {
                return this.addr2Field;
            }
            set
            {
                this.addr2Field = value;
            }
        }

        /// <remarks/>
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public string zip
        {
            get
            {
                return this.zipField;
            }
            set
            {
                this.zipField = value;
            }
        }

        /// <remarks/>
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
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
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool latitudeSpecified
        {
            get
            {
                return this.latitudeSpecifiedField;
            }
            set
            {
                this.latitudeSpecifiedField = value;
            }
        }

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
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool longitudeSpecified
        {
            get
            {
                return this.longitudeSpecifiedField;
            }
            set
            {
                this.longitudeSpecifiedField = value;
            }
        }
    }

    public partial class ActivityObject : ReservationObject
    {

        private DateTime startDateTimeField;

        private System.DateTime end_timeField;

        private bool end_timeSpecifiedField;

        private Address addressField1;

        private Traveler[] participantField;

        private string detail_type_codeField;

        private string location_nameField;

        /// <remarks/>
        public DateTime StartDateTime
        {
            get
            {
                return this.startDateTimeField;
            }
            set
            {
                this.startDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime end_time
        {
            get
            {
                return this.end_timeField;
            }
            set
            {
                this.end_timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool end_timeSpecified
        {
            get
            {
                return this.end_timeSpecifiedField;
            }
            set
            {
                this.end_timeSpecifiedField = value;
            }
        }

        /// <remarks/>
        public Address Address
        {
            get
            {
                return this.addressField1;
            }
            set
            {
                this.addressField1 = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Participant")]
        public Traveler[] Participant
        {
            get
            {
                return this.participantField;
            }
            set
            {
                this.participantField = value;
            }
        }

        /// <remarks/>
        public string detail_type_code
        {
            get
            {
                return this.detail_type_codeField;
            }
            set
            {
                this.detail_type_codeField = value;
            }
        }

        /// <remarks/>
        public string location_name
        {
            get
            {
                return this.location_nameField;
            }
            set
            {
                this.location_nameField = value;
            }
        }
    }

    public partial class DateTime
    {

        private System.DateTime dateField;

        private bool dateSpecifiedField;

        private System.DateTime timeField;

        private bool timeSpecifiedField;

        private string timezoneField;

        private string utc_offsetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool dateSpecified
        {
            get
            {
                return this.dateSpecifiedField;
            }
            set
            {
                this.dateSpecifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool timeSpecified
        {
            get
            {
                return this.timeSpecifiedField;
            }
            set
            {
                this.timeSpecifiedField = value;
            }
        }

        /// <remarks/>
        public string timezone
        {
            get
            {
                return this.timezoneField;
            }
            set
            {
                this.timezoneField = value;
            }
        }

        /// <remarks/>
        public string utc_offset
        {
            get
            {
                return this.utc_offsetField;
            }
            set
            {
                this.utc_offsetField = value;
            }
        }
    }

    public partial class Traveler
    {

        private string first_nameField;

        private string middle_nameField;

        private string last_nameField;

        private string frequent_traveler_numField;

        private string frequent_traveler_supplierField;

        private string meal_preferenceField;

        private string seat_preferenceField;

        private string ticket_numField;

        /// <remarks/>
        public string first_name
        {
            get
            {
                return this.first_nameField;
            }
            set
            {
                this.first_nameField = value;
            }
        }

        /// <remarks/>
        public string middle_name
        {
            get
            {
                return this.middle_nameField;
            }
            set
            {
                this.middle_nameField = value;
            }
        }

        /// <remarks/>
        public string last_name
        {
            get
            {
                return this.last_nameField;
            }
            set
            {
                this.last_nameField = value;
            }
        }

        /// <remarks/>
        public string frequent_traveler_num
        {
            get
            {
                return this.frequent_traveler_numField;
            }
            set
            {
                this.frequent_traveler_numField = value;
            }
        }

        /// <remarks/>
        public string frequent_traveler_supplier
        {
            get
            {
                return this.frequent_traveler_supplierField;
            }
            set
            {
                this.frequent_traveler_supplierField = value;
            }
        }

        /// <remarks/>
        public string meal_preference
        {
            get
            {
                return this.meal_preferenceField;
            }
            set
            {
                this.meal_preferenceField = value;
            }
        }

        /// <remarks/>
        public string seat_preference
        {
            get
            {
                return this.seat_preferenceField;
            }
            set
            {
                this.seat_preferenceField = value;
            }
        }

        /// <remarks/>
        public string ticket_num
        {
            get
            {
                return this.ticket_numField;
            }
            set
            {
                this.ticket_numField = value;
            }
        }
    }

    public partial class ReservationObject : Object
    {

        private DateTime cancellationDateTimeField;

        private System.DateTime booking_dateField;

        private bool booking_dateSpecifiedField;

        private string booking_rateField;

        private string booking_site_conf_numField;

        private string booking_site_nameField;

        private string booking_site_phoneField;

        private string booking_site_urlField;

        private string record_locatorField1;

        private string supplier_conf_numField;

        private string supplier_contactField;

        private string supplier_email_addressField;

        private string supplier_nameField;

        private string supplier_phoneField;

        private string supplier_urlField;

        private bool is_purchasedField;

        private bool is_purchasedSpecifiedField;

        private string notesField1;

        private string restrictionsField;

        private string total_costField;

        private bool is_tripit_bookingField;

        private bool is_tripit_bookingSpecifiedField;

        /// <remarks/>
        public DateTime CancellationDateTime
        {
            get
            {
                return this.cancellationDateTimeField;
            }
            set
            {
                this.cancellationDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime booking_date
        {
            get
            {
                return this.booking_dateField;
            }
            set
            {
                this.booking_dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool booking_dateSpecified
        {
            get
            {
                return this.booking_dateSpecifiedField;
            }
            set
            {
                this.booking_dateSpecifiedField = value;
            }
        }

        /// <remarks/>
        public string booking_rate
        {
            get
            {
                return this.booking_rateField;
            }
            set
            {
                this.booking_rateField = value;
            }
        }

        /// <remarks/>
        public string booking_site_conf_num
        {
            get
            {
                return this.booking_site_conf_numField;
            }
            set
            {
                this.booking_site_conf_numField = value;
            }
        }

        /// <remarks/>
        public string booking_site_name
        {
            get
            {
                return this.booking_site_nameField;
            }
            set
            {
                this.booking_site_nameField = value;
            }
        }

        /// <remarks/>
        public string booking_site_phone
        {
            get
            {
                return this.booking_site_phoneField;
            }
            set
            {
                this.booking_site_phoneField = value;
            }
        }

        /// <remarks/>
        public string booking_site_url
        {
            get
            {
                return this.booking_site_urlField;
            }
            set
            {
                this.booking_site_urlField = value;
            }
        }

        /// <remarks/>
        public string record_locator
        {
            get
            {
                return this.record_locatorField1;
            }
            set
            {
                this.record_locatorField1 = value;
            }
        }

        /// <remarks/>
        public string supplier_conf_num
        {
            get
            {
                return this.supplier_conf_numField;
            }
            set
            {
                this.supplier_conf_numField = value;
            }
        }

        /// <remarks/>
        public string supplier_contact
        {
            get
            {
                return this.supplier_contactField;
            }
            set
            {
                this.supplier_contactField = value;
            }
        }

        /// <remarks/>
        public string supplier_email_address
        {
            get
            {
                return this.supplier_email_addressField;
            }
            set
            {
                this.supplier_email_addressField = value;
            }
        }

        /// <remarks/>
        public string supplier_name
        {
            get
            {
                return this.supplier_nameField;
            }
            set
            {
                this.supplier_nameField = value;
            }
        }

        /// <remarks/>
        public string supplier_phone
        {
            get
            {
                return this.supplier_phoneField;
            }
            set
            {
                this.supplier_phoneField = value;
            }
        }

        /// <remarks/>
        public string supplier_url
        {
            get
            {
                return this.supplier_urlField;
            }
            set
            {
                this.supplier_urlField = value;
            }
        }

        /// <remarks/>
        public bool is_purchased
        {
            get
            {
                return this.is_purchasedField;
            }
            set
            {
                this.is_purchasedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool is_purchasedSpecified
        {
            get
            {
                return this.is_purchasedSpecifiedField;
            }
            set
            {
                this.is_purchasedSpecifiedField = value;
            }
        }

        /// <remarks/>
        public string notes
        {
            get
            {
                return this.notesField1;
            }
            set
            {
                this.notesField1 = value;
            }
        }

        /// <remarks/>
        public string restrictions
        {
            get
            {
                return this.restrictionsField;
            }
            set
            {
                this.restrictionsField = value;
            }
        }

        /// <remarks/>
        public string total_cost
        {
            get
            {
                return this.total_costField;
            }
            set
            {
                this.total_costField = value;
            }
        }

        /// <remarks/>
        public bool is_tripit_booking
        {
            get
            {
                return this.is_tripit_bookingField;
            }
            set
            {
                this.is_tripit_bookingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool is_tripit_bookingSpecified
        {
            get
            {
                return this.is_tripit_bookingSpecifiedField;
            }
            set
            {
                this.is_tripit_bookingSpecifiedField = value;
            }
        }
    }

    public partial class Object
    {

        private string idField1;

        private string trip_idField;

        private bool is_client_travelerField;

        private bool is_client_travelerSpecifiedField;

        private string relative_urlField1;

        private string display_nameField1;

        private Image[] imageField;

        private Creator creatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string id
        {
            get
            {
                return this.idField1;
            }
            set
            {
                this.idField1 = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string trip_id
        {
            get
            {
                return this.trip_idField;
            }
            set
            {
                this.trip_idField = value;
            }
        }

        /// <remarks/>
        public bool is_client_traveler
        {
            get
            {
                return this.is_client_travelerField;
            }
            set
            {
                this.is_client_travelerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool is_client_travelerSpecified
        {
            get
            {
                return this.is_client_travelerSpecifiedField;
            }
            set
            {
                this.is_client_travelerSpecifiedField = value;
            }
        }

        /// <remarks/>
        public string relative_url
        {
            get
            {
                return this.relative_urlField1;
            }
            set
            {
                this.relative_urlField1 = value;
            }
        }

        /// <remarks/>
        public string display_name
        {
            get
            {
                return this.display_nameField1;
            }
            set
            {
                this.display_nameField1 = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Image")]
        public Image[] Image
        {
            get
            {
                return this.imageField;
            }
            set
            {
                this.imageField = value;
            }
        }

        /// <remarks/>
        public Creator Creator
        {
            get
            {
                return this.creatorField;
            }
            set
            {
                this.creatorField = value;
            }
        }
    }

    public partial class Image
    {

        private string captionField;

        private string urlField;

        private ImageData imageDataField;

        private string idField2;

        /// <remarks/>
        public string caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public ImageData ImageData
        {
            get
            {
                return this.imageDataField;
            }
            set
            {
                this.imageDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string id
        {
            get
            {
                return this.idField2;
            }
            set
            {
                this.idField2 = value;
            }
        }
    }

    public partial class ImageData
    {

        private byte[] contentField;

        private ImageDataMime_type mime_typeField;

        /// <remarks/>
        public byte[] content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }

        /// <remarks/>
        public ImageDataMime_type mime_type
        {
            get
            {
                return this.mime_typeField;
            }
            set
            {
                this.mime_typeField = value;
            }
        }
    }

    public enum ImageDataMime_type
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("image/jpeg")]
        imagejpeg,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("image/pjpeg")]
        imagepjpeg,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("image/x-citrix-pjpeg")]
        imagexcitrixpjpeg,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("image/png")]
        imagepng,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("image/x-png")]
        imagexpng,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("image/gif")]
        imagegif,
    }

    public partial class Creator
    {

        private string consumer_keyField;

        private string consumer_nameField;

        /// <remarks/>
        public string consumer_key
        {
            get
            {
                return this.consumer_keyField;
            }
            set
            {
                this.consumer_keyField = value;
            }
        }

        /// <remarks/>
        public string consumer_name
        {
            get
            {
                return this.consumer_nameField;
            }
            set
            {
                this.consumer_nameField = value;
            }
        }
    }

    public partial class AirObject : ReservationObject
    {

        private AirSegment[] segmentField;

        private Traveler[] travelerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Segment")]
        public AirSegment[] Segment
        {
            get
            {
                return this.segmentField;
            }
            set
            {
                this.segmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Traveler")]
        public Traveler[] Traveler
        {
            get
            {
                return this.travelerField;
            }
            set
            {
                this.travelerField = value;
            }
        }
    }

    public partial class AirSegment
    {

        private FlightStatus statusField;

        private DateTime startDateTimeField1;

        private DateTime endDateTimeField;

        private string start_airport_codeField;

        private decimal start_airport_latitudeField;

        private bool start_airport_latitudeSpecifiedField;

        private decimal start_airport_longitudeField;

        private bool start_airport_longitudeSpecifiedField;

        private string start_city_nameField;

        private string start_gateField;

        private string start_terminalField;

        private string end_airport_codeField;

        private decimal end_airport_latitudeField;

        private bool end_airport_latitudeSpecifiedField;

        private decimal end_airport_longitudeField;

        private bool end_airport_longitudeSpecifiedField;

        private string end_city_nameField;

        private string end_gateField;

        private string end_terminalField;

        private string marketing_airlineField;

        private string marketing_airline_codeField;

        private string marketing_flight_numberField;

        private string operating_airlineField;

        private string operating_airline_codeField;

        private string operating_flight_numberField;

        private string alternate_flights_urlField;

        private string aircraftField;

        private string aircraft_display_nameField;

        private string distanceField;

        private string durationField;

        private string entertainmentField;

        private string mealField;

        private string notesField2;

        private string ontime_percField;

        private string seatsField;

        private string service_classField;

        private string stopsField;

        private string baggage_claimField1;

        private string check_in_urlField;

        private string conflict_resolution_urlField;

        private bool is_hiddenField;

        private bool is_hiddenSpecifiedField;

        private string idField3;

        /// <remarks/>
        public FlightStatus Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public DateTime StartDateTime
        {
            get
            {
                return this.startDateTimeField1;
            }
            set
            {
                this.startDateTimeField1 = value;
            }
        }

        /// <remarks/>
        public DateTime EndDateTime
        {
            get
            {
                return this.endDateTimeField;
            }
            set
            {
                this.endDateTimeField = value;
            }
        }

        /// <remarks/>
        public string start_airport_code
        {
            get
            {
                return this.start_airport_codeField;
            }
            set
            {
                this.start_airport_codeField = value;
            }
        }

        /// <remarks/>
        public decimal start_airport_latitude
        {
            get
            {
                return this.start_airport_latitudeField;
            }
            set
            {
                this.start_airport_latitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool start_airport_latitudeSpecified
        {
            get
            {
                return this.start_airport_latitudeSpecifiedField;
            }
            set
            {
                this.start_airport_latitudeSpecifiedField = value;
            }
        }

        /// <remarks/>
        public decimal start_airport_longitude
        {
            get
            {
                return this.start_airport_longitudeField;
            }
            set
            {
                this.start_airport_longitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool start_airport_longitudeSpecified
        {
            get
            {
                return this.start_airport_longitudeSpecifiedField;
            }
            set
            {
                this.start_airport_longitudeSpecifiedField = value;
            }
        }

        /// <remarks/>
        public string start_city_name
        {
            get
            {
                return this.start_city_nameField;
            }
            set
            {
                this.start_city_nameField = value;
            }
        }

        /// <remarks/>
        public string start_gate
        {
            get
            {
                return this.start_gateField;
            }
            set
            {
                this.start_gateField = value;
            }
        }

        /// <remarks/>
        public string start_terminal
        {
            get
            {
                return this.start_terminalField;
            }
            set
            {
                this.start_terminalField = value;
            }
        }

        /// <remarks/>
        public string end_airport_code
        {
            get
            {
                return this.end_airport_codeField;
            }
            set
            {
                this.end_airport_codeField = value;
            }
        }

        /// <remarks/>
        public decimal end_airport_latitude
        {
            get
            {
                return this.end_airport_latitudeField;
            }
            set
            {
                this.end_airport_latitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool end_airport_latitudeSpecified
        {
            get
            {
                return this.end_airport_latitudeSpecifiedField;
            }
            set
            {
                this.end_airport_latitudeSpecifiedField = value;
            }
        }

        /// <remarks/>
        public decimal end_airport_longitude
        {
            get
            {
                return this.end_airport_longitudeField;
            }
            set
            {
                this.end_airport_longitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool end_airport_longitudeSpecified
        {
            get
            {
                return this.end_airport_longitudeSpecifiedField;
            }
            set
            {
                this.end_airport_longitudeSpecifiedField = value;
            }
        }

        /// <remarks/>
        public string end_city_name
        {
            get
            {
                return this.end_city_nameField;
            }
            set
            {
                this.end_city_nameField = value;
            }
        }

        /// <remarks/>
        public string end_gate
        {
            get
            {
                return this.end_gateField;
            }
            set
            {
                this.end_gateField = value;
            }
        }

        /// <remarks/>
        public string end_terminal
        {
            get
            {
                return this.end_terminalField;
            }
            set
            {
                this.end_terminalField = value;
            }
        }

        /// <remarks/>
        public string marketing_airline
        {
            get
            {
                return this.marketing_airlineField;
            }
            set
            {
                this.marketing_airlineField = value;
            }
        }

        /// <remarks/>
        public string marketing_airline_code
        {
            get
            {
                return this.marketing_airline_codeField;
            }
            set
            {
                this.marketing_airline_codeField = value;
            }
        }

        /// <remarks/>
        public string marketing_flight_number
        {
            get
            {
                return this.marketing_flight_numberField;
            }
            set
            {
                this.marketing_flight_numberField = value;
            }
        }

        /// <remarks/>
        public string operating_airline
        {
            get
            {
                return this.operating_airlineField;
            }
            set
            {
                this.operating_airlineField = value;
            }
        }

        /// <remarks/>
        public string operating_airline_code
        {
            get
            {
                return this.operating_airline_codeField;
            }
            set
            {
                this.operating_airline_codeField = value;
            }
        }

        /// <remarks/>
        public string operating_flight_number
        {
            get
            {
                return this.operating_flight_numberField;
            }
            set
            {
                this.operating_flight_numberField = value;
            }
        }

        /// <remarks/>
        public string alternate_flights_url
        {
            get
            {
                return this.alternate_flights_urlField;
            }
            set
            {
                this.alternate_flights_urlField = value;
            }
        }

        /// <remarks/>
        public string aircraft
        {
            get
            {
                return this.aircraftField;
            }
            set
            {
                this.aircraftField = value;
            }
        }

        /// <remarks/>
        public string aircraft_display_name
        {
            get
            {
                return this.aircraft_display_nameField;
            }
            set
            {
                this.aircraft_display_nameField = value;
            }
        }

        /// <remarks/>
        public string distance
        {
            get
            {
                return this.distanceField;
            }
            set
            {
                this.distanceField = value;
            }
        }

        /// <remarks/>
        public string duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        public string entertainment
        {
            get
            {
                return this.entertainmentField;
            }
            set
            {
                this.entertainmentField = value;
            }
        }

        /// <remarks/>
        public string meal
        {
            get
            {
                return this.mealField;
            }
            set
            {
                this.mealField = value;
            }
        }

        /// <remarks/>
        public string notes
        {
            get
            {
                return this.notesField2;
            }
            set
            {
                this.notesField2 = value;
            }
        }

        /// <remarks/>
        public string ontime_perc
        {
            get
            {
                return this.ontime_percField;
            }
            set
            {
                this.ontime_percField = value;
            }
        }

        /// <remarks/>
        public string seats
        {
            get
            {
                return this.seatsField;
            }
            set
            {
                this.seatsField = value;
            }
        }

        /// <remarks/>
        public string service_class
        {
            get
            {
                return this.service_classField;
            }
            set
            {
                this.service_classField = value;
            }
        }

        /// <remarks/>
        public string stops
        {
            get
            {
                return this.stopsField;
            }
            set
            {
                this.stopsField = value;
            }
        }

        /// <remarks/>
        public string baggage_claim
        {
            get
            {
                return this.baggage_claimField1;
            }
            set
            {
                this.baggage_claimField1 = value;
            }
        }

        /// <remarks/>
        public string check_in_url
        {
            get
            {
                return this.check_in_urlField;
            }
            set
            {
                this.check_in_urlField = value;
            }
        }

        /// <remarks/>
        public string conflict_resolution_url
        {
            get
            {
                return this.conflict_resolution_urlField;
            }
            set
            {
                this.conflict_resolution_urlField = value;
            }
        }

        /// <remarks/>
        public bool is_hidden
        {
            get
            {
                return this.is_hiddenField;
            }
            set
            {
                this.is_hiddenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool is_hiddenSpecified
        {
            get
            {
                return this.is_hiddenSpecifiedField;
            }
            set
            {
                this.is_hiddenSpecifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string id
        {
            get
            {
                return this.idField3;
            }
            set
            {
                this.idField3 = value;
            }
        }
    }

    public partial class FlightStatus
    {

        private DateTime scheduledDepartureDateTimeField;

        private DateTime estimatedDepartureDateTimeField;

        private DateTime scheduledArrivalDateTimeField;

        private DateTime estimatedArrivalDateTimeField;

        private FlightStatusCode flight_statusField;

        private bool is_connection_at_riskField;

        private bool is_connection_at_riskSpecifiedField;

        private string departure_terminalField;

        private string departure_gateField;

        private string arrival_terminalField;

        private string arrival_gateField;

        private string layover_minutesField;

        private string baggage_claimField;

        private string diverted_airport_codeField;

        private string last_modifiedField;

        /// <remarks/>
        public DateTime ScheduledDepartureDateTime
        {
            get
            {
                return this.scheduledDepartureDateTimeField;
            }
            set
            {
                this.scheduledDepartureDateTimeField = value;
            }
        }

        /// <remarks/>
        public DateTime EstimatedDepartureDateTime
        {
            get
            {
                return this.estimatedDepartureDateTimeField;
            }
            set
            {
                this.estimatedDepartureDateTimeField = value;
            }
        }

        /// <remarks/>
        public DateTime ScheduledArrivalDateTime
        {
            get
            {
                return this.scheduledArrivalDateTimeField;
            }
            set
            {
                this.scheduledArrivalDateTimeField = value;
            }
        }

        /// <remarks/>
        public DateTime EstimatedArrivalDateTime
        {
            get
            {
                return this.estimatedArrivalDateTimeField;
            }
            set
            {
                this.estimatedArrivalDateTimeField = value;
            }
        }

        /// <remarks/>
        public FlightStatusCode flight_status
        {
            get
            {
                return this.flight_statusField;
            }
            set
            {
                this.flight_statusField = value;
            }
        }

        /// <remarks/>
        public bool is_connection_at_risk
        {
            get
            {
                return this.is_connection_at_riskField;
            }
            set
            {
                this.is_connection_at_riskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool is_connection_at_riskSpecified
        {
            get
            {
                return this.is_connection_at_riskSpecifiedField;
            }
            set
            {
                this.is_connection_at_riskSpecifiedField = value;
            }
        }

        /// <remarks/>
        public string departure_terminal
        {
            get
            {
                return this.departure_terminalField;
            }
            set
            {
                this.departure_terminalField = value;
            }
        }

        /// <remarks/>
        public string departure_gate
        {
            get
            {
                return this.departure_gateField;
            }
            set
            {
                this.departure_gateField = value;
            }
        }

        /// <remarks/>
        public string arrival_terminal
        {
            get
            {
                return this.arrival_terminalField;
            }
            set
            {
                this.arrival_terminalField = value;
            }
        }

        /// <remarks/>
        public string arrival_gate
        {
            get
            {
                return this.arrival_gateField;
            }
            set
            {
                this.arrival_gateField = value;
            }
        }

        /// <remarks/>
        public string layover_minutes
        {
            get
            {
                return this.layover_minutesField;
            }
            set
            {
                this.layover_minutesField = value;
            }
        }

        /// <remarks/>
        public string baggage_claim
        {
            get
            {
                return this.baggage_claimField;
            }
            set
            {
                this.baggage_claimField = value;
            }
        }

        /// <remarks/>
        public string diverted_airport_code
        {
            get
            {
                return this.diverted_airport_codeField;
            }
            set
            {
                this.diverted_airport_codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string last_modified
        {
            get
            {
                return this.last_modifiedField;
            }
            set
            {
                this.last_modifiedField = value;
            }
        }
    }

    public enum FlightStatusCode
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("100")]
        Item100,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("200")]
        Item200,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("300")]
        Item300,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("301")]
        Item301,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("302")]
        Item302,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("303")]
        Item303,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("400")]
        Item400,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("401")]
        Item401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("402")]
        Item402,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("403")]
        Item403,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("404")]
        Item404,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CarObject : ReservationObject
    {

        private DateTime startDateTimeField2;

        private DateTime endDateTimeField1;

        private Address startLocationAddressField;

        private Address endLocationAddressField;

        private Traveler driverField;

        private string start_location_hoursField;

        private string start_location_nameField;

        private string start_location_phoneField;

        private string end_location_hoursField;

        private string end_location_nameField;

        private string end_location_phoneField;

        private string car_descriptionField;

        private string car_typeField;

        private string mileage_chargesField;

        /// <remarks/>
        public DateTime StartDateTime
        {
            get
            {
                return this.startDateTimeField2;
            }
            set
            {
                this.startDateTimeField2 = value;
            }
        }

        /// <remarks/>
        public DateTime EndDateTime
        {
            get
            {
                return this.endDateTimeField1;
            }
            set
            {
                this.endDateTimeField1 = value;
            }
        }

        /// <remarks/>
        public Address StartLocationAddress
        {
            get
            {
                return this.startLocationAddressField;
            }
            set
            {
                this.startLocationAddressField = value;
            }
        }

        /// <remarks/>
        public Address EndLocationAddress
        {
            get
            {
                return this.endLocationAddressField;
            }
            set
            {
                this.endLocationAddressField = value;
            }
        }

        /// <remarks/>
        public Traveler Driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }

        /// <remarks/>
        public string start_location_hours
        {
            get
            {
                return this.start_location_hoursField;
            }
            set
            {
                this.start_location_hoursField = value;
            }
        }

        /// <remarks/>
        public string start_location_name
        {
            get
            {
                return this.start_location_nameField;
            }
            set
            {
                this.start_location_nameField = value;
            }
        }

        /// <remarks/>
        public string start_location_phone
        {
            get
            {
                return this.start_location_phoneField;
            }
            set
            {
                this.start_location_phoneField = value;
            }
        }

        /// <remarks/>
        public string end_location_hours
        {
            get
            {
                return this.end_location_hoursField;
            }
            set
            {
                this.end_location_hoursField = value;
            }
        }

        /// <remarks/>
        public string end_location_name
        {
            get
            {
                return this.end_location_nameField;
            }
            set
            {
                this.end_location_nameField = value;
            }
        }

        /// <remarks/>
        public string end_location_phone
        {
            get
            {
                return this.end_location_phoneField;
            }
            set
            {
                this.end_location_phoneField = value;
            }
        }

        /// <remarks/>
        public string car_description
        {
            get
            {
                return this.car_descriptionField;
            }
            set
            {
                this.car_descriptionField = value;
            }
        }

        /// <remarks/>
        public string car_type
        {
            get
            {
                return this.car_typeField;
            }
            set
            {
                this.car_typeField = value;
            }
        }

        /// <remarks/>
        public string mileage_charges
        {
            get
            {
                return this.mileage_chargesField;
            }
            set
            {
                this.mileage_chargesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CruiseObject : ReservationObject
    {

        private CruiseSegment[] segmentField1;

        private Traveler[] travelerField1;

        private string cabin_numberField;

        private string cabin_typeField;

        private string diningField;

        private string ship_nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Segment")]
        public CruiseSegment[] Segment
        {
            get
            {
                return this.segmentField1;
            }
            set
            {
                this.segmentField1 = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Traveler")]
        public Traveler[] Traveler
        {
            get
            {
                return this.travelerField1;
            }
            set
            {
                this.travelerField1 = value;
            }
        }

        /// <remarks/>
        public string cabin_number
        {
            get
            {
                return this.cabin_numberField;
            }
            set
            {
                this.cabin_numberField = value;
            }
        }

        /// <remarks/>
        public string cabin_type
        {
            get
            {
                return this.cabin_typeField;
            }
            set
            {
                this.cabin_typeField = value;
            }
        }

        /// <remarks/>
        public string dining
        {
            get
            {
                return this.diningField;
            }
            set
            {
                this.diningField = value;
            }
        }

        /// <remarks/>
        public string ship_name
        {
            get
            {
                return this.ship_nameField;
            }
            set
            {
                this.ship_nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CruiseSegment
    {

        private DateTime startDateTimeField3;

        private DateTime endDateTimeField2;

        private Address locationAddressField;

        private string location_nameField1;

        private string detail_type_codeField1;

        private string idField4;

        /// <remarks/>
        public DateTime StartDateTime
        {
            get
            {
                return this.startDateTimeField3;
            }
            set
            {
                this.startDateTimeField3 = value;
            }
        }

        /// <remarks/>
        public DateTime EndDateTime
        {
            get
            {
                return this.endDateTimeField2;
            }
            set
            {
                this.endDateTimeField2 = value;
            }
        }

        /// <remarks/>
        public Address LocationAddress
        {
            get
            {
                return this.locationAddressField;
            }
            set
            {
                this.locationAddressField = value;
            }
        }

        /// <remarks/>
        public string location_name
        {
            get
            {
                return this.location_nameField1;
            }
            set
            {
                this.location_nameField1 = value;
            }
        }

        /// <remarks/>
        public string detail_type_code
        {
            get
            {
                return this.detail_type_codeField1;
            }
            set
            {
                this.detail_type_codeField1 = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string id
        {
            get
            {
                return this.idField4;
            }
            set
            {
                this.idField4 = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LodgingObject : ReservationObject
    {

        private DateTime startDateTimeField4;

        private DateTime endDateTimeField3;

        private Address addressField2;

        private Traveler[] guestField;

        private string number_guestsField;

        private string number_roomsField;

        private string room_typeField;

        private string bic_codeField;

        /// <remarks/>
        public DateTime StartDateTime
        {
            get
            {
                return this.startDateTimeField4;
            }
            set
            {
                this.startDateTimeField4 = value;
            }
        }

        /// <remarks/>
        public DateTime EndDateTime
        {
            get
            {
                return this.endDateTimeField3;
            }
            set
            {
                this.endDateTimeField3 = value;
            }
        }

        /// <remarks/>
        public Address Address
        {
            get
            {
                return this.addressField2;
            }
            set
            {
                this.addressField2 = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Guest")]
        public Traveler[] Guest
        {
            get
            {
                return this.guestField;
            }
            set
            {
                this.guestField = value;
            }
        }

        /// <remarks/>
        public string number_guests
        {
            get
            {
                return this.number_guestsField;
            }
            set
            {
                this.number_guestsField = value;
            }
        }

        /// <remarks/>
        public string number_rooms
        {
            get
            {
                return this.number_roomsField;
            }
            set
            {
                this.number_roomsField = value;
            }
        }

        /// <remarks/>
        public string room_type
        {
            get
            {
                return this.room_typeField;
            }
            set
            {
                this.room_typeField = value;
            }
        }

        /// <remarks/>
        public string bic_code
        {
            get
            {
                return this.bic_codeField;
            }
            set
            {
                this.bic_codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RailObject : ReservationObject
    {

        private RailSegment[] segmentField2;

        private Traveler[] travelerField2;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Segment")]
        public RailSegment[] Segment
        {
            get
            {
                return this.segmentField2;
            }
            set
            {
                this.segmentField2 = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Traveler")]
        public Traveler[] Traveler
        {
            get
            {
                return this.travelerField2;
            }
            set
            {
                this.travelerField2 = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RailSegment
    {

        private DateTime startDateTimeField5;

        private DateTime endDateTimeField4;

        private Address startStationAddressField;

        private Address endStationAddressField;

        private string start_station_nameField;

        private string end_station_nameField;

        private string carrier_nameField;

        private string coach_numberField;

        private string confirmation_numField;

        private string seatsField1;

        private string service_classField1;

        private string train_numberField;

        private string train_typeField;

        private string idField5;

        /// <remarks/>
        public DateTime StartDateTime
        {
            get
            {
                return this.startDateTimeField5;
            }
            set
            {
                this.startDateTimeField5 = value;
            }
        }

        /// <remarks/>
        public DateTime EndDateTime
        {
            get
            {
                return this.endDateTimeField4;
            }
            set
            {
                this.endDateTimeField4 = value;
            }
        }

        /// <remarks/>
        public Address StartStationAddress
        {
            get
            {
                return this.startStationAddressField;
            }
            set
            {
                this.startStationAddressField = value;
            }
        }

        /// <remarks/>
        public Address EndStationAddress
        {
            get
            {
                return this.endStationAddressField;
            }
            set
            {
                this.endStationAddressField = value;
            }
        }

        /// <remarks/>
        public string start_station_name
        {
            get
            {
                return this.start_station_nameField;
            }
            set
            {
                this.start_station_nameField = value;
            }
        }

        /// <remarks/>
        public string end_station_name
        {
            get
            {
                return this.end_station_nameField;
            }
            set
            {
                this.end_station_nameField = value;
            }
        }

        /// <remarks/>
        public string carrier_name
        {
            get
            {
                return this.carrier_nameField;
            }
            set
            {
                this.carrier_nameField = value;
            }
        }

        /// <remarks/>
        public string coach_number
        {
            get
            {
                return this.coach_numberField;
            }
            set
            {
                this.coach_numberField = value;
            }
        }

        /// <remarks/>
        public string confirmation_num
        {
            get
            {
                return this.confirmation_numField;
            }
            set
            {
                this.confirmation_numField = value;
            }
        }

        /// <remarks/>
        public string seats
        {
            get
            {
                return this.seatsField1;
            }
            set
            {
                this.seatsField1 = value;
            }
        }

        /// <remarks/>
        public string service_class
        {
            get
            {
                return this.service_classField1;
            }
            set
            {
                this.service_classField1 = value;
            }
        }

        /// <remarks/>
        public string train_number
        {
            get
            {
                return this.train_numberField;
            }
            set
            {
                this.train_numberField = value;
            }
        }

        /// <remarks/>
        public string train_type
        {
            get
            {
                return this.train_typeField;
            }
            set
            {
                this.train_typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string id
        {
            get
            {
                return this.idField5;
            }
            set
            {
                this.idField5 = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RestaurantObject : ReservationObject
    {

        private DateTime dateTimeField;

        private Address addressField3;

        private Traveler reservationHolderField;

        private string cuisineField;

        private string dress_codeField;

        private string hoursField;

        private string number_patronsField;

        private string price_rangeField;

        /// <remarks/>
        public DateTime DateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        public Address Address
        {
            get
            {
                return this.addressField3;
            }
            set
            {
                this.addressField3 = value;
            }
        }

        /// <remarks/>
        public Traveler ReservationHolder
        {
            get
            {
                return this.reservationHolderField;
            }
            set
            {
                this.reservationHolderField = value;
            }
        }

        /// <remarks/>
        public string cuisine
        {
            get
            {
                return this.cuisineField;
            }
            set
            {
                this.cuisineField = value;
            }
        }

        /// <remarks/>
        public string dress_code
        {
            get
            {
                return this.dress_codeField;
            }
            set
            {
                this.dress_codeField = value;
            }
        }

        /// <remarks/>
        public string hours
        {
            get
            {
                return this.hoursField;
            }
            set
            {
                this.hoursField = value;
            }
        }

        /// <remarks/>
        public string number_patrons
        {
            get
            {
                return this.number_patronsField;
            }
            set
            {
                this.number_patronsField = value;
            }
        }

        /// <remarks/>
        public string price_range
        {
            get
            {
                return this.price_rangeField;
            }
            set
            {
                this.price_rangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TransportObject : ReservationObject
    {

        private TransportSegment[] segmentField3;

        private Traveler[] travelerField3;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Segment")]
        public TransportSegment[] Segment
        {
            get
            {
                return this.segmentField3;
            }
            set
            {
                this.segmentField3 = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Traveler")]
        public Traveler[] Traveler
        {
            get
            {
                return this.travelerField3;
            }
            set
            {
                this.travelerField3 = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TransportSegment
    {

        private DateTime startDateTimeField6;

        private DateTime endDateTimeField5;

        private Address startLocationAddressField1;

        private Address endLocationAddressField1;

        private string start_location_nameField1;

        private string end_location_nameField1;

        private string detail_type_codeField2;

        private string carrier_nameField1;

        private string confirmation_numField1;

        private string number_passengersField;

        private string vehicle_descriptionField;

        private string idField6;

        /// <remarks/>
        public DateTime StartDateTime
        {
            get
            {
                return this.startDateTimeField6;
            }
            set
            {
                this.startDateTimeField6 = value;
            }
        }

        /// <remarks/>
        public DateTime EndDateTime
        {
            get
            {
                return this.endDateTimeField5;
            }
            set
            {
                this.endDateTimeField5 = value;
            }
        }

        /// <remarks/>
        public Address StartLocationAddress
        {
            get
            {
                return this.startLocationAddressField1;
            }
            set
            {
                this.startLocationAddressField1 = value;
            }
        }

        /// <remarks/>
        public Address EndLocationAddress
        {
            get
            {
                return this.endLocationAddressField1;
            }
            set
            {
                this.endLocationAddressField1 = value;
            }
        }

        /// <remarks/>
        public string start_location_name
        {
            get
            {
                return this.start_location_nameField1;
            }
            set
            {
                this.start_location_nameField1 = value;
            }
        }

        /// <remarks/>
        public string end_location_name
        {
            get
            {
                return this.end_location_nameField1;
            }
            set
            {
                this.end_location_nameField1 = value;
            }
        }

        /// <remarks/>
        public string detail_type_code
        {
            get
            {
                return this.detail_type_codeField2;
            }
            set
            {
                this.detail_type_codeField2 = value;
            }
        }

        /// <remarks/>
        public string carrier_name
        {
            get
            {
                return this.carrier_nameField1;
            }
            set
            {
                this.carrier_nameField1 = value;
            }
        }

        /// <remarks/>
        public string confirmation_num
        {
            get
            {
                return this.confirmation_numField1;
            }
            set
            {
                this.confirmation_numField1 = value;
            }
        }

        /// <remarks/>
        public string number_passengers
        {
            get
            {
                return this.number_passengersField;
            }
            set
            {
                this.number_passengersField = value;
            }
        }

        /// <remarks/>
        public string vehicle_description
        {
            get
            {
                return this.vehicle_descriptionField;
            }
            set
            {
                this.vehicle_descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string id
        {
            get
            {
                return this.idField6;
            }
            set
            {
                this.idField6 = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DirectionsObject : Object
    {

        private DateTime dateTimeField1;

        private Address startAddressField;

        private Address endAddressField;

        private string detail_type_codeField3;

        /// <remarks/>
        public DateTime DateTime
        {
            get
            {
                return this.dateTimeField1;
            }
            set
            {
                this.dateTimeField1 = value;
            }
        }

        /// <remarks/>
        public Address StartAddress
        {
            get
            {
                return this.startAddressField;
            }
            set
            {
                this.startAddressField = value;
            }
        }

        /// <remarks/>
        public Address EndAddress
        {
            get
            {
                return this.endAddressField;
            }
            set
            {
                this.endAddressField = value;
            }
        }

        /// <remarks/>
        public string detail_type_code
        {
            get
            {
                return this.detail_type_codeField3;
            }
            set
            {
                this.detail_type_codeField3 = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MapObject : Object
    {

        private DateTime dateTimeField2;

        private Address addressField4;

        /// <remarks/>
        public DateTime DateTime
        {
            get
            {
                return this.dateTimeField2;
            }
            set
            {
                this.dateTimeField2 = value;
            }
        }

        /// <remarks/>
        public Address Address
        {
            get
            {
                return this.addressField4;
            }
            set
            {
                this.addressField4 = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class NoteObject : Object
    {

        private DateTime dateTimeField3;

        private Address addressField5;

        private string detail_type_codeField4;

        private string sourceField;

        private string textField;

        private string urlField1;

        private string notesField3;

        /// <remarks/>
        public DateTime DateTime
        {
            get
            {
                return this.dateTimeField3;
            }
            set
            {
                this.dateTimeField3 = value;
            }
        }

        /// <remarks/>
        public Address Address
        {
            get
            {
                return this.addressField5;
            }
            set
            {
                this.addressField5 = value;
            }
        }

        /// <remarks/>
        public string detail_type_code
        {
            get
            {
                return this.detail_type_codeField4;
            }
            set
            {
                this.detail_type_codeField4 = value;
            }
        }

        /// <remarks/>
        public string source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField1;
            }
            set
            {
                this.urlField1 = value;
            }
        }

        /// <remarks/>
        public string notes
        {
            get
            {
                return this.notesField3;
            }
            set
            {
                this.notesField3 = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WeatherObject : Object
    {

        private System.DateTime dateField1;

        private bool dateSpecifiedField1;

        private string locationField;

        private double avg_high_temp_cField;

        private bool avg_high_temp_cSpecifiedField;

        private double avg_low_temp_cField;

        private bool avg_low_temp_cSpecifiedField;

        private double avg_wind_speed_knField;

        private bool avg_wind_speed_knSpecifiedField;

        private double avg_precipitation_cmField;

        private bool avg_precipitation_cmSpecifiedField;

        private double avg_snow_depth_cmField;

        private bool avg_snow_depth_cmSpecifiedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime date
        {
            get
            {
                return this.dateField1;
            }
            set
            {
                this.dateField1 = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool dateSpecified
        {
            get
            {
                return this.dateSpecifiedField1;
            }
            set
            {
                this.dateSpecifiedField1 = value;
            }
        }

        /// <remarks/>
        public string location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public double avg_high_temp_c
        {
            get
            {
                return this.avg_high_temp_cField;
            }
            set
            {
                this.avg_high_temp_cField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool avg_high_temp_cSpecified
        {
            get
            {
                return this.avg_high_temp_cSpecifiedField;
            }
            set
            {
                this.avg_high_temp_cSpecifiedField = value;
            }
        }

        /// <remarks/>
        public double avg_low_temp_c
        {
            get
            {
                return this.avg_low_temp_cField;
            }
            set
            {
                this.avg_low_temp_cField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool avg_low_temp_cSpecified
        {
            get
            {
                return this.avg_low_temp_cSpecifiedField;
            }
            set
            {
                this.avg_low_temp_cSpecifiedField = value;
            }
        }

        /// <remarks/>
        public double avg_wind_speed_kn
        {
            get
            {
                return this.avg_wind_speed_knField;
            }
            set
            {
                this.avg_wind_speed_knField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool avg_wind_speed_knSpecified
        {
            get
            {
                return this.avg_wind_speed_knSpecifiedField;
            }
            set
            {
                this.avg_wind_speed_knSpecifiedField = value;
            }
        }

        /// <remarks/>
        public double avg_precipitation_cm
        {
            get
            {
                return this.avg_precipitation_cmField;
            }
            set
            {
                this.avg_precipitation_cmField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool avg_precipitation_cmSpecified
        {
            get
            {
                return this.avg_precipitation_cmSpecifiedField;
            }
            set
            {
                this.avg_precipitation_cmSpecifiedField = value;
            }
        }

        /// <remarks/>
        public double avg_snow_depth_cm
        {
            get
            {
                return this.avg_snow_depth_cmField;
            }
            set
            {
                this.avg_snow_depth_cmField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool avg_snow_depth_cmSpecified
        {
            get
            {
                return this.avg_snow_depth_cmSpecifiedField;
            }
            set
            {
                this.avg_snow_depth_cmSpecifiedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PointsProgram
    {

        private string idField7;

        private string nameField;

        private string account_numberField;

        private string account_loginField;

        private string balanceField;

        private string elite_statusField;

        private string elite_next_statusField;

        private string elite_ytd_qualifyField;

        private string elite_need_to_earnField;

        private string last_modifiedField1;

        private string total_num_activitiesField;

        private string total_num_expirationsField;

        private string error_messageField;

        private PointsProgramActivity[] activityField;

        private PointsProgramExpiration[] expirationField;

        private string urlField2;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string id
        {
            get
            {
                return this.idField7;
            }
            set
            {
                this.idField7 = value;
            }
        }

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
        public string account_number
        {
            get
            {
                return this.account_numberField;
            }
            set
            {
                this.account_numberField = value;
            }
        }

        /// <remarks/>
        public string account_login
        {
            get
            {
                return this.account_loginField;
            }
            set
            {
                this.account_loginField = value;
            }
        }

        /// <remarks/>
        public string balance
        {
            get
            {
                return this.balanceField;
            }
            set
            {
                this.balanceField = value;
            }
        }

        /// <remarks/>
        public string elite_status
        {
            get
            {
                return this.elite_statusField;
            }
            set
            {
                this.elite_statusField = value;
            }
        }

        /// <remarks/>
        public string elite_next_status
        {
            get
            {
                return this.elite_next_statusField;
            }
            set
            {
                this.elite_next_statusField = value;
            }
        }

        /// <remarks/>
        public string elite_ytd_qualify
        {
            get
            {
                return this.elite_ytd_qualifyField;
            }
            set
            {
                this.elite_ytd_qualifyField = value;
            }
        }

        /// <remarks/>
        public string elite_need_to_earn
        {
            get
            {
                return this.elite_need_to_earnField;
            }
            set
            {
                this.elite_need_to_earnField = value;
            }
        }

        public string last_modified
        {
            get
            {
                return this.last_modifiedField1;
            }
            set
            {
                this.last_modifiedField1 = value;
            }
        }

        /// <remarks/>
        public string total_num_activities
        {
            get
            {
                return this.total_num_activitiesField;
            }
            set
            {
                this.total_num_activitiesField = value;
            }
        }

        /// <remarks/>
        public string total_num_expirations
        {
            get
            {
                return this.total_num_expirationsField;
            }
            set
            {
                this.total_num_expirationsField = value;
            }
        }

        /// <remarks/>
        public string error_message
        {
            get
            {
                return this.error_messageField;
            }
            set
            {
                this.error_messageField = value;
            }
        }

        /// <remarks/>
        public PointsProgramActivity[] Activity
        {
            get
            {
                return this.activityField;
            }
            set
            {
                this.activityField = value;
            }
        }

        /// <remarks/>
        public PointsProgramExpiration[] Expiration
        {
            get
            {
                return this.expirationField;
            }
            set
            {
                this.expirationField = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField2;
            }
            set
            {
                this.urlField2 = value;
            }
        }
    }

    /// <remarks/>

    public partial class PointsProgramActivity
    {

        private System.DateTime dateField2;

        private string descriptionField3;

        private string baseField;

        private string bonusField;

        private string totalField;

        /// <remarks/>

        public System.DateTime date
        {
            get
            {
                return this.dateField2;
            }
            set
            {
                this.dateField2 = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField3;
            }
            set
            {
                this.descriptionField3 = value;
            }
        }

        /// <remarks/>
        public string @base
        {
            get
            {
                return this.baseField;
            }
            set
            {
                this.baseField = value;
            }
        }

        /// <remarks/>
        public string bonus
        {
            get
            {
                return this.bonusField;
            }
            set
            {
                this.bonusField = value;
            }
        }

        /// <remarks/>
        public string total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }
    }


    public partial class PointsProgramExpiration
    {

        private System.DateTime dateField3;

        private string amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime date
        {
            get
            {
                return this.dateField3;
            }
            set
            {
                this.dateField3 = value;
            }
        }

        /// <remarks/>
        public string amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Profile
    {

        private string refField;

        private ProfileEmailAddress[] profileEmailAddressesField;

        private Group[] groupMembershipsField;

        private bool is_clientField;

        private bool is_proField;

        private string screen_nameField;

        private string public_display_nameField;

        private string profile_urlField;

        private string home_cityField;

        private string companyField;

        private string about_me_infoField;

        private string photo_urlField;

        private string activity_feed_urlField;

        private string alerts_feed_urlField;

        private string ical_urlField;

        private string sms_phone_numberField;

        private string sms_country_codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public ProfileEmailAddress[] ProfileEmailAddresses
        {
            get
            {
                return this.profileEmailAddressesField;
            }
            set
            {
                this.profileEmailAddressesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public Group[] GroupMemberships
        {
            get
            {
                return this.groupMembershipsField;
            }
            set
            {
                this.groupMembershipsField = value;
            }
        }

        /// <remarks/>
        public bool is_client
        {
            get
            {
                return this.is_clientField;
            }
            set
            {
                this.is_clientField = value;
            }
        }

        /// <remarks/>
        public bool is_pro
        {
            get
            {
                return this.is_proField;
            }
            set
            {
                this.is_proField = value;
            }
        }

        /// <remarks/>
        public string screen_name
        {
            get
            {
                return this.screen_nameField;
            }
            set
            {
                this.screen_nameField = value;
            }
        }

        /// <remarks/>
        public string public_display_name
        {
            get
            {
                return this.public_display_nameField;
            }
            set
            {
                this.public_display_nameField = value;
            }
        }

        /// <remarks/>
        public string profile_url
        {
            get
            {
                return this.profile_urlField;
            }
            set
            {
                this.profile_urlField = value;
            }
        }

        /// <remarks/>
        public string home_city
        {
            get
            {
                return this.home_cityField;
            }
            set
            {
                this.home_cityField = value;
            }
        }

        /// <remarks/>
        public string company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }

        /// <remarks/>
        public string about_me_info
        {
            get
            {
                return this.about_me_infoField;
            }
            set
            {
                this.about_me_infoField = value;
            }
        }

        /// <remarks/>
        public string photo_url
        {
            get
            {
                return this.photo_urlField;
            }
            set
            {
                this.photo_urlField = value;
            }
        }

        /// <remarks/>
        public string activity_feed_url
        {
            get
            {
                return this.activity_feed_urlField;
            }
            set
            {
                this.activity_feed_urlField = value;
            }
        }

        /// <remarks/>
        public string alerts_feed_url
        {
            get
            {
                return this.alerts_feed_urlField;
            }
            set
            {
                this.alerts_feed_urlField = value;
            }
        }

        /// <remarks/>
        public string ical_url
        {
            get
            {
                return this.ical_urlField;
            }
            set
            {
                this.ical_urlField = value;
            }
        }

        /// <remarks/>
        public string sms_phone_number
        {
            get
            {
                return this.sms_phone_numberField;
            }
            set
            {
                this.sms_phone_numberField = value;
            }
        }

        /// <remarks/>
        public string sms_country_code
        {
            get
            {
                return this.sms_country_codeField;
            }
            set
            {
                this.sms_country_codeField = value;
            }
        }
    }


    public partial class ProfileEmailAddress
    {

        private string addressField6;

        private bool is_auto_importField;

        private bool is_confirmedField;

        private bool is_primaryField;

        /// <remarks/>
        public string address
        {
            get
            {
                return this.addressField6;
            }
            set
            {
                this.addressField6 = value;
            }
        }

        /// <remarks/>
        public bool is_auto_import
        {
            get
            {
                return this.is_auto_importField;
            }
            set
            {
                this.is_auto_importField = value;
            }
        }

        /// <remarks/>
        public bool is_confirmed
        {
            get
            {
                return this.is_confirmedField;
            }
            set
            {
                this.is_confirmedField = value;
            }
        }

        /// <remarks/>
        public bool is_primary
        {
            get
            {
                return this.is_primaryField;
            }
            set
            {
                this.is_primaryField = value;
            }
        }
    }


    public partial class Group
    {

        private string display_nameField2;

        private string urlField3;

        /// <remarks/>
        public string display_name
        {
            get
            {
                return this.display_nameField2;
            }
            set
            {
                this.display_nameField2 = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField3;
            }
            set
            {
                this.urlField3 = value;
            }
        }
    }
}
