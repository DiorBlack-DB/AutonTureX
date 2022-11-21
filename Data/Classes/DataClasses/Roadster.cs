using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUIKitProfessional.Data.Classes.DataClasses
{
    internal class Roadster
    {
        public string name { get; set; }
        public DateTime launch_date_utc { get; set; } 
        public int launch_date_unix { get; set; }
        public int launch_mass_kg { get; set; }
        public double period_days { get; set; }
        public double mars_distance_km { get; set; }
        public string video { get; set; }
        public string orbit_type { get; set; }
        public string details { get; set; }
        public string longitude { get; set; }
        public double periapsis_au { get; set; }
        public double speed_kph { get; set; }
        public double earth_distance_km { get; set; } 
        public List<string> flickr_images { get; set; }
        public string wikipedia { get; set; }
    }
}
