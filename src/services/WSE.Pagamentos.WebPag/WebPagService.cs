namespace WSE.Pagamentos.WebPag
{
    public class WebPagService
    {
        public readonly string ApiKey;
        public readonly string EncryptionKey;

        public WebPagService(string apiKey, string encryptionKey)
        {
            ApiKey = apiKey;
            EncryptionKey = encryptionKey;
        }
    }
}
