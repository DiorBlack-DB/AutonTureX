using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUIKitProfessional.Data.Classes.DataClasses
{
    public class Astronauts
    {
        public class Rootobject
        {
            public int count { get; set; }
            public string next { get; set; }
            public object previous { get; set; }
            public Result[] results { get; set; }
        }

        public class Result
        {
            public int id { get; set; }
            public string url { get; set; }
            public string name { get; set; }
            public Status status { get; set; }
            public Type type { get; set; }
            public int? age { get; set; }
            public string date_of_birth { get; set; }
            public string date_of_death { get; set; }
            public string nationality { get; set; }
            public string bio { get; set; }
            public string twitter { get; set; }
            public string instagram { get; set; }
            public string wiki { get; set; }
            public Agency agency { get; set; }
            public string profile_image { get; set; }
            public string profile_image_thumbnail { get; set; }
            public int flights_count { get; set; }
            public int landings_count { get; set; }
            public DateTime? last_flight { get; set; }
            public DateTime? first_flight { get; set; }
        }

        public class Status
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Type
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Agency
        {
            public int id { get; set; }
            public string url { get; set; }
            public string name { get; set; }
            public bool featured { get; set; }
            public string type { get; set; }
            public string country_code { get; set; }
            public string abbrev { get; set; }
            public string description { get; set; }
            public string administrator { get; set; }
            public string founding_year { get; set; }
            public string launchers { get; set; }
            public string spacecraft { get; set; }
            public object parent { get; set; }
            public string image_url { get; set; }
        }
    }
}
