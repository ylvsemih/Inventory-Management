using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace yapi_market_programi
{
    public partial class urun_silme : Form
    {
        public urun_silme()
        {
            InitializeComponent();
        }
        void griddoldur()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\yapi_market;AttachDbFilename=|DataDirectory|\App_Data\yapi_market.mdf;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * From urun", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "urun");
            dataGridView1.DataSource = ds.Tables["urun"];
            con.Close();
        }
        private void urun_silme_Load(object sender, EventArgs e)
        {
            try
            {
                griddoldur();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                label1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\yapi_market;AttachDbFilename=|DataDirectory|\App_Data\yapi_market.mdf;Integrated Security=True");
            try
            {

                baglanti.Open();

                string srg = textBox7.Text.ToString();

                string sorgu = "Select * from urun where urun_adi Like '%" + srg + "%'";
                SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);

                DataSet ds = new DataSet();

                adap.Fill(ds, "urun");

                this.dataGridView1.DataSource = ds.Tables[0];

                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu.Lütfen Tekrar Deneyin" + hata.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult satisi_yap = new DialogResult();
            satisi_yap = MessageBox.Show("Seçilen veriyi Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (satisi_yap == DialogResult.Yes)
            {
                try
                {
                    SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\yapi_market;AttachDbFilename=|DataDirectory|\App_Data\yapi_market.mdf;Integrated Security=True");
                    baglanti.Open();
                    string sil = "Delete From urun where id='" + label2.Text + "'";
                    SqlCommand komut = new SqlCommand(sil, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Başarıyla Silinmiştir");
                    griddoldur();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                }
            }
        }
    }
}
