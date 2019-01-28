using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RijksMuseum.APIs.rijks
{
    [DataContract]
    public class CalendarModel
    {
        [DataMember(Name = "elapseMilliseconds")]
        public int elapsedMilliseconds { get; set; }

        [DataMember(Name = "options")]
        public List<Option> options { get; set; }

        public class Option
        {
            [DataMember(Name = "links")]
            public Link links { get; set; }

            public class Link
            {
                [DataMember(Name = "availability")]
                public String availability { get; set; }

                [DataMember(Name = "web")]
                public String web { get; set; }
            }

            [DataMember(Name = "id")]
            public String id { get; set; }

            [DataMember(Name = "lang")]
            public String lang { get; set; }

            [DataMember(Name = "date")]
            public String date { get; set; }

            [DataMember(Name = "period")]
            public Period period { get; set; }

            public class Period
            {
                [DataMember(Name = "id")]
                public String id { get; set; }

                [DataMember(Name = "startDate")]
                public String startDate { get; set; }

                [DataMember(Name = "endDate")]
                public String endDate { get; set; }

                [DataMember(Name = "current")]
                public int current { get; set; }

                [DataMember(Name = "maximum")]
                public int maximum { get; set; }

                [DataMember(Name = "remaining")]
                public int remaining { get; set; }

                [DataMember(Name = "code")]
                public String code { get; set; }

                [DataMember(Name = "text")]
                public String text { get; set; }
            }

            [DataMember(Name = "exposition")]
            public Exposition exposition { get; set; }

            public class Exposition
            {
                [DataMember(Name = "id")]
                public String id { get; set; }

                [DataMember(Name = "name")]
                public String name { get; set; }

                [DataMember(Name = "description")]
                public String description { get; set; }

                [DataMember(Name = "code")]
                public String code { get; set; }

                [DataMember(Name = "price")]
                public Price price { get; set; }

                public class Price
                {
                    [DataMember(Name = "id")]
                    public String id { get; set; }

                    [DataMember(Name = "calculationType")]
                    public int calculationType { get; set; }

                    [DataMember(Name = "amount")]
                    public float amount { get; set; }
                }
            }

            [DataMember(Name = "groupType")]
            public Type groupType { get; set; }

            public class Type
            {
                [DataMember(Name = "type")]
                public String type { get; set; }

                [DataMember(Name = "guid")]
                public String guid { get; set; }

                [DataMember(Name = "friendlyName")]
                public String friendlyName { get; set; }
            }

            [DataMember(Name = "pageRef")]
            public Reference pageRef { get; set; }

            public class Reference
            {
                [DataMember(Name = "title")]
                public String title { get; set; }

                [DataMember(Name = "url")]
                public String url { get; set; }
            }

            [DataMember(Name = "expositionType")]
            public Type expositionType { get; set; }

        }
    }
}
