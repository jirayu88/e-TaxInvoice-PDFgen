﻿#pragma checksum "..\..\..\..\Forms\Item.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EDB6F241AA7205BE932F55ABAA37F924"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using eTaxInvoicePdfGenerator.Forms;


namespace eTaxInvoicePdfGenerator.Forms {
    
    
    /// <summary>
    /// Item
    /// </summary>
    public partial class Item : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 29 "..\..\..\..\Forms\Item.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Forms\Item.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image1;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Forms\Item.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Forms\Item.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Forms\Item.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitBtn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Forms\Item.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Forms\Item.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextBtn;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Forms\Item.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button prevBtn;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Forms\Item.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pageLb;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Forms\Item.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button shutdownBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/eTaxInvoicePdfGenerator;component/forms/item.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Forms\Item.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\Forms\Item.xaml"
            ((eTaxInvoicePdfGenerator.Forms.Item)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\..\Forms\Item.xaml"
            ((eTaxInvoicePdfGenerator.Forms.Item)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.image1 = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.addBtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Forms\Item.xaml"
            this.addBtn.Click += new System.Windows.RoutedEventHandler(this.addBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.delBtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\Forms\Item.xaml"
            this.delBtn.Click += new System.Windows.RoutedEventHandler(this.delBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.exitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\Forms\Item.xaml"
            this.exitBtn.Click += new System.Windows.RoutedEventHandler(this.exitBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.listView = ((System.Windows.Controls.ListView)(target));
            
            #line 40 "..\..\..\..\Forms\Item.xaml"
            this.listView.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.listView_Click));
            
            #line default
            #line hidden
            return;
            case 9:
            this.nextBtn = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\..\Forms\Item.xaml"
            this.nextBtn.Click += new System.Windows.RoutedEventHandler(this.nextBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.prevBtn = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\..\Forms\Item.xaml"
            this.prevBtn.Click += new System.Windows.RoutedEventHandler(this.prevBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.pageLb = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.shutdownBtn = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\Forms\Item.xaml"
            this.shutdownBtn.Click += new System.Windows.RoutedEventHandler(this.shutdownBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 8:
            
            #line 61 "..\..\..\..\Forms\Item.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.OnHyperlinkClick);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

