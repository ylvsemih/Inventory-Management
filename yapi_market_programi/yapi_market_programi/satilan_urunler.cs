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
    public partial class satilan_urunler : Form
    {
        public satilan_urunler()
        {
            InitializeComponent();
        }
        void griddoldur()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\yapi_market;AttachDbFilename=|DataDirectory|\App_Data\yapi_market.mdf;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * From satis", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "satis");
            dataGridView1.DataSource = ds.Tables["satis"];
            con.Close();
        }
        private void satilan_urunler_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
                    string sil = "Delete From satis where id='" + id_text.Text + "'";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_text.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                label1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Belirlenemeyen Bir Hata Oluştu.Lütfen Tekrar Denemeyin");
            }
        }
    }
}
