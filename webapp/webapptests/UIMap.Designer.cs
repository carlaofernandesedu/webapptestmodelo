﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace webapptests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Abrirobrowsereacesarapaginainicial - Test Case 51 - Use 'AbrirobrowsereacesarapaginainicialParams' to pass parameters into this method.
        /// </summary>
        public void Abrirobrowsereacesarapaginainicial()
        {

            // Go to web page 'http://localhost/webapp/' using new browser instance
            this.UIHomewebappInternetExWindow.LaunchUrl(new System.Uri(this.AbrirobrowsereacesarapaginainicialParams.UIHomewebappInternetExWindowUrl));
        }
        
        /// <summary>
        /// clicarnoitemPesquisa - Test Case 51
        /// </summary>
        public void clicarnoitemPesquisa()
        {
            #region Variable Declarations
            HtmlHyperlink uIPesquisaHyperlink = this.UIHomewebappInternetExWindow.UIHomewebappDocument.UIPesquisaHyperlink;
            #endregion

            // Click 'Pesquisa' link
            Mouse.Click(uIPesquisaHyperlink, new Point(36, 12));
        }
        
        /// <summary>
        /// informarvalornocampopesqcampo - Test Case 51 - Use 'informarvalornocampopesqcampoParams' to pass parameters into this method.
        /// </summary>
        public void informarvalornocampopesqcampo()
        {
            #region Variable Declarations
            HtmlEdit uITxtcampo1Edit = this.UISearchwebappInternetWindow.UISearchwebappDocument.UITxtcampo1Edit;
            HtmlDiv uIPesquisacampo1campo2Pane = this.UISearchwebappInternetWindow.UISearchwebappDocument.UIForm1Custom.UIPesquisacampo1campo2Pane;
            #endregion

            // Type 'campo1' in 'txtcampo1' text box
            uITxtcampo1Edit.Text = this.informarvalornocampopesqcampoParams.UITxtcampo1EditText;

            // Click 'pesquisa campo1 campo2 c' pane
            Mouse.Click(uIPesquisacampo1campo2Pane, new Point(346, 128));
        }
        
        /// <summary>
        /// Clicarempesquisar - Test Case 51
        /// </summary>
        public void Clicarempesquisar()
        {
            #region Variable Declarations
            HtmlInputButton uIPesquisarButton = this.UISearchwebappInternetWindow.UISearchwebappDocument.UIPesquisarButton;
            #endregion

            // Click 'Pesquisar' button
            Mouse.Click(uIPesquisarButton, new Point(32, 15));
        }
        
        /// <summary>
        /// Fecharobrowser - Test Case 51
        /// </summary>
        public void Fecharobrowser()
        {
            #region Variable Declarations
            BrowserWindow uISearchwebappInternetWindow = this.UISearchwebappInternetWindow;
            #endregion

            // Perform Close on Browser Window
            uISearchwebappInternetWindow.Close();
        }
        
        #region Properties
        public virtual AbrirobrowsereacesarapaginainicialParams AbrirobrowsereacesarapaginainicialParams
        {
            get
            {
                if ((this.mAbrirobrowsereacesarapaginainicialParams == null))
                {
                    this.mAbrirobrowsereacesarapaginainicialParams = new AbrirobrowsereacesarapaginainicialParams();
                }
                return this.mAbrirobrowsereacesarapaginainicialParams;
            }
        }
        
        public virtual informarvalornocampopesqcampoParams informarvalornocampopesqcampoParams
        {
            get
            {
                if ((this.minformarvalornocampopesqcampoParams == null))
                {
                    this.minformarvalornocampopesqcampoParams = new informarvalornocampopesqcampoParams();
                }
                return this.minformarvalornocampopesqcampoParams;
            }
        }
        
        public UIHomewebappInternetExWindow UIHomewebappInternetExWindow
        {
            get
            {
                if ((this.mUIHomewebappInternetExWindow == null))
                {
                    this.mUIHomewebappInternetExWindow = new UIHomewebappInternetExWindow();
                }
                return this.mUIHomewebappInternetExWindow;
            }
        }
        
        public UISearchwebappInternetWindow UISearchwebappInternetWindow
        {
            get
            {
                if ((this.mUISearchwebappInternetWindow == null))
                {
                    this.mUISearchwebappInternetWindow = new UISearchwebappInternetWindow();
                }
                return this.mUISearchwebappInternetWindow;
            }
        }
        #endregion
        
        #region Fields
        private AbrirobrowsereacesarapaginainicialParams mAbrirobrowsereacesarapaginainicialParams;
        
        private informarvalornocampopesqcampoParams minformarvalornocampopesqcampoParams;
        
        private UIHomewebappInternetExWindow mUIHomewebappInternetExWindow;
        
        private UISearchwebappInternetWindow mUISearchwebappInternetWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Abrirobrowsereacesarapaginainicial'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class AbrirobrowsereacesarapaginainicialParams
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'http://localhost/webapp/' using new browser instance
        /// </summary>
        public string UIHomewebappInternetExWindowUrl = "http://localhost/webapp/";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'informarvalornocampopesqcampo'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class informarvalornocampopesqcampoParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'campo1' in 'txtcampo1' text box
        /// </summary>
        public string UITxtcampo1EditText = "campo1";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIHomewebappInternetExWindow : BrowserWindow
    {
        
        public UIHomewebappInternetExWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Home webapp";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Home webapp");
            this.WindowTitles.Add("http://localhost/webapp/");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHomewebappDocument UIHomewebappDocument
        {
            get
            {
                if ((this.mUIHomewebappDocument == null))
                {
                    this.mUIHomewebappDocument = new UIHomewebappDocument(this);
                }
                return this.mUIHomewebappDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHomewebappDocument mUIHomewebappDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIHomewebappDocument : HtmlDocument
    {
        
        public UIHomewebappDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Home webapp";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/webapp/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost/webapp/";
            this.WindowTitles.Add("Home webapp");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIPesquisaHyperlink
        {
            get
            {
                if ((this.mUIPesquisaHyperlink == null))
                {
                    this.mUIPesquisaHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIPesquisaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "HyperLinkpesquisa";
                    this.mUIPesquisaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIPesquisaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIPesquisaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Pesquisa";
                    this.mUIPesquisaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/webapp/search.aspx";
                    this.mUIPesquisaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIPesquisaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost/webapp/search.aspx";
                    this.mUIPesquisaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIPesquisaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "id=\"HyperLinkpesquisa\" href=\"search.aspx";
                    this.mUIPesquisaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUIPesquisaHyperlink.WindowTitles.Add("Home webapp");
                    #endregion
                }
                return this.mUIPesquisaHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIPesquisaHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UISearchwebappInternetWindow : BrowserWindow
    {
        
        public UISearchwebappInternetWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Search webapp";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Search webapp");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UISearchwebappDocument UISearchwebappDocument
        {
            get
            {
                if ((this.mUISearchwebappDocument == null))
                {
                    this.mUISearchwebappDocument = new UISearchwebappDocument(this);
                }
                return this.mUISearchwebappDocument;
            }
        }
        #endregion
        
        #region Fields
        private UISearchwebappDocument mUISearchwebappDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UISearchwebappDocument : HtmlDocument
    {
        
        public UISearchwebappDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Search webapp";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/webapp/search.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost/webapp/search.aspx";
            this.WindowTitles.Add("Search webapp");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UITxtcampo1Edit
        {
            get
            {
                if ((this.mUITxtcampo1Edit == null))
                {
                    this.mUITxtcampo1Edit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUITxtcampo1Edit.SearchProperties[HtmlEdit.PropertyNames.Id] = "txtcampo1";
                    this.mUITxtcampo1Edit.SearchProperties[HtmlEdit.PropertyNames.Name] = "txtcampo1";
                    this.mUITxtcampo1Edit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    this.mUITxtcampo1Edit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtcampo1Edit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUITxtcampo1Edit.FilterProperties[HtmlEdit.PropertyNames.Class] = null;
                    this.mUITxtcampo1Edit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"txtcampo1\" id=\"txtcampo1\" type=\"te";
                    this.mUITxtcampo1Edit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "4";
                    this.mUITxtcampo1Edit.WindowTitles.Add("Search webapp");
                    #endregion
                }
                return this.mUITxtcampo1Edit;
            }
        }
        
        public UIForm1Custom UIForm1Custom
        {
            get
            {
                if ((this.mUIForm1Custom == null))
                {
                    this.mUIForm1Custom = new UIForm1Custom(this);
                }
                return this.mUIForm1Custom;
            }
        }
        
        public HtmlInputButton UIPesquisarButton
        {
            get
            {
                if ((this.mUIPesquisarButton == null))
                {
                    this.mUIPesquisarButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUIPesquisarButton.SearchProperties[HtmlButton.PropertyNames.Id] = "btnenviar";
                    this.mUIPesquisarButton.SearchProperties[HtmlButton.PropertyNames.Name] = "btnenviar";
                    this.mUIPesquisarButton.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "Pesquisar";
                    this.mUIPesquisarButton.FilterProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIPesquisarButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUIPesquisarButton.FilterProperties[HtmlButton.PropertyNames.Class] = null;
                    this.mUIPesquisarButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "name=\"btnenviar\" id=\"btnenviar\" type=\"su";
                    this.mUIPesquisarButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "5";
                    this.mUIPesquisarButton.WindowTitles.Add("Search webapp");
                    #endregion
                }
                return this.mUIPesquisarButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUITxtcampo1Edit;
        
        private UIForm1Custom mUIForm1Custom;
        
        private HtmlInputButton mUIPesquisarButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIForm1Custom : HtmlCustom
    {
        
        public UIForm1Custom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "FORM";
            this.SearchProperties["Id"] = "form1";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties["Class"] = null;
            this.FilterProperties["ControlDefinition"] = "id=\"form1\" action=\"search.aspx\" method=\"";
            this.FilterProperties["TagInstance"] = "1";
            this.WindowTitles.Add("Search webapp");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIPesquisacampo1campo2Pane
        {
            get
            {
                if ((this.mUIPesquisacampo1campo2Pane == null))
                {
                    this.mUIPesquisacampo1campo2Pane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIPesquisacampo1campo2Pane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIPesquisacampo1campo2Pane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIPesquisacampo1campo2Pane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "pesquisa\r\n \r\n\r\n\r\n\r\ncampo1\r\n\r\ncampo2\r\n\r\nc";
                    this.mUIPesquisacampo1campo2Pane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIPesquisacampo1campo2Pane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUIPesquisacampo1campo2Pane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = null;
                    this.mUIPesquisacampo1campo2Pane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "3";
                    this.mUIPesquisacampo1campo2Pane.WindowTitles.Add("Search webapp");
                    #endregion
                }
                return this.mUIPesquisacampo1campo2Pane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIPesquisacampo1campo2Pane;
        #endregion
    }
}
