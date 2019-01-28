using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RijksMuseum.APIs.rijks
{
    [DataContract]
    public class ContentPageModel
    {
        [DataMember(Name = "elapsedMilliseconds")]
        public int elapseMilliseconds { get; set; }

        [DataMember(Name = "contentPage")]
        public Page contentPage { get; set; }

        public class Page
        {
            [DataMember(Name = "thumbnailLandscape")]
            public Thumbnail thumbnailLandscape { get; set; }

            public class Thumbnail
            {
                [DataMember(Name = "name")]
                public String name { get; set; }

                [DataMember(Name = "url")]
                public String url { get; set; }
            }

            [DataMember(Name = "inOverview")]
            public bool inOverview { get; set; }

            [DataMember(Name = "isHighlightedOnOverview")]
            public bool isHighlightedOnOverview { get; set; }

            [DataMember(Name = "artistBio")]
            public String artistBio { get; set; }

            [DataMember(Name = "maker")]
            public Person maker { get; set; }

            [DataMember(Name = "subject")]
            public String subject { get; set; }

            [DataMember(Name = "callToAction")]
            public String callToAction { get; set; }

            [DataMember(Name = "callToActionQuery")]
            public String callToActionQuery { get; set; }

            [DataMember(Name = "artObjectSet")]
            public List<String> artObjectSet { get; set; }

            [DataMember(Name = "mediaBlocks")]
            public List<String> mediaBlocks { get; set; }

            [DataMember(Name = "artobjects_on_this_page")]
            public List<String> artobjects_on_this_page { get; set; }

            [DataMember(Name = "id")]
            public String id { get; set; }

            [DataMember(Name = "guid")]
            public String guid { get; set; }

            [DataMember(Name = "lang")]
            public String lang { get; set; }

            [DataMember(Name = "compactHeader")]
            public bool compactHeader { get; set; }

            [DataMember(Name = "shortcutKeywords")]
            public List<String> shortcutKeywords { get; set; }

            [DataMember(Name = "otherLangs")]
            public List<String> otherLangs { get; set; }

            [DataMember(Name = "headerImage")]
            public String headerImage { get; set; }

            [DataMember(Name = "thumbnail")]
            public String thumbnail { get; set; }

            [DataMember(Name = "title")]
            public String title { get; set; }

            [DataMember(Name = "description")]
            public String description { get; set; }

            [DataMember(Name = "body")]
            public HTML body { get; set; }

            public class HTML
            {
                [DataMember(Name = "markdown")]
                public String markdown { get; set; }
                [DataMember(Name = "html")]
                public String html { get; set; }
            }

            [DataMember(Name = "createdOn")]
            public String createdOn { get; set; }

            [DataMember(Name = "updatedOn")]
            public String updatedOn { get; set; }
        }

        [DataMember(Name = "similarPages")]
        public String similarPages { get; set; }
    }
}
