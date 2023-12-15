using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sql_ile_veri_bagla { 

public partial class Form1 : Form
{ 

    public Form1()
    {
        InitializeComponent();
    }
    static string constring = "Data Source=DESKTOP-1S4V3OL\\SQLEXPRESS;Initial Catalog=personel;Integrated Security=True";
    SqlConnection Connect = new SqlConnection(constring);

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            if(Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                string kayitekle = "insert into bilgi (ad, soyad) values (@kisi_adi,@kisi_soyadi)";
                SqlCommand komut = new SqlCommand(kayitekle, Connect);
                komut.Parameters.AddWithValue("@kisi_adi", textBox1.Text);
                komut.Parameters.AddWithValue("@kisi_soyadi", textBox2.Text);

                komut.ExecuteNonQuery();
                Connect.Close();
                MessageBox.Show("işlem yapıldı");
            }

            

        }
        catch (Exception uyari)
        {
            MessageBox.Show("uyarınız var"+ uyari);

            throw;
        }


    }

    private void Form1_Load(object sender, EventArgs e)
    {
            // TODO: This line of code loads data into the 'personelDataSet5.bilgi' table. You can move, or remove it, as needed.
            this.bilgiTableAdapter2.Fill(this.personelDataSet5.bilgi);
            // TODO: This line of code loads data into the 'personelDataSet3.bilgi' table. You can move, or remove it, as needed.
            this.bilgiTableAdapter1.Fill(this.personelDataSet3.bilgi);

    }
}


}
