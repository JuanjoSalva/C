using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _281
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 281\nHOTSPOT\nYou are evaluating the following C# method.");
            Console.WriteLine("\nstatic void ProtecData(byte[] messageBytes, RSAParameters RSAKeys)\n{\n\t	RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();\n\t	RSA.ImportParameters(RSAKeys);\n\t	RSAPKC1SignatureFormatte RSAFormatter = new RSAPKC1SignatureFormatte(RSA);\n\t	RSAFormatter.SetHashAlgorithm('SHA1');\n\t	byte[] ProtectValue = RSAFormatter.CreateSignature(messageBytes);\n\t	SendDataToReceiver(ProtectedValue);\n}");
            Console.WriteLine("\nThe receiver of the data has a copy of the public key.\nFor each of the following statements, select Yes if the statement is true. Otherwise, select No.\nNOTE: Each correct selection is worth one point.\nCorrect Answer:");
            Console.WriteLine("\n\nA third-party can alter the message in transit without the knowledge of the receiver\n\tFalse\n\nThe receiver can validate the identity of the sender\n\tTrue\n\nThe receiver can view the original data that passed into the messageBytes variable after the SendDataToReceiver\nmethod is called\n\tTrue");

            new Program().DoWork();


        }

        public void DoWork()
        {
            //The hash to sign.
            byte[] hash;
            using SHA1 sha1 = SHA1.Create();  // <-- La pregunta usa SHA1
            byte[] data = new byte[] { 59, 4, 248, 102, 77, 97, 142, 201, 210, 12, 224, 93, 25, 41, 100, 197, 213, 134, 130, 135 };
            hash = sha1.ComputeHash(data);

            Console.WriteLine($"Este es el valor de Data: {Convert.ToBase64String(data)}");


            RSAParameters RSAKeys = new RSAParameters();
            RSACryptoServiceProvider RSA2 = new RSACryptoServiceProvider();
                        
            RSAKeys = RSA2.ExportParameters(true);  // <-- TRUE
            Console.WriteLine($" aquí estamos en el Main antes: {Convert.ToBase64String(hash)}");

            ProtecData(hash, RSAKeys);
            Console.WriteLine($" aquí estamos en el Main después: {Convert.ToBase64String(hash)}");
            

        }


        public static void ProtecData(byte[] messageBytes, RSAParameters RSAKeys)
        {


            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(RSAKeys);
            RSAPKCS1SignatureFormatter RSAFormatter = new RSAPKCS1SignatureFormatter(RSA);
            RSAFormatter.SetHashAlgorithm("SHA1");
            Console.WriteLine($" antes  pìntampos messageBytes:{Convert.ToBase64String(messageBytes)}");
            byte[] ProtectValue = RSAFormatter.CreateSignature(messageBytes);            
            Console.WriteLine(new string('-', 80));
            Console.WriteLine(Convert.ToBase64String(ProtectValue));
            SendDataToReceiver(ProtectValue); // AQUI ACABA LA PREGUNTA ---->
            Console.WriteLine($"despues aquí pìntampos messageBytes:{Convert.ToBase64String(messageBytes)}");

            Console.WriteLine($"ProtectValue: {Convert.ToBase64String(ProtectValue)}");

            byte valor = ProtectValue[0];
            ProtectValue[0] = 56;
            RSAPKCS1SignatureDeformatter RSADeformatter = new RSAPKCS1SignatureDeformatter(RSA);
            RSADeformatter.SetHashAlgorithm("SHA1");
            
            if (RSADeformatter.VerifySignature(messageBytes, ProtectValue))
                Console.WriteLine("The signature was verified");
            else
                Console.WriteLine("The signature was not verified");
            ProtectValue[0] = valor;


            //Proccess to verifySignature with RSA and signature 'ProtectValue' to test
            //the receiver can view the original data passed into the messageByte variable after the 
            //SendDataToReceiver method is called
            //RSAPKCS1SignatureDeformatter RSADeformatter = new RSAPKCS1SignatureDeformatter(RSA);
            //RSADeformatter.SetHashAlgorithm("SHA1");

            if (RSADeformatter.VerifySignature(messageBytes, ProtectValue))
                Console.WriteLine("The signature was verified");
            else
                Console.WriteLine("The signature was not verified");
        }

        private static void SendDataToReceiver(byte[] protectedValue)
        {
            Console.WriteLine($"Resulatdo = {Convert.ToBase64String(protectedValue)}");
        }
    }
}
