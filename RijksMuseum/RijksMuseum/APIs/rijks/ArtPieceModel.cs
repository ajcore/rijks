using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RijksMuseum.APIs.rijks
{
    [DataContract]
    public class ArtPieceModel
    {
        [DataMember(Name = "elapsedMilliseconds" )]
        public int elapsedMilliseconds { get; set; }

        [DataMember(Name = "artObject")]
        public ArtObject artObject { get; set; }

        public class ArtObject
        {
            [DataMember(Name = "links")]
            public SearchLink links { get; set; }

            public class SearchLink
            {
                [DataMember(Name = "search")]
                public String search { get; set; }
            }

            [DataMember(Name = "id")]
            public String id { get; set; }

            [DataMember(Name = "priref")]
            public String priref { get; set; }

            [DataMember(Name = "objectNumber")]
            public String ObjectNumber { get; set; }

            [DataMember(Name = "language")]
            public String language { get; set; }

            [DataMember(Name = "title")]
            public String title { get; set; }

            [DataMember(Name = "tags")]
            public List<Tag> tags { get; set; }

            public class Tag
            {
                [DataMember(Name = "userId")]
                public int userId { get; set; }

                [DataMember(Name = "name")]
                public String name { get; set; }

                [DataMember(Name = "lang")]
                public String lang { get; set; }

                [DataMember(Name = "objectNumber")]
                public String objectNumber { get; set; }
            }

            [DataMember(Name = "copyrightHolder")]
            public String copyrightHolder { get; set; }

            [DataMember(Name = "webImage")]
            public ArtImage webImage { get; set; }

            [DataMember(Name = "colors")]
            public List<String> colors { get; set; }

            [DataMember(Name = "colorsWithNormalization")]
            public List<NormalizationColor> colorsWithNormalization { get; set; }

            public class NormalizationColor
            {
                [DataMember(Name = "originalHex")]
                public String originalHex { get; set; }

                [DataMember(Name = "normalizedHex")]
                public String normalizedHex { get; set; }
            }

            [DataMember(Name = "normalizedColors")]
            public List<String> normalizedColors { get; set; }

            [DataMember(Name = "normalized32Colors")]
            public List<String> normalized32Colors { get; set; }

            [DataMember(Name = "titles")]
            public List<String> titles { get; set; }

            [DataMember(Name = "description")]
            public String description { get; set; }

            [DataMember(Name = "labelText")]
            public String labelText { get; set; }

            [DataMember(Name = "objectTypes")]
            public List<String> objectTypes { get; set; }

            [DataMember(Name = "makers")]
            public Person makers { get; set; }

            [DataMember(Name = "principalMakers")]
            public Person principalMakers { get; set; }

            [DataMember(Name = "plaqueDescriptionDutch")]
            public String plaqueDescriptionDutch { get; set; }

            [DataMember(Name = "plaqueDescriptionEnglish")]
            public String plaqueDescriptionEnglish { get; set; }

            [DataMember(Name = "principalMaker")]
            public String principalMaker { get; set; }

            [DataMember(Name = "artistRole")]
            public String artistRole { get; set; }

            [DataMember(Name = "associations")]
            public List<String> associations { get; set; }

            [DataMember(Name = "acquisition")]
            public Acquisition acquisition { get; set; }

            public class Acquisition
            {
                [DataMember(Name = "method")]
                public String method { get; set; }

                [DataMember(Name = "date")]
                public String date { get; set; }

                [DataMember(Name = "creditLine")]
                public String creditLine { get; set; }
            }

            [DataMember(Name = "exhibitions")]
            public List<String> exhibitions { get; set; }

            [DataMember(Name = "materials")]
            public List<String> materials { get; set; }

            [DataMember(Name = "techniques")]
            public List<String> techniques { get; set; }

            [DataMember(Name = "productionPlaces")]
            public List<String> productionPlaces { get; set; }

            [DataMember(Name = "dating")]
            public HistoricalDating dating { get; set; }

            public class HistoricalDating
            {
                [DataMember(Name = "presentingDate")]
                public String presentingDate { get; set; }

                [DataMember(Name = "sortingDate")]
                public int sortingDate { get; set; }

                [DataMember(Name = "period")]
                public int period { get; set; }
            }

            [DataMember(Name = "classification")]
            public Classification classification { get; set; }

            public class Classification
            {
                [DataMember(Name = "iconClassIdentifier")]
                public List<String> iconClassIdentifier { get; set; }

                [DataMember(Name = "motifs")]
                public List<String> motifs { get; set; }

                [DataMember(Name = "events")]
                public List<String> events { get; set; }

                [DataMember(Name = "periods")]
                public List<String> periods { get; set; }

                [DataMember(Name = "places")]
                public List<String> places { get; set; }

                [DataMember(Name = "people")]
                public List<String> people { get; set; }
            }

            [DataMember(Name = "hasImage")]
            public bool hasImage { get; set; }

            [DataMember(Name = "historicalPersons")]
            public List<String> historicalPersons { get; set; }

            [DataMember(Name = "inscriptions")]
            public List<String> inscriptions { get; set; }

            [DataMember(Name = "documentation")]
            public List<String> documentation { get; set; }

            [DataMember(Name = "catRefRPK")]
            public List<String> catRefRPK { get; set; }

            [DataMember(Name = "dimensions")]
            public List<Dimensions> dimensions { get; set; }

            public class Dimensions
            {
                [DataMember(Name = "unit")]
                public String unit { get; set; }

                [DataMember(Name = "type")]
                public String type { get; set; }

                [DataMember(Name = "part")]
                public String part { get; set; }

                [DataMember(Name = "value")]
                public String value { get; set; }
            }

            [DataMember(Name = "physicalProperties")]
            public List<String> physicalProperties { get; set; }

            [DataMember(Name = "physicalMedium")]
            public String physicalMedium { get; set; }

            [DataMember(Name = "longTitle")]
            public String longTitle { get; set; }

            [DataMember(Name = "subTitle")]
            public String subTitle { get; set; }

            [DataMember(Name = "scLabelLine")]
            public String scLabelLine { get; set; }

            [DataMember(Name = "label")]
            public Label label { get; set; }

            public class Label
            {
                [DataMember(Name = "title")]
                public String title { get; set; }

                [DataMember(Name = "makerLine")]
                public String makerLine { get; set; }

                [DataMember(Name = "description")]
                public String description { get; set; }

                [DataMember(Name = "notes")]
                public String notes { get; set; }

                [DataMember(Name = "date")]
                public String date { get; set; }
            }

            [DataMember(Name = "showImage")]
            public bool showImage { get; set; }
        }

        [DataMember(Name = "artObjectPage")]
        public ArtObjectPage artObjectPage { get; set; }

        public class ArtObjectPage
        {
            [DataMember(Name = "id")]
            public String id { get; set; }

            [DataMember(Name = "similarPages")]
            public List<String> similarPages { get; set; }

            [DataMember(Name = "lang")]
            public String lang { get; set; }

            [DataMember(Name = "objectNumber")]
            public String objectNumber { get; set; }

            [DataMember(Name = "tags")]
            public String tags { get; set; }

            [DataMember(Name = "plaqueDescription")]
            public String plaqueDescription { get; set; }

            [DataMember(Name = "audioFile1")]
            public String audioFile1 { get; set; }

            [DataMember(Name = "audioFileLabel1")]
            public String audioFileLabel1 { get; set; }

            [DataMember(Name = "audioFileLabel2")]
            public String audioFileLabel2 { get; set; }

            [DataMember(Name = "createdOn")]
            public String createdOn { get; set; }

            [DataMember(Name = "updatedOn")]
            public String updatedOn { get; set; }

            [DataMember(Name = "adlibOverrides")]
            public Adlib adlibOverrides { get; set; }

            public class Adlib
            {
                //Not a mistake, they misspelled title in json response
                [DataMember(Name = "titel")]
                public String titel { get; set; }

                [DataMember(Name = "maker")]
                public String maker { get; set; }

                //Not a mistake, they misspelled eticketText in json response
                [DataMember(Name = "etiketText")]
                public String etiketText { get; set; }

            }
        }
    }
}
