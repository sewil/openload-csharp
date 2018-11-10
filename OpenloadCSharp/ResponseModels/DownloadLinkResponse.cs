using OpenloadCSharp.PayloadModels;

namespace OpenloadCSharp.ResponseModels
{
    public class DownloadLinkResponse : IResponse<DownloadLinkPayload>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public DownloadLinkPayload Result { get; set; }
    }
}
