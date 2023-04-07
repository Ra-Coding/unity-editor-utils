using UnityEngine;

namespace RaCoding.EditorUtils
{
    public class EditorDescripton : DontSaveInBuild
    {
        [SerializeField, TextArea] private string description;
        public string Description { get => description; set => description = value; }
    }
}
