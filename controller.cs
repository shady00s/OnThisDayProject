
using Newtonsoft.Json;

enum events
{
    events = 1,
    deaths = 2,
    births = 3
}

class GetApiController
{
    public Result getApiData(CalenderObject calender, int eventType)
    {

        HttpClient client = new HttpClient();
        events eventVal = (events)eventType;

        String uri = $"https://byabbe.se/on-this-day/{calender.month}/{calender.day}/{eventVal}.json";
      
        String data = client.GetStringAsync(uri).Result;

     
            Result? resultData = JsonConvert.DeserializeObject<Result>(data);
             Console.WriteLine(resultData!);
            return resultData!;
         
       
    }

}


//     public BirthResult getBirthApiData(CalenderObject calender, int eventType)
//     {

//         HttpClient client = new HttpClient();
//         events eventVal = (events)eventType;
//         Console.WriteLine(eventVal);
//         String uri = $"https://byabbe.se/on-this-day/{calender.month}/{calender.day}/{eventVal}.json";
//         Console.WriteLine(uri);
//         String data = client.GetStringAsync(uri).Result;

//         BirthResult? resultData = JsonConvert.DeserializeObject<BirthResult>(data);
//         Console.WriteLine(resultData!);
//         return resultData!;
//     }
//    public EventResult getEventApiData(CalenderObject calender, int eventType)
 //   {

    //     HttpClient client = new HttpClient();
    //     events eventVal = (events)eventType;
    //     Console.WriteLine(eventVal);
    //     String uri = $"https://byabbe.se/on-this-day/{calender.month}/{calender.day}/{eventVal}.json";
    //     Console.WriteLine(uri);
    //     String data = client.GetStringAsync(uri).Result;

    //     EventResult? resultData = JsonConvert.DeserializeObject<EventResult>(data);
    //     Console.WriteLine(resultData!);
    //     return resultData!;
    // }





