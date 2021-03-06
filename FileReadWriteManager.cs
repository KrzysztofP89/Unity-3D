﻿using System;
using System.IO;

public class FileReadWriteManager
{
    public void WriteTextFile(string pathAndName, string stringData)
    {
        FileInfo textFile = new FileInfo(pathAndName);
        if (textFile.Exists)
            textFile.Delete();

        StreamWriter writer;
        writer = textFile.CreateText();

        writer.Write(stringData);
        writer.Close();
    }

    public string ReadTextFile(string pathAndName)
    {
        string dataAsString = "";

        try
        {
            StreamReader textReader = File.OpenText(pathAndName);

            dataAsString = textReader.ReadToEnd();

            textReader.Close();

        }
        catch (Exception e)
        {
            // Exception
        }

        return dataAsString;
    }
}