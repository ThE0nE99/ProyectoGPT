using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_InformacionAvance_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      //mandar los colores desde aqui 
      //llamar entidades 
        Div1.Style["display"] = "none";
        Div2.Style["display"] = "none";
        Div3.Style["display"] = "none";
        Div4.Style["display"] = "none";

    }

    protected void Tema_Click(object sender, EventArgs e)
    {
        Div1.Style["display"] = "block";
        Div2.Style["display"] = "none";
        Div3.Style["display"] = "none";
        Div4.Style["display"] = "none";
    }

    protected void Perfil_Click(object sender, EventArgs e)
    {
        Div1.Style["display"] = "none";
        Div2.Style["display"] = "block";
        Div3.Style["display"] = "none";
        Div4.Style["display"] = "none";
    }

    protected void Privada_Click(object sender, EventArgs e)
    {
        Div1.Style["display"] = "none";
        Div2.Style["display"] = "none";
        Div3.Style["display"] = "block";
        Div4.Style["display"] = "none";
    }

    protected void Publica_Click(object sender, EventArgs e)
    {
        Div1.Style["display"] = "none";
        Div2.Style["display"] = "none";
        Div3.Style["display"] = "none";
        Div4.Style["display"] = "block";
    }
}