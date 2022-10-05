using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UIElements;

[CustomEditor(typeof(SupaComponent))]
[CanEditMultipleObjects]
public class EditorScript : Editor
{
    SerializedProperty healthEditor;
    SerializedProperty manaEditor;
    SerializedProperty nameiGuess;
    

    void OnEnable()
    {
        nameiGuess = serializedObject.FindProperty("name1");
        healthEditor = serializedObject.FindProperty("HealthValue");
        manaEditor = serializedObject.FindProperty("ManaValue");
    }

    public override void OnInspectorGUI()
    {
        
        serializedObject.Update();
        EditorGUILayout.PropertyField(nameiGuess);

        //EditorGUILayout.Slider(healthEditor, 0, 10);


        /*healthEditor.floatValue = EditorGUI.IntSlider(rectHealth, Mathf.RoundToInt(healthEditor.floatValue), 0, 10);*/

        var rectHealth = EditorGUILayout.GetControlRect();
        EditorGUILayout.PropertyField(healthEditor, new GUIContent("Health value : "));
        
        EditorGUI.ProgressBar(rectHealth, healthEditor.floatValue/10 , "health [" + ((int)healthEditor.floatValue) + "/10 ]");





        

        var rectMana = EditorGUILayout.GetControlRect(true, EditorGUIUtility.singleLineHeight);
        manaEditor.floatValue = EditorGUI.IntSlider(rectMana, Mathf.RoundToInt(manaEditor.floatValue), 0, 10);
        EditorGUI.ProgressBar(rectMana, manaEditor.floatValue / 10, "mana [" + ((int)manaEditor.floatValue) + "/10 ]");
        EditorGUILayout.Slider(manaEditor, 0, 10);

        EditorGUILayout.LabelField(nameiGuess.stringValue);
        nameiGuess.serializedObject.ApplyModifiedProperties();
        
    }


}
    
