using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnaGirisAC : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LblKullaniciAdi.Text = "Kullanıcı Adı";
            LblSifre.Text = "Şifre";
            BtnGiris.Text = "Giriş";
            rBtnDil.Items.Clear();
            rBtnDil.Items.Add("Türkçe");
            rBtnDil.Items.Add("Fransızca");
            rBtnDil.Items[0].Selected = true;
        }

    }

    protected void BtnGiris_Click(object sender, EventArgs e)
    {

    }
    protected void rBtnDil_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rBtnDil.Items[0].Selected)
        {
            LblKullaniciAdi.Text = "Kullanıcı Adı";
            LblSifre.Text = "Şifre";
            BtnGiris.Text = "Giriş";
            rBtnDil.Items[0].Text = "Türkçe";
            rBtnDil.Items[1].Text = "Fransızca";
        }
        else if (rBtnDil.Items[1].Selected)
        {
            LblKullaniciAdi.Text = "Nom d'utilisateur";
            LblSifre.Text = "mot de passe";
            BtnGiris.Text = "entrée";
            rBtnDil.Items[0].Text = "turc";
            rBtnDil.Items[1].Text = "Francais";
        }
    }
}