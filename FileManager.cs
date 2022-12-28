using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileManager : MonoBehaviour
{
    private string path;
    private string content;
    private int number;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

    private void Write()
    {
        path = Application.dataPath + "/File.txt";
        if (!File.Exists(path)) 
        {
            File.WriteAllText(path, "Begin of the file \n");
        }
        content = "new element number \n";
        File.AppendAllText(path, content);
        content = number + "\n";
        File.AppendAllText(path, content);
        number++;
    }

    private void Read() 
    {
        path = Application.dataPath + "/File.txt";
        foreach (string line in File.ReadLines(path))
        {
            Debug.Log(line);
        }
    }
}
