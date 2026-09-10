using UnityEditor;
using UnityEditor.Rendering;
using UnityEngine;

[CustomEditor(typeof(Shape),true)] //targets abstract, true allows the targetting of inherited classes (cubes,sphere)
[CanEditMultipleObjects]
public class ShapeEditor: Editor
{
   public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI(); removing because we are doing it manually

        //variables
        serializedObject.Update();
        //size
        var size = serializedObject.FindProperty("size");
        EditorGUILayout.PropertyField(size);
        switch(target)
        {
            case Cube cube:
            if(size.floatValue < 3)EditorGUILayout.HelpBox("cube needs to be bigger than 3", MessageType.Warning);
            break;

            case Sphere sphere:
            if(size.floatValue < 4)EditorGUILayout.HelpBox("sphere needs to be bigger than 4", MessageType.Warning);
            break;
        }
        
        serializedObject.ApplyModifiedProperties();

        //Select all, undo selection
        using(new EditorGUILayout.HorizontalScope())
        {
            if(GUILayout.Button("Select All Shapes"))
            {
                
            }
            if(GUILayout.Button("Undo Selection"))
            {
                
            }
        }

        //enable/disable
        if (GUILayout.Button("Disable/Enable all shapes", GUILayout.Height(4)))
        {
            
        }


    }
}
