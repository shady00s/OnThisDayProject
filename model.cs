// Root myDeserializedClass = JsonConvert.DeserializeObject<Result>(myJsonResponse);




public class Result
{
    public string? wikipedia { get; set; }
    public string? date { get; set; }
    public List<Event>? deaths { get; set; }
     public List<Event>? births { get; set; }
          public List<Event>? events { get; set; }


}



public class Event
{
    public string? year { get; set; }
    public string? description { get; set; }
    public List<Wikipedia>? wikipedia { get; set; }
}

public class Wikipedia
{
    public string? title { get; set; }
    public string? wikipedia { get; set; }
}