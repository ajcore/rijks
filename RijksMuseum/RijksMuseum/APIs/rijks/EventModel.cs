using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RijksMuseum.APIs.rijks
{
    [DataContract]
    public class EventModel
    {
        [DataMember(Name = "elapsedMilliseconds")]
        public int elapsedMilliseconds { get; set; }

        [DataMember(Name = "total")]
        public int total { get; set; }

        [DataMember(Name = "available")]
        public int available { get; set; }
    }
}
