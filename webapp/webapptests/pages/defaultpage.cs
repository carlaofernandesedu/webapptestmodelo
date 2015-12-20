using System;
using System.Collections.Generic;
using CUITCommon.Abstracts;
using CUITCommon;

namespace webapptests.pages
{
    public class defaultpage : BasePage 
    {
        public override string Title
        {
            get { return "Home webapp"; }
        }

        public override List<ParameterProp> ConfigureParameters()
        {
            _parametros = new List<ParameterProp>();
            _parametros.Add(new ParameterProp("LinkPesquisa", "HyperLinkpesquisa", false));
            _parametros.Add(new ParameterProp("LinkCadastro", "HyperLinkcadastro", false));
            _parametros.Add(new ParameterProp("TotalRegistros", "lblregistros", false));
            _parametros.Add(new ParameterProp("DataHora", "lbldatahora", false));
            return _parametros;
        }

        public override Uri ConstructUrl()
        {
            var url = BaseURL + "/default.aspx";
            return new Uri(url);
        }

        #region "Controles"
        public dynamic LinkPesquisa;
        public dynamic LinkCadastro;
        public dynamic TotalRegistros;
        public dynamic DataHora;
        #endregion

        

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
