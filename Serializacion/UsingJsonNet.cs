﻿using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace Serializable8
{
    /*SERIALIZACION CON NEWTON JSON.  SERIALIZA A MEMORIA PORQUE DEVULEVE LA SERIALIZACION A UN STRING. Y NO HACE FLATA QUE 
     NUESTRAS CLASES A SERIAIZAR IMPLEMENTEN LA INTERFACE ISERIALIZER NI NADA
     */

    /*Aquí añadimos los alias de los campos de nuestra clase, o podemos ignorar alguno*/
    public class ServiceConfigurationNewtonJson
    {
        // JsonConvert ignores private members by default
        private Guid _internalId;
        // Map the properties with json naming conventions
        [JsonProperty("configName")]
        public string ConfigName { get; set; }
        [JsonProperty("databaseHostName")]
        public string DatabaseHostName { get; set; }
        [JsonIgnore]
        public string ApplicationDataPath { get; set; }
    }

    public class UsingNewtonJson
    {
        public void MakeSerializableWithNewtonJson()
        {
            ServiceConfigurationNewtonJson config = new ServiceConfigurationNewtonJson();
            config.ApplicationDataPath = @"C:\Windows\System32";
            config.ConfigName = "NewtonJsonSerialization";
            config.DatabaseHostName = "localhost";
            var jsonString = JsonConvert.SerializeObject(config);
            Console.WriteLine(jsonString);
            File.WriteAllText(@"E:\JUANJO\CURSO2020\MODULO2_CSHARP\Serializacion\Ficheros_Serializados\Newton.json", jsonString);
            Console.ReadLine();
        }


        
        public void MakeDeSerializableWithNewtonJson()
        {
            var jsonString = File.ReadAllText(@"E:\JUANJO\CURSO2020\MODULO2_CSHARP\Serializacion\Ficheros_Serializados\Newton.json");
            var deserializedConfig = JsonConvert.DeserializeObject<ServiceConfigurationNewtonJson>(jsonString);
            ServiceConfigurationNewtonJson config = new ServiceConfigurationNewtonJson();
            Console.WriteLine(deserializedConfig.ApplicationDataPath);
            Console.WriteLine(deserializedConfig.ConfigName);
            Console.WriteLine(deserializedConfig.DatabaseHostName);
            Console.ReadLine();
        }

        /*Aquí serializamos nuestra clase a memoria, (una varibale string)., Luego lo ponemos en un fichero, pero es opcional*/
        public void MakeSerializewithJsonSerializer()
        {
            Config config = new Config();
            config.Name = "Json Serializer";
            config.Values = "One Value";
            config.Logs = new List<string> { "Reading", "Writing", "Processing" };
            // Create the serializer
            var serializer = new JsonSerializer();
            // Open the stream to the file
            var fileWriter = File.CreateText(@"E:\JUANJO\CURSO2020\MODULO2_CSHARP\Serializacion\Ficheros_Serializados\config.json");
            // Serialize and write the object to the file
            serializer.Serialize(fileWriter, config);
            // Close the stream
            fileWriter.Close();
            fileWriter.Dispose();
            Console.ReadLine();
        }

        /*Aquí deserializamos el fichero,*/
        public void MakeDeSerializewithJsonSerializer()
        {
            // Create the serializer
            var serializer = new JsonSerializer();
            // Open a stream to the file
            var fileReader = File.OpenRead(@"E:\JUANJO\CURSO2020\MODULO2_CSHARP\Serializacion\Ficheros_Serializados\config.json");
            // Create a stream and json text readers
            var textReader = new StreamReader(fileReader);
            var jsonReader = new JsonTextReader(textReader);
            // Deserialize to the desired type
            var deserializedConfig = serializer.Deserialize<Config>(jsonReader);
            Console.WriteLine(deserializedConfig.Name);
            Console.WriteLine(deserializedConfig.Name);
            foreach (var log in deserializedConfig.Logs)
            {
                Console.WriteLine(log);
            }
            // Close all the readers and the stream
            jsonReader.Close();
            textReader.Close();
            Console.ReadLine();
        }

    }
    public class Config
    {
        public string Name { get; set; }
        public string Values { get; set; }

        public List<string> Logs { get; set; }
    }
}
