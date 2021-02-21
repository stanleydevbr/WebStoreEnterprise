using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace WSE.Pagamentos.WebPag
{
    public class CardHash
    {
        public CardHash(WebPagService webPagService)
        {
            WebPagService = webPagService;
        }

        private readonly WebPagService WebPagService;

        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string CardExpirationDate { get; set; }
        public string CardCvv { get; set; }

        public string Generate()
        {
            using var aesAlg = Aes.Create();

            aesAlg.IV = Encoding.Default.GetBytes(WebPagService.EncryptionKey);
            aesAlg.Key = Encoding.Default.GetBytes(WebPagService.ApiKey);

            var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using var msEncrypt = new MemoryStream();
            using var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);

            using (var swEncrypt = new StreamWriter(csEncrypt))
            {
                swEncrypt.Write(CardHolderName + CardNumber + CardExpirationDate + CardCvv);
            }

            return Encoding.ASCII.GetString(msEncrypt.ToArray());
        }
    }
}
