using OpenloadCSharp.PayloadModels;

namespace OpenloadCSharp.ResponseModels
{
    public class DownloadTicketResponse : IResponse<DownloadTicketPayload>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public DownloadTicketPayload Result { get; set; }
    }
}
