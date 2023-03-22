using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

[Serializable]
public class CreateJSON : MonoBehaviour
{

    public string name;
    [SerializeField]
        private Inventory inventory;
    private string FilePath => $"{Application.persistentDataPath}/{inventory.name}.json";
   /* public static CreateJSON CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<CreateJSON>(jsonString);
    }*/


    [ContextMenu("Save")]

    public void Save()
    {
        string json = JsonUtility.ToJson(this, true);
        FileStream fileStream = new(FilePath, FileMode.Create);

        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(json);
        }
        Debug.Log(FilePath);    
    }

    [ContextMenu("Load")]

    public void Load()
    {
        if(File.Exists(FilePath))
        {
            using (StreamReader reader = new (FilePath))
            {
                string json = reader.ReadToEnd();
                JsonUtility.FromJsonOverwrite(json,this);
            }
        }
        else
        {
            Debug.LogWarning($"File{FilePath}not found");
        }
    }

}
