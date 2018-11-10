using OpenloadCSharp.PayloadModels;
using System.Collections.Generic;

namespace OpenloadCSharp.ResponseModels
{
    public class FileInfoResponse : IResponse<IDictionary<string, FileInfoFile>>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public IDictionary<string, FileInfoFile> Result { get; set; }
    }
}
