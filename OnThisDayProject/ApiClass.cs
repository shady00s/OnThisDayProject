using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OnThisDayProject
{
    class ApiClass
    {
        public string getDataFromApi( int month,int day,int year)   {

            using (var client = new HttpClient())
            {
                // client.BaseAddress = new Uri("https://byabbe.se/on-this-day");
                //HTTP GET
                string data;
                try
                {
                    var request = WebRequest.Create("https://byabbe.se/on-this-day/12/2/events.json");
                    request.Method = "GET";

                    using var webResponse = request.GetResponse();
                    using var webStream = webResponse.GetResponseStream();

                    using var reader = new StreamReader(webStream);
                     data = reader.ReadToEnd();

                    return data;
                    
                }
                catch (Exception err) {

                    Console.WriteLine(err);
                    return data = "Error";
                }

            }
        }
    }
}
