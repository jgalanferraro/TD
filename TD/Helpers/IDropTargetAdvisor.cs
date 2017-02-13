﻿using Windows.UI.Xaml;

namespace TD.Helpers
{
    internal interface IDropTargetAdvisor
    {
        UIElement TargetUI { get; set; }
        bool ApplyMouseOffset { get; }
        bool IsValidDataObject(IDataObject obj);
        void OnDropCompleted(IDataObject obj, Point dropPoint);
        UIElement GetVisualFeedback(IDataObject obj);
        UIElement GetTopContainer();
    }
}