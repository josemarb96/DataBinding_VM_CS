﻿#pragma checksum "C:\Users\jmramirez\Documents\Visual Studio 2015\Projects\DataBinding_VM_CS\DataBinding_VM_CS\Views\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E4EC37C2E248E8B93A6186515694612A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBinding_VM_CS
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
                    this.myName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 2:
                {
                    this.mySurname = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.myAge = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.myTlfn = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.btnSave = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 73 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSave).Click += this.saveChanges;
                    #line default
                }
                break;
            case 6:
                {
                    this.myAddress = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.listadoPersonas = (global::Windows.UI.Xaml.Controls.ListView)(target);
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

