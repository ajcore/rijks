using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RijksMuseum.APIs.rijks
{
    [DataContract]
    public class CollectionModel
    {
        [DataMember(Name = "elapsedMilliseconds")]
        public int elapseMilliseconds { get; set; }

        [DataMember(Name = "count")]
        public int count { get; set; }

        [DataMember(Name = "artObjects")]
        public List<ArtObjects> artObjects { get; set; }

        public class ArtObjects
        {
            [DataMember(Name = "links")]
            public Links links { get; set; }

            public class Links
            {
                [DataMember(Name = "self")]
                public String self { get; set; }

                [DataMember(Name = "web")]
                public String web { get; set; }
            }

            [DataMember(Name = "id")]
            public String id { get; set; }

            [DataMember(Name = "objectNumber")]
            public String objectNumber { get; set; }

            [DataMember(Name = "title")]
            public String title { get; set; }

            [DataMember(Name = "hasImage")]
            public bool hasImage { get; set; }

            [DataMember(Name = "principalOrFirstMaker")]
            public String principalOrFirstMaker { get; set; }

            [DataMember(Name = "longTitle")]
            public String longTitle { get; set; }

            [DataMember(Name = "showImage")]
            public bool showImage { get; set; }

            [DataMember(Name = "permitDownload")]
            public bool permitDownload { get; set; }

            [DataMember(Name = "webImage")]
            public ArtImage webImage { get; set; }

            [DataMember(Name = "headerImage")]
            public ArtImage headerImage { get; set; }

            [DataMember(Name = "productionPlaces")]
            public List<String> productionPlaces { get; set; }
        }
    }
}
