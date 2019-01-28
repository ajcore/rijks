using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RijksMuseum.APIs.rijks
{
    [DataContract]
    public class ImageTileModel
    {
        [DataMember(Name = "levels")]
        public List<Level> levels { get; set; }

        public class Level
        {
            [DataMember(Name = "name")]
            public String name { get; set; }

            [DataMember(Name = "width")]
            public int width { get; set; }

            [DataMember(Name = "height")]
            public int height { get; set; }

            [DataMember(Name = "tiles")]
            public List<Tile> tiles { get; set; }

            public class Tile
            {
                [DataMember(Name = "x")]
                public int x { get; set; }

                [DataMember(Name = "y")]
                public int y { get; set; }

                [DataMember(Name = "url")]
                public String url { get; set; }
            }
        }
    }
}
