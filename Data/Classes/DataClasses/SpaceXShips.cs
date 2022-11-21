using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUIKitProfessional.Data.Classes.DataClasses
{
    public class SpaceXShips
    {
        public class Rootobject
        {
            public Root[] ShipObject { get; set; }
        }

        public class Root
        {
            public string ship_id { get; set; }
            public string ship_name { get; set; }
            public string ship_model { get; set; }
            public string ship_type { get; set; }
            public string[] roles { get; set; }
            public bool active { get; set; }
            public int? imo { get; set; }
            public int? mmsi { get; set; }
            public int? abs { get; set; }
            public int? _class { get; set; }
            public int? weight_lbs { get; set; }
            public int? weight_kg { get; set; }
            public int? year_built { get; set; }
            public string home_port { get; set; }
            public string status { get; set; }
            public object speed_kn { get; set; }
            public object course_deg { get; set; }
            public Position position { get; set; }
            public int? successful_landings { get; set; }
            public int? attempted_landings { get; set; }
            public Mission[] missions { get; set; }
            public string url { get; set; }
            public string image { get; set; }
            public int? attempted_catches { get; set; }
            public int? successful_catches { get; set; }
        }

        public class Position
        {
            public object latitude { get; set; }
            public object longitude { get; set; }
        }

        public class Mission
        {
            public string name { get; set; }
            public int flight { get; set; }
        }
    }
}
