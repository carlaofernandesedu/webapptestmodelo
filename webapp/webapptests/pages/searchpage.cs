using System;
using System.Collections.Generic;
using CUITCommon.Abstracts;
using CUITCommon;

namespace webapptests.pages
{
    public class searchpage : BasePage 
    {
        public override string Title
        {
            get { return "Search webapp"; }
        }

        public override List<ParameterProp> ConfigureParameters()
        {
            _parametros = new List<ParameterProp>();
            _parametros.Add(new ParameterProp("LinkPesquisa", "HyperLink3", false));
            _parametros.Add(new ParameterProp("CampoPesquisa", "txtcampo1", false));
            _parametros.Add(new ParameterProp("BtnPesquisar", "btnenviar", false));
            return _parametros;
        }

        public override Uri ConstructUrl()
        {
            var url = BaseURL + "/search.aspx";
            return new Uri(url);
        }

        #region "Controles"
        public dynamic LinkPesquisa;
        public dynamic CampoPesquisa;
        public dynamic BtnPesquisar;
        #endregion

        public bool PesquisarPorCampo(string campoPesquisa)
        {
            CurrentBrowser.Elements.Clear(CampoPesquisa);
            CurrentBrowser.SendKeys(CampoPesquisa, campoPesquisa);
            CurrentBrowser.Elements.Click(BtnPesquisar);
            return true;
        }
        

        //public override bool IsValidPageDisplayed()
        //{
        //    var usuario = _parametros.Find(x => x.PropName == "Usuario");
        //    var password = _parametros.Find(x => x.PropName == "Password");
        //    var btnlogar = _parametros.Find(x => x.PropName == "btnLogar");
        //    Usuario = this.CurrentBrowser.FindFirstById(usuario.ControlType, usuario.ControlId);
        //    Password = this.CurrentBrowser.FindFirstById(password.ControlType, password.ControlId);
        //    btnLogar = this.CurrentBrowser.FindFirstById(btnlogar.ControlType, btnlogar.ControlId);
        //    return true;
        //}
    }
}
