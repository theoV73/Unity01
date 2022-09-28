using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(FindName))]
[CanEditMultipleObjects]
public class EditorScript : Editor
{
    
    SerializedProperty nameiGuess;

    void OnEnable()
    {
       nameiGuess = serializedObject.FindProperty("name1");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.PropertyField(nameiGuess);
        serializedObject.ApplyModifiedProperties();
        // nameiGuess.serializedObject.ApplyModifiedProperties();
        EditorGUILayout.LabelField(nameiGuess.stringValue);
    }
}
    
