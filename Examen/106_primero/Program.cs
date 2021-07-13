using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _106
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
            Console.WriteLine("\nAn application uses X509 certificates for data encryption and decryption. The application stores certificates in\nthe Personal certificates collection of the Current User store. On each computer, each certificate subject is\nunique.\nThe application includes a method named LoadCertificate. The LoadCertificate() method includes\nthe following code. ");
            Console.WriteLine("\nX509Certificate2 LoadCertificate(string searchValue)\n{\n\t	var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);\n\t	store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);\n\t	var certs = store.Certificates.Find(\n\t\n\t	searchValue, false);\n\t	...\n}");
            Console.WriteLine("\nThe LoadCertificate() method must load only certificates for which the subject exactly matches the\nsearchValue parameter value.\nYou need to ensure that the LoadCertificate() method loads the correct certificates.\nWhich code segment should you insert at line 06?");
            Console.WriteLine("\nA. X509FindType.FindBySubjectName,\nB. X509FindType.FindBySubjectKeyIdentifier,\nC. X509FindByIssuerName,\nD. X509FindType.FindBySubjectDistinguishedName,");
            Console.WriteLine("\n\nCorrect Answer: D");
            Console.WriteLine("\nLo probamos implementando la funcion X509Certificate2 LoadCertificate(string searchValue)\ncomo se indica en ejercicio y llamándola.");

            X509Certificate2 cert = new Program().LoadCertificate("CN=CERT_SIGN_TEST_CERT");
            Console.WriteLine($"Certificate 'CN=CERT_SIGN_TEST_CERT' {((cert == null) ? "not found" : "found")}");
            if (cert != null)
            {
                Console.WriteLine($"Certificate Subject:{cert.Subject}, Certificate Thumbprint:{cert.Thumbprint}");
                Console.WriteLine($"Certificate Subject Name:{cert.SubjectName.Name}, Certificate IssuerName:{cert.IssuerName.Name}");
            }
        }

       /* X509Certificate2 LoadCertificate(string searchValue)
        {               
            var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
            var certs = store.Certificates.Find(

                //A.
                //X509FindType.FindBySubjectName,

                //B.
                //X509FindType.FindBySubjectKeyIdentifier,

                //C. Da error
                //X509FindByIssuerName,

                //D.
                X509FindType.FindBySubjectDistinguishedName,

                searchValue, false);
            
            store.Close();
            Console.WriteLine($"Numero de certificados encontrados:{certs.Count}");
            return certs.Count == 0 ? null : certs[0];
                
        }*/
        X509Certificate2 LoadCertificate(string searchValue)
        {

            //var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            var store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);

            //var certCollection = store.Certificates;
            //var currentCerts = certCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
            //var certs = currentCerts.Find(X509FindType.FindBySubjectDistinguishedName, searchValue, false);
            var certs = store.Certificates.Find(
                //A. X509FindType.FindBySubjectName,                 // Option A - Incorrect - encuentra todos los certificados CERT_SIGN_
                //B. X509FindType.FindBySubjectKeyIdentifier,        // Option B - Incorrect -  represente el identificador de clave de sujeto en formato hexadecimal, como ""
                //C. X509FindType.FindByIssuerName,                  // Option C - Incorrect Encuentra todos los certificados CERT_SIGN_
                X509FindType.FindBySubjectDistinguishedName,      // Option D - No Encuentra CERT_SIGN_, Si encuentra CN=CERT_SIGN_TEST_CERT
                searchValue, false);
            store.Close();
            Console.WriteLine($"Numero de certificados encontrados:{certs.Count}");
            //Console.WriteLine(certs[0]);
            return certs.Count == 0 ? null : certs[0];
        }

    }
}
