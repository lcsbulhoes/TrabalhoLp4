﻿#pragma checksum "..\..\Cadastrar.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8835F32518D06BB185618D3701A803D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
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


namespace TrabalhoLP4 {
    
    
    /// <summary>
    /// Cadastrar
    /// </summary>
    public partial class Cadastrar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\Cadastrar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtID;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\Cadastrar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblID;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Cadastrar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNomeAluno;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Cadastrar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNome;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Cadastrar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRelatorio;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Cadastrar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnviar;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Cadastrar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtData;
        
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
            System.Uri resourceLocater = new System.Uri("/TrabalhoLP4;component/cadastrar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Cadastrar.xaml"
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
            this.txtID = ((System.Windows.Controls.TextBox)(target));
            
            #line 7 "..\..\Cadastrar.xaml"
            this.txtID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtID_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblID = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblNomeAluno = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtNome = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtRelatorio = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnEnviar = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Cadastrar.xaml"
            this.btnEnviar.Click += new System.Windows.RoutedEventHandler(this.btnEviar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtData = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\Cadastrar.xaml"
            this.txtData.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

