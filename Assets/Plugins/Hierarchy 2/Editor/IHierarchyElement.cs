using UnityEngine.UIElements;

namespace Plugins.Hierarchy_2.Editor
{
    internal interface IHierarchyElement
    {
        void Canvas(HierarchyCanvas canvas);
        VisualElement CreateCanvasElement();
    }
}


