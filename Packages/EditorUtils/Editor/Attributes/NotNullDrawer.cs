using UnityEditor;
using UnityEngine;

namespace RaCoding.EditorUtils
{
    [CustomPropertyDrawer(typeof(NotNullAttribute))]
    public class NotNullDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            // check if property is null
            if (property.objectReferenceValue == null) 
            {
                //Logger.Error(property.name + " can't be null (" + property.serializedObject.targetObject + ")");
                label.text = "[!] " + label.text;
                GUI.color = Color.red;
            }

            EditorGUI.PropertyField(position, property, label);

            EditorGUI.EndProperty();
        }
    }
}
