using UnityEngine.UIElements;

namespace Plugins.Hierarchy_2.Editor
{
    internal interface IHierarchyShelf
    {
        void Canvas(HierarchyCanvas canvas);
        int ShelfPriority();
        VisualElement CreateShelfElement();
    }
}