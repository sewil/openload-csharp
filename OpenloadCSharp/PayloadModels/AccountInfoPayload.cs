namespace OpenloadCSharp.PayloadModels
{
    public struct AccountInfoPayload
    {
        public string extid;
        public string email;
        public string signup_at;
        public int storage_left;
        public string storage_used;
        public Traffic traffic;
        public double balance;
    }
}
