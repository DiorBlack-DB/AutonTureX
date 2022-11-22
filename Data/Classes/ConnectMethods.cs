using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;
using WPFUIKitProfessional.Data.Model;
using WPFUIKitProfessional.Data.DBClasses;
using System.Security.Policy;
using System.Windows.Media;
using System.Security;
using System.Windows.Input;
using System.Web;
using System.Collections;
using System.Net.Http;
using System.Web.UI;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using WPFUIKitProfessional.Data.Classes.DataClasses;
using System.Web.Script.Serialization;

namespace WPFUIKitProfessional.Data.Classes
{
    internal class ConnectMethods
    {
        public static dynamic CreateRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string sReadData = sr.ReadToEnd();
            response.Close();
            dynamic data = JsonConvert.DeserializeObject(sReadData);
            return data;
        }
        public static JObject ReadJsonFile(string url)
        {

            JObject o2;
            using (StreamReader file = File.OpenText(url))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                o2 = (JObject)JToken.ReadFrom(reader);
            }
            return o2;
        }
        public static string TranslateText(String fromLang, String toLang, String input)
        {
            DefaultValues.toLang = toLang;
            DefaultValues.fromLang = fromLang;
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             $"{DefaultValues.fromLang}", $"{DefaultValues.toLang}", Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
            var translationItems = jsonData[0];
            string translation = "";
            foreach (object item in translationItems)
            {
                IEnumerable translationLineObject = item as IEnumerable;
                IEnumerator translationLineString = translationLineObject.GetEnumerator();
                translationLineString.MoveNext();
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }

            if (translation.Length > 1) { translation = translation.Substring(1); };
            return translation;
        }
        public static dynamic SearchRequestFromWiki(string question)
        {
            string url = URLGenerator.WikiSearch + question;
            return url;
        }
        public static dynamic DayPhotoReport(dynamic data)
        {
            var photo = JsonConvert.DeserializeObject<DataClasses.ImageGetter>(data.ToString());
            return photo;
        }
        public static dynamic RoadsterX(dynamic data)
        {
            var roadster = JsonConvert.DeserializeObject<DataClasses.Roadster>(data.ToString());
            return roadster;
        }
        public static dynamic Astronaut(JObject data)
        {
            var result = JsonConvert.DeserializeObject<Astronauts.Rootobject>(data.ToString());
            return result;
        }
        public static dynamic RocketsX(dynamic data)
        {
            var rockets = JsonConvert.DeserializeObject<List<SpaceXRockets.Root>>(data.ToString());
            return rockets;
        }
        public static dynamic ShipsX(dynamic data)
        {
            var ships = JsonConvert.DeserializeObject<List<SpaceXShips.Root>>(data.ToString());
            return ships;
        }
    }
}
