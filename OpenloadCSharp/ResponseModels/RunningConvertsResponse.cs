using OpenloadCSharp.PayloadModels;

namespace OpenloadCSharp.ResponseModels
{
    public class RunningConvertsResponse : IResponse<RunningConvertsPayload>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public RunningConvertsPayload Result { get; set; }
    }
}
