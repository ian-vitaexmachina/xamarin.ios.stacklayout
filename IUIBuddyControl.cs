﻿using System;
using UIKit;
using CoreGraphics;

namespace vitaexmachina.xamarin.ios.uibuddy
{
    public interface IUIBuddyControl
    {
        UIBuddyAnimateDirection AnimDirection { get; set; }
        double AnimDelay { get; set; }
        bool FadeIn { get; set; }
        UIView BuddyControl { get; set; }
        void AnimateIn(double duration = 1.0f);
        Align HorizontalAlign { get; set; }
        Align VerticalAlign { get; set; }
    }
}
