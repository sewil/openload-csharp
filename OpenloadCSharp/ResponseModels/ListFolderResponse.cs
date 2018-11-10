using OpenloadCSharp.PayloadModels;

namespace OpenloadCSharp.ResponseModels
{
    public class ListFolderResponse : IResponse<ListFolderPayload>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public ListFolderPayload Result { get; set; }
    }
}
