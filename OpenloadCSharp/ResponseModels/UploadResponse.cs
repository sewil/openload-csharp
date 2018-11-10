using OpenloadCSharp.PayloadModels;

namespace OpenloadCSharp.ResponseModels
{
    public class UploadResponse : IResponse<UploadPayload>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public UploadPayload Result { get; set; }
    }
}
