using UnityEngine;
using UnityEditor;

namespace RaCoding.EditorUtils
{
    [InitializeOnLoad]
    public static class HierarchyWindowHeader
    {
        // used to identify HierarchyWindowHeader
        public const string GameObjectNameSuffix = "---";

        static HierarchyWindowHeader()
        {
            EditorApplication.hierarchyWindowItemOnGUI += HierarchyWindowItemOnGUI;
        }

        static void HierarchyWindowItemOnGUI(int instanceID, Rect selectionRect)
        {
            GameObject gameObject = EditorUtility.InstanceIDToObject(instanceID) as GameObject;

            if (gameObject != null && gameObject.name.StartsWith("---", System.StringComparison.Ordinal))
            {
                EditorGUI.DrawRect(selectionRect, Color.gray);
                EditorGUI.DropShadowLabel(selectionRect, gameObject.name.Replace("-", "").ToUpperInvariant());
            }
        }
    }
}
