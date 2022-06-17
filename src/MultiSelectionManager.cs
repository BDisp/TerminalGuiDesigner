﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Gui;
using Attribute = Terminal.Gui.Attribute;

namespace TerminalGuiDesigner;

/// <summary>
/// Handles tracking and building commands for when multiple
/// <see cref="View"/> are selected at once within
/// the editor
/// </summary>
public class MultiSelectionManager
{
    List<View> selection = new();

    Dictionary<View, ColorScheme> oldSchemes = new();
    
    /// <summary>
    /// The color scheme to assign to controls that have been 
    /// multi selected
    /// </summary>
    public ColorScheme SelectedScheme { get; private set; }

    public MultiSelectionManager()
    {
        SelectedScheme = new ColorScheme()
        {
            Normal = new Attribute(Color.BrightGreen, Color.Green),
            Focus = new Attribute(Color.BrightGreen, Color.Green),
            Disabled = new Attribute(Color.BrightGreen, Color.Green),
            HotFocus = new Attribute(Color.BrightGreen, Color.Green),
            HotNormal = new Attribute(Color.BrightGreen, Color.Green),
        };
    }

    public void SetSelection(params View[] views)
    {
        // reset anything that was previously selected
        Clear();

        // create a new selection based on these
        selection = new List<View>(views);

        foreach(var v in views)
        {
            // record the old color scheme so we can get reset it
            // later when it is no longer selected
            oldSchemes.Add(v, v.ColorScheme);

            // since the view is selected mark it so
            v.ColorScheme = SelectedScheme;
        }
    }
    internal void Clear()
    {
        selection.Clear();

        // reset old color schemes so views don't still look selected
        foreach(var kvp in oldSchemes)
        {
            kvp.Key.ColorScheme = kvp.Value;
        }
        oldSchemes.Clear();
    }
}
