﻿#pragma checksum "..\..\..\addevent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60EC6735153A73DF42606BCBF641AD0C8A168405"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
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
using itc_mng;


namespace itc_mng {
    
    
    /// <summary>
    /// addevent
    /// </summary>
    public partial class addevent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\addevent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox add_nameevent;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\addevent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox add_Idevent;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\addevent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox add_depevent;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\addevent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox add_dateevent;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\addevent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save_btnevent;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\addevent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_closebtnevent;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/itc_mng;component/addevent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\addevent.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.add_nameevent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.add_Idevent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.add_depevent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.add_dateevent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.save_btnevent = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\addevent.xaml"
            this.save_btnevent.Click += new System.Windows.RoutedEventHandler(this.save_btnevent_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.add_closebtnevent = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\addevent.xaml"
            this.add_closebtnevent.Click += new System.Windows.RoutedEventHandler(this.add_closebtnevent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

