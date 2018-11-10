namespace OpenloadCSharp.ResponseModels
{
    public class GetSplashResponse : IResponse<string>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public string Result { get; set; }
    }
}
