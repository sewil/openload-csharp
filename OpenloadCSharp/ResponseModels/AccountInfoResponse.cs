using OpenloadCSharp.PayloadModels;

namespace OpenloadCSharp.ResponseModels
{
    public class AccountInfoResponse : IResponse<AccountInfoPayload>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public AccountInfoPayload Result { get; set; }
    }
}
