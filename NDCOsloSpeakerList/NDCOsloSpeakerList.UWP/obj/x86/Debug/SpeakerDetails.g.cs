﻿#pragma checksum "C:\Users\mkwwh\source\repos\NDCOsloSpeakerList\NDCOsloSpeakerList\NDCOsloSpeakerList.Shared\SpeakerDetails.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DEBBF3822D64EA525B19CA14C9089CB3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NDCOsloSpeakerList.Shared
{
    partial class SpeakerDetails : 
        global::Windows.UI.Xaml.Controls.Page, 
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
            case 2: // SpeakerDetails.xaml line 21
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.SpeakerPage_Click;
                }
                break;
            case 3: // SpeakerDetails.xaml line 16
                {
                    this.SpeakerName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // SpeakerDetails.xaml line 17
                {
                    this.SpeakerImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5: // SpeakerDetails.xaml line 18
                {
                    this.SessionTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // SpeakerDetails.xaml line 19
                {
                    this.SessionSummary = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

