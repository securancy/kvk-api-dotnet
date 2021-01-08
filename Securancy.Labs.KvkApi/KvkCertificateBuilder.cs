using System.Net.Http;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Securancy.Labs.KvkApi
{
    public class KvkCertificateBuilder
    {
        private const string CUSTOM_ROOT_CERTIFICATE_FILENAME = "Staat_der_Nederlanden_Private_Root_CA_-_G1.cer";
        
        /// <summary>
        /// Creates a HttpHandler that loads the (root) certificate from ./Certs folder. 
        /// </summary>
        /// <remarks>
        /// Many thanks to https://github.com/dotnet/runtime/issues/39835
        /// </remarks>
        public static HttpClientHandler CreateHttpHandler()
        {
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, _) => {
                chain.ChainPolicy.TrustMode = X509ChainTrustMode.CustomRootTrust;
                
                // add a custom root, add as many roots as you need
                chain.ChainPolicy.CustomTrustStore.Add(LoadCert(CUSTOM_ROOT_CERTIFICATE_FILENAME));
                
                // [optional] add any additional intermediate certs
                // chain.ChainPolicy.ExtraStore.Add(LoadCert(...filename...));
                
                return chain.Build(cert);
            };
            
            return handler;
        }

        private static X509Certificate2 LoadCert(string filename)
        {
            return new X509Certificate2(File.ReadAllBytes($"./Certs/{filename}"));
        }
    }
}