using System;
using System.Security.Cryptography;
using static System.Console;
namespace Q281
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().DoWork();
        }
        public void DoWork()
        {
            //The hash to sign.
            byte[] hash;
            using SHA1 sha1 = SHA1.Create(); // <-- La pregunta usa SHA1
            byte[] data = new byte[] { 59, 4, 248, 102, 77, 97, 142, 201, 210, 12, 224, 93, 25, 41, 100, 197, 213, 134, 130, 135 };
            hash = sha1.ComputeHash(data);
            RSAParameters RSAKeys = new RSAParameters();
            RSACryptoServiceProvider RSA2 = new RSACryptoServiceProvider();
            RSAKeys = RSA2.ExportParameters(true);  // <-- TRUE
            ProtecData(hash, RSAKeys);

        }
        public static void ProtecData(byte[] messageBytes, RSAParameters RSAKeys)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(RSAKeys);
            RSAPKCS1SignatureFormatter RSAFormatter = new RSAPKCS1SignatureFormatter(RSA);
            RSAFormatter.SetHashAlgorithm("SHA1");
            byte[] ProtectValue = RSAFormatter.CreateSignature(messageBytes);
            WriteLine(new string('-', 80));
            WriteLine(Convert.ToBase64String(ProtectValue));
            SendDataToReceiver(ProtectValue); // AQUI ACABA LA PREGUNTA ---->

            //Proccess to verifySignature with RSA and signature 'ProtectValue' to test
            //the receiver can view the original data passed into the messageByte variable after the 
            //SendDataToReceiver method is called
            RSAPKCS1SignatureDeformatter RSADeformatter = new RSAPKCS1SignatureDeformatter(RSA);
            RSADeformatter.SetHashAlgorithm("SHA1");

            if (RSADeformatter.VerifySignature(messageBytes, ProtectValue))
                WriteLine("The signature was verified");
            else
                WriteLine("The signature was not verified");
        }

        private static void SendDataToReceiver(byte[] protectedValue)
        {
            WriteLine($"Resulatdo = {Convert.ToBase64String(protectedValue)}");
        }
    }
}

