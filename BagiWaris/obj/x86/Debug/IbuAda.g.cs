﻿#pragma checksum "C:\Users\Muhammad\Documents\Visual Studio 2015\Projects\BagiWaris\BagiWaris\IbuAda.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "44E4D596BBFA3C0ACED9B027F8238824"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BagiWaris
{
    partial class IbuAda : 
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
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 17 "..\..\..\IbuAda.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element2 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 20 "..\..\..\IbuAda.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element2).Click += this.AppBarButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.labelTitleTotalHarta = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.labelTotalHartaIbu = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.buttonHitungIbu = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\IbuAda.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonHitungIbu).Click += this.buttonHitungIbu_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.totalIbu = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
