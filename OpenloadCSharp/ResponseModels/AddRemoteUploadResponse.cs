using OpenloadCSharp.PayloadModels;

namespace OpenloadCSharp.ResponseModels
{
    public class AddRemoteUploadResponse : IResponse<AddRemoteUploadPayload>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public AddRemoteUploadPayload Result { get; set; }
    }
}
