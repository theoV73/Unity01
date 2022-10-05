using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ToolsConsols : MonoBehaviour
{
    [MenuItem("bite/oui/non")]
    [MenuItem("bite/oui/oui")]
    [MenuItem("Tools/Log Console")]
    static void LogConsole()
    {

        Debug.Log("OUI baguette");
    }
    [MenuItem("Tools/Log Selected GameObject Name")]
    static void LogSelectedGameObjectName()
    {

        Debug.Log("Selected GameObject is on " + Selection.activeGameObject + ".");
    }
    [MenuItem("Tools/Log Selected GameObject Name", true)]
    static bool ValidSelectedGameObjectName()
    {

        return Selection.activeGameObject != null;
    }
    
}
