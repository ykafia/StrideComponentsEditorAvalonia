﻿namespace Stride.Editor.Design.SceneEditor
{
    public class FolderViewModel : HierarchyItemViewModel
    {
        public FolderViewModel(string name)
        {
            Name = name;
            IsFolder = true;
        }
    }
}
