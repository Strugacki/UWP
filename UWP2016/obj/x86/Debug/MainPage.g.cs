﻿#pragma checksum "D:\Programowanie\GitHub\UWP\UWP2016\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D36F5D2A10FBBFC28B17B6A580A467FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWP2016
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.SplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.ListBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 34 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.ListBox).SelectionChanged += this.ListBox_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.kingdomsPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 54 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.kingdomsPanel).Tapped += this.kingdomsPanel_Tapped;
                    #line default
                }
                break;
            case 4:
                {
                    this.booksPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 48 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.booksPanel).Tapped += this.booksPanel_Tapped;
                    #line default
                }
                break;
            case 5:
                {
                    this.charactersPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 42 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.charactersPanel).Tapped += this.charactersPanel_Tapped;
                    #line default
                }
                break;
            case 6:
                {
                    this.homePanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 36 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.homePanel).Tapped += this.homePanel_Tapped;
                    #line default
                }
                break;
            case 7:
                {
                    this.View = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 8:
                {
                    this.HamMenuActivator = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamMenuActivator).Click += this.HamMenuActivator_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

