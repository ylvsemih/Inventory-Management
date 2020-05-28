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
    public partial class urun_guncelleme : Form
    {
        public urun_guncelleme()
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
        private void urun_guncelleme_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label7.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                label4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
               
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                // dateTimePicker3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\yapi_market;AttachDbFilename=|DataDirectory|\App_Data\yapi_market.mdf;Integrated Security=True");
                if ((dateTimePicker1.Visible == true))
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == ""))
                    {
                        MessageBox.Show("Lütfen Tüm Değerleri Eksiksiz Giriniz");
                    }
                    else
                    {
                        double adet, satis_fiyati, alis_fiyati;
                        adet = double.Parse(textBox3.Text);
                        alis_fiyati = double.Parse(textBox4.Text);
                        satis_fiyati = double.Parse(textBox5.Text);


                        baglanti.Open();
                        string guncelle = "update urun Set urun_markasi=@urun_markasi,urun_adi=@urun_adi,adet=@adet,toplam_alis_fiyati=@toplam_alis_fiyati,birim_satis_fiyati=@birim_satis_fiyati,alis_tarihi=@alis_tarihi,kritik_stok=@kritik_stok where id='" + label7.Text + "'";
                        SqlCommand komut = new SqlCommand(guncelle, baglanti);
                        komut.Parameters.AddWithValue("@urun_markasi", textBox1.Text);
                        komut.Parameters.AddWithValue("@urun_adi", textBox2.Text);
                        komut.Parameters.AddWithValue("@adet", adet.ToString());

                        komut.Parameters.AddWithValue("@toplam_alis_fiyati", alis_fiyati.ToString());
                        komut.Parameters.AddWithValue("@birim_satis_fiyati", satis_fiyati.ToString());
                        string tarih = dateTimePicker1.Value.ToString();
                        komut.Parameters.AddWithValue("@alis_tarihi", tarih.ToString());
                        komut.Parameters.AddWithValue("@kritik_stok", textBox6.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kayıtlar Başarıyla Güncellenmiştir");
                        griddoldur();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Değerleri Eksiksiz Giriniz");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
