﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Web;

namespace WPFUIKitProfessional.Data.Classes
{
    internal class URLGenerator
    {
        public static String ImageUrl = "https://api.nasa.gov/planetary/apod?api_key=" + APIKEY.NASAKEY + "&date=";
        public static String Translate = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={DefaultValues.fromLang}&tl={DefaultValues.toLang}&dt=t&q={HttpUtility.UrlEncode(DefaultValues.DefaultWord)}";
        public static String SpaceXAllRocket = "https://api.spacexdata.com/v3/rockets/";
        public static String SpaceXAllShips = "https://api.spacexdata.com/v3/ships/";
        public static String MarsRoverAllPhoto = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?sol=" + DefaultValues.DefaultSol + "&api_key=" + APIKEY.NASAKEY;
        public static String MarsRoverSortPhoto = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?earth_date=" + DefaultValues.DefaultDay + "&camera=" + DefaultValues.DefaultCamera + "&api_key=" + APIKEY.NASAKEY;
        public static String RoadsterX = "https://api.spacexdata.com/v3/roadster";
        public static String DefaultWikiSearch = "https://en.wikipedia.org/wiki/" + DefaultValues.DefaultSearchFromWiki;
        public static String WikiSearch = "https://en.wikipedia.org/wiki/";
        public static String SpaceDevs = "https://thespacedevs.com/llapi";
        public static String local = "https://localhost:7208/WebApplication";
        public static String TraceShips = "https://www.marinetraffic.com/en/ais/home/" + DefaultValues.DefaultidShip + "/zoom:13";
        public static String Visual = "https://images.nasa.gov/details-ART-DL-1_2022_325_1209_SHARED_art001m1013251209";
        public static String VisualOne = "https://images-assets.nasa.gov/video/Artemis%20I%20Launch%202022%20CU%20tracking%20from%20Press%20Site_compressed/Artemis%20I%20Launch%202022%20CU%20tracking%20from%20Press%20Site_compressed~orig.mp4";
        public static String VisualTwo = "https://api.nasa.gov/mars-wmts/catalog/ESP_040776_2115_RED_A_01_ORTHO.html";
        public static String VisualThree = "https://worldview.earthdata.nasa.gov/?v=-54.28877666017556,-16.281479651780522,216.71571437825096,122.46589681387479&l=Reference_Labels_15m(hidden),Reference_Features_15m(hidden),Coastlines_15m,VIIRS_SNPP_DayNightBand_At_Sensor_Radiance,VIIRS_SNPP_DayNightBand_AtSensor_M15(hidden),VIIRS_SNPP_CorrectedReflectance_TrueColor(hidden)&lg=true&tr=black_marble_night_lights&t=2022-04-06-T00%3A00%3A00Z";

    }
}
