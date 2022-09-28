using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ToolsConsols : MonoBehaviour
{
    [MenuItem("Tools/Log Console")]
    static void DoSomething()
    {
        Debug.Log("Doing Something...");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
