using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RijksMuseum.APIs.rijks
{
       [DataContract]
    public class Person
    {
        [DataMember(Name = "name")]
        public String name { get; set; }

        [DataMember(Name = "unFixedName")]
        public String unFixedName { get; set; }

        [DataMember(Name = "placeOfBirth")]
        public String placeOfBirth { get; set; }

        [DataMember(Name = "dateOfBirth")]
        public String dateOfBirth { get; set; }

        [DataMember(Name = "dateOfBirthPrecision")]
        public String dateOfBirthPrecision { get; set; }

        [DataMember(Name = "dateOfDeath")]
        public String dateOfDeath { get; set; }

        [DataMember(Name = "dateOfDeathPrecision")]
        public String dateOfDeathPrecision { get; set; }

        [DataMember(Name = "placeOfDeath")]
        public String placeOfDeath { get; set; }

        [DataMember(Name = "occupation")]
        public List<String> occupation { get; set; }

        [DataMember(Name = "roles")]
        public List<String> roles { get; set; }

        [DataMember(Name = "nationality")]
        public String nationality { get; set; }

        [DataMember(Name = "biography")]
        public String biography { get; set; }

        [DataMember(Name = "productionPlaces")]
        public List<String> productionPlaces { get; set; }

        [DataMember(Name = "schoolStyles")]
        public List<String> schoolStyles { get; set; }

        [DataMember(Name = "qualification")]
        public String qualification { get; set; }
    }
}
