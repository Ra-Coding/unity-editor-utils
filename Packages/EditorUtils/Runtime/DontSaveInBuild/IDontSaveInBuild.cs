using UnityEngine;

namespace RaCoding.EditorUtils
{
    public abstract class DontSaveInBuild : MonoBehaviour
    {
        protected void Reset()
        {
            hideFlags = HideFlags.DontSaveInBuild;
        }
    }
}
