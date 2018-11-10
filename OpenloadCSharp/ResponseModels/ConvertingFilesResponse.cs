namespace OpenloadCSharp.ResponseModels
{
    public class ConvertingFilesResponse : IResponse<bool>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public bool Result { get; set; }
    }
}
