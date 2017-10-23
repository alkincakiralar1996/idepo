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
            rBtnDil.Items.Add("Francais");
        }

    }

    protected void BtnGiris_Click(object sender, EventArgs e)
    {

    }
}