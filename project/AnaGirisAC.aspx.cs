using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class AnaGirisAC : Page
{
    public string baglantiMetni = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

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

    protected void BtnGiris_Click(object sender, EventArgs e)
    {
        SqlConnection cnn = new SqlConnection(baglantiMetni);
        if (!(cnn.State == ConnectionState.Closed)) return;
        cnn.Open();
        SqlCommand cmd = new SqlCommand("select COUNT(*) from acKullanicilar where KullaniciAdi='" + TxtKullaniciAdi.Text +  "' and Sifre='" + TxtSifre.Text + "'", cnn);
        int count = (int)cmd.ExecuteScalar();
        //cnn.Close();
        if (count == 0) return;
        Session["ad"] = TxtKullaniciAdi.Text;
        Response.Redirect("AnaSayfaAC.aspx");
    }

}