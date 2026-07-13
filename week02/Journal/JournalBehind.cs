using System;
using System.Collections.Generic;
// ie journal behind the scenes... more aptly called manifests, but i might add some more functionaliyu
class JournalBehind
{
    static ReadExtFiles reader = new ReadExtFiles();
    static WriteFiles writer = new WriteFiles();
    static string defaultManifestName = "manifest.txt";

    public void ManifestWriter(List<string> manifestData, string manifestName)
    {
        writer.WriteFile(manifestName,manifestData);
    }

    public void ManifestWriter(string[] manifestData, string manifestName)
    {
        writer.WriteFile(manifestName,manifestData);
    }

    public void ManifestWriter(List<string> manifestData)
    {
        writer.WriteFile(defaultManifestName,manifestData);
    }

    public void ManifestWriter(string[] manifestData)
    {
        writer.WriteFile(defaultManifestName, manifestData);
    }

    public List<string> ManifestAdder(List<string> manifestList, string newFile)
    {
        DateTime nuh = DateTime.Now;
        string tdd = nuh.ToShortDateString();
        string tdt = nuh.ToShortTimeString();
        string toad = $"{newFile}|||{tdd}|||{tdt}";
        manifestList.Add(toad);
        return manifestList;
    }

    public List<string> ManifestAdder(string newFile)
    {
        List<string> newMan = new List<string>();
        return ManifestAdder(newMan,newFile);
    }

    public List<List<string>> ManifestReader(string manifestName)
    {
        string[] file = reader.OpenRaw(manifestName);
        List<List<string>> mafio = new List<List<string>>(); //idk how this works... but it looks like it works?
        foreach (string i in file)
        {
            List<string> iq = new List<string>();
            string[] barts = i.Split("|||");
            iq.Add(barts[0]);
            iq.Add(barts[1]);
            iq.Add(barts[2]);
            mafio.Add(iq);
        }
        return mafio;
    }

    public List<List<string>> ManifestReader()
    {
        return ManifestReader(defaultManifestName);
    }

    public void ManifestWriter(List<List<string>> rawManifestData, string manifestName)
    {
        List<string> reconquista = new List<string>();
        foreach (List<string> i in rawManifestData)
        {
            string iq = $"{i[0]}|||{i[1]}|||{i[2]}";
            reconquista.Add(iq);
        }
        ManifestWriter(reconquista,manifestName);
    }

    public void ManifestWriter(List<List<string>> rawManifestData)
    {
        ManifestWriter(rawManifestData,defaultManifestName);
    }
}