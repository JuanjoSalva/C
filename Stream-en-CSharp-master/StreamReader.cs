﻿using System;
using System.IO;
using System.Text;
namespace Streams
{
    class UsingStreamReader
    {
        public void MakingStreamReader()
        {
            string sourceFilePath = @"E:\JUANJO\CURSO2020\MODULO2_CSHARP\Stream-en-CSharp-master\ficheros\settingsStreams.txt ";
            // Create a FileStream object so that you can interact with the file
            // system.
            FileStream sourceFile = new FileStream(
             sourceFilePath, // Pass in the source file path.
             FileMode.Open, // Open an existing file.
             FileAccess.Read);// Read an existing file.
            StreamReader reader = new StreamReader(sourceFile);
            StringBuilder fileContents = new StringBuilder();
            // Check to see if the end of the file
            // has been reached.
            while (reader.Peek() != -1)
            {
                // Read the next character.
                fileContents.Append((char)reader.Read());
                
            }
            
            // Store the file contents in a new string variable.
            string data = fileContents.ToString();
            Console.Write(data);
            // Always close the underlying streams release any file handles.
            reader.Close();
            sourceFile.Close();
            Console.ReadLine();
        }
        public void MakingStreamWriter()
        {
            string destinationFilePath = @"E:\JUANJO\CURSO2020\MODULO2_CSHARP\Stream-en-CSharp-master\ficheros\settingsStreams.txt ";
            string data = "Hello, this will be written in plain text";
            // Create a FileStream object so that you can interact with the file
            // system.
            FileStream destFile = new FileStream(
             destinationFilePath, // Pass in the destination path.
             FileMode.Create, // Always create new file.
             FileAccess.Write); // Only perform writing.
                                // Create a new StreamWriter object.
            StreamWriter writer = new StreamWriter(destFile);
            // Write the string to the file.
            writer.WriteLine(data);
            // Always close the underlying streams to flush the data to the file
            // and release any file handles.
            writer.Close();
            destFile.Close();
            Console.ReadLine();
        }

    }
}
