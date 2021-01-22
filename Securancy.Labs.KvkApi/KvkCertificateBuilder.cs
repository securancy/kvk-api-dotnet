using System;
using System.Net.Http;
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Extensions.FileProviders;

namespace Securancy.Labs.KvkApi
{
    public class KvkCertificateBuilder
    {
        private const string CUSTOM_ROOT_CERTIFICATE_FILENAME = "Staat_der_Nederlanden_Private_Root_CA_-_G1.cer";
        
        /// <summary>
        /// Creates a HttpHandler that loads the (root) embedded certificate.
        /// </summary>
        /// <remarks>
        /// The included (root) certificate are in the ./Certs folder, but compiled as embedded resource.
        /// Many thanks to https://github.com/dotnet/runtime/issues/39835
        /// </remarks>
        public static HttpClientHandler CreateHttpHandler()
        {
            var handler = new HttpClientHandler();
            
            // load the custom kvk root certificate, as embedded resource
            var certificate = LoadCertFromEmbeddedResource($"Certs/{CUSTOM_ROOT_CERTIFICATE_FILENAME}");
            
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, _) => {
                chain.ChainPolicy.TrustMode = X509ChainTrustMode.CustomRootTrust;
                
                chain.ChainPolicy.CustomTrustStore.Add(certificate);
                
                // [optional] add any additional intermediate certs
                // chain.ChainPolicy.ExtraStore.Add(LoadCert(...filename...));
                
                return chain.Build(cert);
            };
            
            return handler;
        }

        private static X509Certificate2 LoadCertFromFile(string filename)
        {
            return new X509Certificate2(File.ReadAllBytes($"./Certs/{filename}"));
        }
        
        private static X509Certificate2 LoadCertFromEmbeddedResource(string filename)
        {
            var embeddedProvider = new EmbeddedFileProvider(Assembly.GetExecutingAssembly());

            var certFile = embeddedProvider.GetFileInfo(filename);
            if (!certFile.Exists) throw new Exception($"Embedded resource not found: {filename}");
            
            using (var stream = certFile.CreateReadStream())
            {
                byte[] bytes;
                using (var memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);
                    bytes = memoryStream.ToArray();
                }

                return new X509Certificate2(bytes);
            }
        }
    }
}