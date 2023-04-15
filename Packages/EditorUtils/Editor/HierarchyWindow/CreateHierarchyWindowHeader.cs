using UnityEngine;
using UnityEditor;

namespace RaCoding.EditorUtils
{
    public class CreateHierarchyWindowHeader : MonoBehaviour
    {
        [MenuItem("GameObject/RaCoding/EditorUtils/HierarchyWindow/Header", false, 10)]
        static void CreateWinConditionGameObject(MenuCommand menuCommand)
        {
            GameObject gameObject = new("[HEADER] Header Title");
            // set gameobject tag to "EditorOnly"
            gameObject.tag = "EditorOnly";
            GameObjectUtility.SetParentAndAlign(gameObject, menuCommand.context as GameObject);
            Undo.RegisterCreatedObjectUndo(gameObject, "Create " + gameObject.name);
            Selection.activeObject = gameObject;
        }
    }
}
