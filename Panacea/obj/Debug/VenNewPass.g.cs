#pragma checksum "..\..\VenNewPass.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BCC9F258563D2901056927ECA874A8922CE86CFC729062D6957AEA4087EBE8EE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Panacea;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Panacea {
    
    
    /// <summary>
    /// VenNewPass
    /// </summary>
    public partial class VenNewPass : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\VenNewPass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btncambi;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\VenNewPass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUser;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\VenNewPass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtpas1;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\VenNewPass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtpas2;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\VenNewPass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btncancel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\VenNewPass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox oldPassword;
        
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
            System.Uri resourceLocater = new System.Uri("/Panacea;component/vennewpass.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VenNewPass.xaml"
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
            
            #line 16 "..\..\VenNewPass.xaml"
            ((Panacea.VenNewPass)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btncambi = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\VenNewPass.xaml"
            this.btncambi.Click += new System.Windows.RoutedEventHandler(this.btncambi_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtUser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtpas1 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.txtpas2 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.btncancel = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\VenNewPass.xaml"
            this.btncancel.Click += new System.Windows.RoutedEventHandler(this.btncancel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.oldPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

