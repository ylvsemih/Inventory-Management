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
    public partial class satis_yap : Form
    {
        public satis_yap()
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
        private void satis_yap_Load(object sender, EventArgs e)
        {
            try
            {
                griddoldur();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\yapi_market;AttachDbFilename=|DataDirectory|\App_Data\yapi_market.mdf;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(conString);
            try
            {
                int girilen = Convert.ToInt32(textBox1.Text.ToString());
                int adet2 = Convert.ToInt32(adet_text.Text.ToString());
                if (girilen > adet2)
                {
                    MessageBox.Show("Belirtilen Adet Değeri Kayıtlı Adet Değerinden Fazladır");
                }
                else
                {
                    if (textBox1.Text != "")
                    {
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Lütfen Tüm Değerleri Eksiksiz Giriniz");
                        }
                        else
                        {
                            DialogResult satisi_yap = new DialogResult();
                            satisi_yap = MessageBox.Show("Satışı Yapma İstiyor Musunuz ?İşlemden sonra güncelleme yapılamayacaktır", "Uyarı", MessageBoxButtons.YesNo);
                            if (satisi_yap == DialogResult.Yes)
                            {
                                if (baglanti.State == ConnectionState.Closed)
                                    baglanti.Open();
                                string guncelle = "update urun Set adet=adet-'" + textBox1.Text + "' where id='" + id_text.Text + "'";
                                SqlCommand komut2 = new SqlCommand(guncelle, baglanti);
                                komut2.ExecuteNonQuery();
                                baglanti.Close();

                                double adet, satis_fiyati, toplam_para;
                                adet = double.Parse(textBox1.Text);
                                satis_fiyati = double.Parse(satis_fiyati_text.Text);
                                toplam_para = adet * satis_fiyati;
                                toplam_fiyat_text.Text = toplam_para.ToString();

                                baglanti.Open();
                                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                                string kayit = "insert into satis(urun_markasi,urun_adi,satilan_adet,birim_satis_fiyati,satis_tarihi,toplam_satis_tutari)values (@urun_markasi,@urun_adi,@satilan_adet,@birim_satis_fiyati,@satis_tarihi,@toplam_satis_tutari)";
                                SqlCommand komut = new SqlCommand(kayit, baglanti);
                                komut.Parameters.AddWithValue("@urun_markasi", urun_markasi_text.Text);
                                komut.Parameters.AddWithValue("@urun_adi", urun_adi.Text);
                                komut.Parameters.AddWithValue("@satilan_adet", textBox1.Text);
                                komut.Parameters.AddWithValue("@birim_satis_fiyati", satis_fiyati_text.Text);                                
                                string tarih = dateTimePicker1.Value.ToString();
                                komut.Parameters.AddWithValue("@satis_tarihi", tarih.ToString());
                                komut.Parameters.AddWithValue("@toplam_satis_tutari", toplam_fiyat_text.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Satış Yapıldı.");

                                griddoldur();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Tüm Değerleri Eksiksiz Giriniz");
                    }
                }
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
                id_text.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                urun_markasi_text.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                urun_adi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                adet_text.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                satis_fiyati_text.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Belirlenemeyen Bir Hata Oluştu.Lütfen Tekrar Denemeyin");
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
    }
}
