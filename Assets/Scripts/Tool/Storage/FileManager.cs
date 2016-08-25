using UnityEngine;
using System.Collections;
using System.IO;

public class FileManager : MonoBehaviour {


    public string getdata(string filen)
    {
        if (File.Exists(filen + ".txt"))
        {
            string lol = "";
            StreamReader file = new StreamReader(filen + ".txt");
            lol = file.ReadToEnd();
            file.Close();
            return lol;
        }
        else
        {
            return null;
        }
    }

    public void writedata(string filen, string txt)
    {
        if (File.Exists(filen + ".txt"))
        {
            string lol = "";
            StreamWriter file = new StreamWriter(filen + ".txt");
            file.Write(txt);
            file.Close();
        }
        else
        {
            
        }
    }
}
