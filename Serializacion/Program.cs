using System;
using System.Configuration;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;


namespace Serializador
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            BINARIO             
            new Program().MakeBinarySerializable();
                new Program().MakeBinaryDesSerializable();*/

            //XML
            //new Program().MakeXMLSerializable();
            //new Program().MakeXMLDesSerializable();

            //JSON
            //new Program().MakeJSONSerializable();
            new Program().MakeJSONDesSerializable();

        }

        /*BINARIO*/
        /*Esta clase sirve para serializar en un fichero con datos binario los datos de un objeto de nuestra aplicacion  */
        public void MakeBinarySerializable()
        {
            TipoSerializable tiposer = new TipoSerializable();
            tiposer.ApplicationDataPath = @"d:\";
            tiposer.ConfigName = "BinaryFormat";
            tiposer.DatabaseHostName = "localhost";

            IFormatter formater = new BinaryFormatter();
            FileStream stream = File.Create(@"E:\JUANJO\CURSO2020\MODULO2_CSHARP\Serializacion\Ficheros_Serializados\binario.txt");
            formater.Serialize(stream, tiposer);
            stream.Close();
        }


        /*Esta clase sirve para desserializar los datos de un fichero con datos en binario a un objeto en nuestra aplicacion */
        public void MakeBinaryDesSerializable() {
            IFormatter formater = new BinaryFormatter();
            FileStream stream = File.OpenRead(@"E:\JUANJO\CURSO2020\MODULO2_CSHARP\Serializacion\Ficheros_Serializados\binario.txt");
            TipoSerializable tiposer = (TipoSerializable) formater.Deserialize(stream);
            Console.WriteLine($" {tiposer.ConfigName}    {tiposer.ApplicationDataPath}    {tiposer.DatabaseHostName}  ");
            stream.Close();
        }

        /*XML*/
        /*Esta clase sirve para serializar en un fichero con datos xml los datos de un objeto de nuestra aplicacion */
        public void MakeXMLSerializable()
        {
            TipoSerializable tiposer = new TipoSerializable();
            tiposer.ApplicationDataPath = @"d:\";
            tiposer.ConfigName = "XML Format";
            tiposer.DatabaseHostName = "localhost";

            IFormatter formater = new SoapFormatter();
            FileStream stream = File.Create(@"E:\JUANJO\CURSO2020\MODULO2_CSHARP\Serializacion\Ficheros_Serializados\serializado_xml.xml");
            formater.Serialize(stream, tiposer);
            Console.WriteLine($" {tiposer.ConfigName}    {tiposer.ApplicationDataPath}    {tiposer.DatabaseHostName}  ");
            stream.Close();
        }


        /*Esta clase sirve para desserializar los datos de un fichero con datos en xml a un objeto en nuestra aplicacion */
        public void MakeXMLDesSerializable()
        {
            IFormatter formater = new SoapFormatter();
            FileStream stream = File.OpenRead(@"E:\JUANJO\CURSO2020\MODULO2_CSHARP\Serializacion\Ficheros_Serializados\serializado_xml.xml");
            TipoSerializable tiposer = (TipoSerializable)formater.Deserialize(stream);
            Console.WriteLine($" {tiposer.ConfigName}    {tiposer.ApplicationDataPath}    {tiposer.DatabaseHostName}  ");
            Console.ReadLine();
            stream.Close();
        }


        /*JSON*/
        /*Esta clase sirve para serializar en un fichero con datos json los datos de un objeto de nuestra aplicacion */
        public void MakeJSONSerializable()
        {
            TipoSerializable tiposer = new TipoSerializable();
            tiposer.ApplicationDataPath = @"d:\";
            tiposer.ConfigName = "XML Format";
            tiposer.DatabaseHostName = "localhost";

            DataContractJsonSerializer jsonSerializer= new DataContractJsonSerializer(tiposer.GetType());
            FileStream stream = File.Create(@"E:\JUANJO\CURSO2020\MODULO2_CSHARP\Serializacion\Ficheros_Serializados\serializado_json.json");
            jsonSerializer.WriteObject(stream, tiposer);
            stream.Close();
        }


        /*Esta clase sirve para desserializar los datos de un fichero con datos en JSON a un objeto en nuestra aplicacion */
        public void MakeJSONDesSerializable()
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(TipoSerializable));
            FileStream stream = File.OpenRead(@"E:\JUANJO\CURSO2020\MODULO2_CSHARP\Serializacion\Ficheros_Serializados\serializado_json.json");
            TipoSerializable tiposer = (TipoSerializable)jsonSerializer.ReadObject(stream);
            Console.WriteLine($" {tiposer.ConfigName}    {tiposer.ApplicationDataPath}    {tiposer.DatabaseHostName}  ");
            Console.ReadLine();
            stream.Close();
        }



        /*JSON*/
    }




    [Serializable]
    public class TipoSerializable : ISerializable
    {
        [NonSerialized]
        private Guid _internalId;
      
        public string ConfigName { get; set; }
        public string DatabaseHostName { get; set; }
        public string ApplicationDataPath { get; set; }


        public TipoSerializable()
        {
        }

        public TipoSerializable(SerializationInfo info, StreamingContext ctxt)
        {
            _internalId =  Guid.NewGuid();
            this.ConfigName
           = info.GetValue("ConfigName", typeof(string)).ToString();
            this.DatabaseHostName
           = info.GetValue("DatabaseHostName", typeof(string)).ToString();
            this.ApplicationDataPath
               = info.GetValue("ApplicationDataPath", typeof(string)).ToString();
        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
          
            info.AddValue("ConfigName", this.ConfigName);
            info.AddValue("DatabaseHostName", this.DatabaseHostName);
            info.AddValue("ApplicationDataPath", this.ApplicationDataPath);
        }
    }
}
