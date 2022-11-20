using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Web;

namespace WPFUIKitProfessional.Data.Classes
{
    internal class DefaultValues
    {
        public static String DefaultDay = "2012-02-12";
        public static List<String> Camera = new List<string>()
        {
            "RHAZ", "FHAZ", "MARDI", "CHEMCAM",
        };
        public static String DefaultCamera = Camera[0];


        public static List<String> language = new List<string>()
        {
            "ru", "en", "zh", "fr", "es", "ar", "aut"
        };
        public static String fromLang = language[1];
        public static String toLang = language[0];
        public static String DefaultWord = "default word";


        public static List<String> SolDate = new List<string>()
        {
            "1000", "1600", "2000", "2600", "3000"  //sol 1000=2012 1600=2017 2000=2018 2600=2019 3000=2021

        };
        public static String DefaultSol = SolDate[4];
    }
}
