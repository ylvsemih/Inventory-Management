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
    public partial class urun_ekle : Form
    {
        public urun_ekle()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            dateTimePicker1.Enabled = true;
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\yapi_market;AttachDbFilename=|DataDirectory|\App_Data\yapi_market.mdf;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(conString);


            try
            {
                if ((dateTimePicker1.Visible == true) && (dateTimePicker1.Enabled == true))
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == ""))
                    {
                        MessageBox.Show("Lütfen Tüm Değerleri Eksiksiz Giriniz");
                    }
                    else
                    {
                        
                            baglanti.Open();
                        string kayit = "insert into urun(urun_markasi,urun_adi,adet,toplam_alis_fiyati,birim_satis_fiyati,alis_tarihi,kritik_stok) values (@urun_markasi,@urun_adi,@adet,@toplam_alis_fiyati,@birim_satis_fiyati,@alis_tarihi,@kritik_stok)";
                        // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                        SqlCommand komut = new SqlCommand(kayit, baglanti);
                        //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                        komut.Parameters.AddWithValue("@urun_markasi", textBox1.Text);
                        komut.Parameters.AddWithValue("@urun_adi", textBox2.Text);
                        komut.Parameters.AddWithValue("@adet", textBox3.Text);
                        komut.Parameters.AddWithValue("@toplam_alis_fiyati", textBox4.Text);
                        komut.Parameters.AddWithValue("@birim_satis_fiyati", textBox5.Text);
                        string tarih = dateTimePicker1.Value.ToString();
                        komut.Parameters.AddWithValue("@alis_tarihi", tarih.ToString());
                        komut.Parameters.AddWithValue("@kritik_stok", textBox6.Text);

                        //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                        komut.ExecuteNonQuery();
                        //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                        baglanti.Close();
                        MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti.");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                       
                        dateTimePicker1.Enabled = false;
                        dateTimePicker1.Visible = true;
                        panel1.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Değerleri Eksiksiz Giriniz");
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu.Lütfen Tekrar Deneyin" + hata.Message);
            }
        }

        private void urun_ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
