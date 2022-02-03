using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using Level;

[CustomEditor(typeof(ExpansionTriangle), true)] [ExecuteInEditMode]
public class ExpansionTriangleEditor : Editor
{
    
   

    public override void OnInspectorGUI()
    {
        ExpansionTriangle _exTr = (ExpansionTriangle)target;

        LevelGame lvl = FindObjectOfType<LevelGame>();
        EnergyText energyText = FindObjectOfType<EnergyText>();
        _exTr.Active = EditorGUILayout.Toggle("Active", _exTr.Active);
        
        _exTr.triangle = (Shapes)EditorGUILayout.ObjectField(_exTr.triangle, typeof(Shapes), true);
        _exTr.textEnergy = (Text)EditorGUILayout.ObjectField(_exTr.textEnergy, typeof(Text), true);
        GameObject canvas = GameObject.Find("Canvas");
        _exTr.energy = EditorGUILayout.IntField(_exTr.energy);
        Text text = _exTr.textEnergy;
        
        if (!_exTr.Active)
        {

            if (GUILayout.Button("Добавить Треугольник"))
            {
                
                text = (Text)Instantiate(_exTr.textEnergy);
                text.transform.SetParent(canvas.transform, false);
                
                lvl.shape.Add(_exTr.triangle);

                _exTr.Active = true;
               
            }
            
        }
        if (_exTr.Active)
        {
            if (GUILayout.Button("Убрать Треугольник"))
            {

                lvl.shape.Remove(_exTr.triangle);
                _exTr.Active = false;
                GameObject.DestroyImmediate(energyText.gameObject);
            }
        }
            if (GUI.changed)
        {
            EditorUtility.SetDirty(_exTr);
            EditorSceneManager.MarkSceneDirty(_exTr.gameObject.scene);
        }
        
    }

}
