using OpenloadCSharp.PayloadModels;
using System.Collections.Generic;

namespace OpenloadCSharp.ResponseModels
{
    public class CheckRemoteUploadResponse : IResponse<IDictionary<int, RemoteUploadPayload>>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public IDictionary<int, RemoteUploadPayload> Result { get; set; }
    }
}
