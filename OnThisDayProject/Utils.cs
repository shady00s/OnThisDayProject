using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThisDayProject
{

    // this class contains all of the utilities functions that will be used in the program
    class Utils
    {
        // to test if the string contains any letter of symbol


        public static JObject StringToJson(string FromApi) {

            JObject test = JObject.Parse(FromApi);
            return test;
        }
        public static void  FileCreator(string name, JObject content) {
            try
            {
                FileStream fs = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(content);
            }
            catch (Exception err)
            {

            }
        }
        public static void JSONCreator() { 
            
        
        }
        // to check if the api is working or there is error 
        public static void ApiDataChecker(string valueFromApi) {
            if (valueFromApi == "Error")
            {
                Console.WriteLine("Cant connect to the server .");
            }
            else {
                Console.WriteLine(valueFromApi);
            }
        }
    }
}
