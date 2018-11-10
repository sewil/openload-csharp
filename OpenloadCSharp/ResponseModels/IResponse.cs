using Newtonsoft.Json;

namespace OpenloadCSharp.ResponseModels
{
    public interface IResponse<TResult>
    {
        [JsonProperty(PropertyName = "status")]
        int Status { get; set; }

        [JsonProperty(PropertyName = "msg")]
        string Message { get; set; }

        [JsonProperty(PropertyName = "result")]
        TResult Result { get; set; }
    }
}
