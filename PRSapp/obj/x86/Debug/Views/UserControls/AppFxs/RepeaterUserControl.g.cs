﻿#pragma checksum "C:\Users\Flazz\source\repos\FebOn\April_Master\PRSapp\PRSapp\Views\UserControls\AppFxs\RepeaterUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "299CA58B5C3E0972F3096D210EAB64FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRSapp.Views.UserControls.AppFxs
{
    partial class RepeaterUserControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\UserControls\AppFxs\RepeaterUserControl.xaml line 53
                {
                    this.stpStatus = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // Views\UserControls\AppFxs\RepeaterUserControl.xaml line 62
                {
                    this.stpSpeechSettings = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // Views\UserControls\AppFxs\RepeaterUserControl.xaml line 66
                {
                    this.cboVoiceGender = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cboVoiceGender).SelectionChanged += this.cboVoiceGender_SelectionChanged;
                }
                break;
            case 5: // Views\UserControls\AppFxs\RepeaterUserControl.xaml line 57
                {
                    this.tbStatus = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Views\UserControls\AppFxs\RepeaterUserControl.xaml line 37
                {
                    this.BtnRepeatMediaOutAsync = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.BtnRepeatMediaOutAsync).Click += this.BtnRepeatMediaOutAsync_Click;
                }
                break;
            case 7: // Views\UserControls\AppFxs\RepeaterUserControl.xaml line 42
                {
                    this.BtnStopPauseRepeatMediaOutAsync = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.BtnStopPauseRepeatMediaOutAsync).Click += this.BtnStopPauseRepeatMediaOutAsync_Click;
                }
                break;
            case 8: // Views\UserControls\AppFxs\RepeaterUserControl.xaml line 46
                {
                    this.TgsRepeats = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                }
                break;
            case 9: // Views\UserControls\AppFxs\RepeaterUserControl.xaml line 47
                {
                    this.boxRepetitions = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // Views\UserControls\AppFxs\RepeaterUserControl.xaml line 48
                {
                    this.boxInterval = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // Views\UserControls\AppFxs\RepeaterUserControl.xaml line 49
                {
                    this.uiMediaElement = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 12: // Views\UserControls\AppFxs\RepeaterUserControl.xaml line 23
                {
                    this.boxTitleName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13: // Views\UserControls\AppFxs\RepeaterUserControl.xaml line 26
                {
                    this.boxTtsRaw = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

