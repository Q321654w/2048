using Plugins.Hierarchy_2.Runtime;
using UnityEditor;
using UnityEngine;

namespace Plugins.Hierarchy_2.Editor
{
    [CustomEditor(typeof(HierarchyLocalData))]
    public class HierarchyLocalDataEditor : UnityEditor.Editor
    {
        private HierarchyLocalData hld;
        
        private void OnEnable()
        {
            hld = target as HierarchyLocalData;
        }

        public override void OnInspectorGUI()
        {
            if (!hld.gameObject.CompareTag("EditorOnly"))
                hld.gameObject.tag = "EditorOnly";
            
            EditorGUILayout.HelpBox("Holding reference custom data of row item on hierarchy\nExclude in build.", MessageType.Info);
            EditorGUILayout.BeginVertical("box");
            base.OnInspectorGUI();
            EditorGUILayout.EndVertical();

            if (GUILayout.Button("Refresh Manually"))
            {
                hld.ClearNullRef();
                hld.ConvertToDic();
            }
            
            if (GUILayout.Button("ClearNullRef"))
            {
                hld.ClearNullRef();
            }
        }
    }
}

