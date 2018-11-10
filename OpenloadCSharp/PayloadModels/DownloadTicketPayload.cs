namespace OpenloadCSharp.PayloadModels
{
    public struct DownloadTicketPayload
    {
        public string ticket;
        public string captcha_url;
        public int captcha_w;
        public int captcha_h;
        public int wait_time;
        public string valid_until;
    }
}
