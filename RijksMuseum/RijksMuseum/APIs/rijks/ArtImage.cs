using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RijksMuseum.APIs.rijks
{
    [DataContract]
    public class ArtImage
    {
        [DataMember(Name = "guid")]
        public String guid { get; set; }

        [DataMember(Name = "offsetPercentageX")]
        public int offsetPercentageX { get; set; }

        [DataMember(Name = "offsetPercentageY")]
        public int offsetPercentageY { get; set; }

        [DataMember(Name = "width")]
        public int width { get; set; }

        [DataMember(Name = "height")]
        public int height { get; set; }

        [DataMember(Name = "url")]
        public String url { get; set; }
    }
}
