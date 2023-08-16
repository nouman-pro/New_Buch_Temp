using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace PRJ.Utility.OutputData;

[JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
public class OutputDTO<T>
{
    public bool Succeeded { get; set; } = true;
    public int HttpStatusCode { get; set; } = 200;
    public string Message { get; set; } 
    public T Data { get; set; }
    public long TotalData { get; set; }

}
