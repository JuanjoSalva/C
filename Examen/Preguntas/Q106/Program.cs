using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text;

namespace Q106
{
    class Program
    {
        static void Main(string[] args)
        {
            // To run this program before use on command prompt this:
            // makecert -r -pe -n "CN=CERT_SIGN_TEST_CERT" -b 01/01/2020 -e 01/01/2022 -sky exchange -ss my
            // makecert -r -pe -n "CN=CERT_SIGN_TEST2_CERT" -b 01/01/2020 -e 01/01/2022 -sky exchange -ss my
            // makecert -r -pe -n "CN=CERT_SIGN_TEST3_CERT" -b 01/01/2020 -e 01/01/2022 -sky exchange -ss my
            // Creating 3 certificates can to test better!
            X509Certificate2 cert = new Program().LoadCertificate("CN=CERT_SIGN_TEST_CERT");
            Console.WriteLine($"Certificate 'CN=CERT_SIGN_TEST_CERT' {((cert == null) ? "not found" : "found")}");
            if (cert != null)
            {
                Console.WriteLine($"Certificate Subject:{cert.Subject}, Certificate Thumbprint:{cert.Thumbprint}");
                Console.WriteLine($"Certificate Subject Name:{cert.SubjectName.Name}, Certificate IssuerName:{cert.IssuerName.Name}");
            }
        }

        X509Certificate2 LoadCertificate(string searchValue)
        {

            //var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            var store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);

            //var certCollection = store.Certificates;
            //var currentCerts = certCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
            //var certs = currentCerts.Find(X509FindType.FindBySubjectDistinguishedName, searchValue, false);
            var certs = store.Certificates.Find(
                //X509FindType.FindBySubjectName,                 // Option A - Incorrect - encuentra todos los certificados CERT_SIGN_
                //X509FindType.FindBySubjectKeyIdentifier,        // Option B - Incorrect -  represente el identificador de clave de sujeto en formato hexadecimal, como ""
                //X509FindType.FindByIssuerName,                  // Option C - Incorrect Encuentra todos los certificados CERT_SIGN_
                X509FindType.FindBySubjectDistinguishedName,      // Option D - No Encuentra CERT_SIGN_, Si encuentra CN=CERT_SIGN_TEST_CERT
                searchValue, false);
            store.Close();
            Console.WriteLine($"Numero de certificados encontrados:{certs.Count}");
            //Console.WriteLine(certs[0]);
            return certs.Count == 0 ? null : certs[0];
        }

    }
}