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
    public partial class stok_bilgisi : Form
    {
        public stok_bilgisi()
        {
            InitializeComponent();
        }
        void griddoldur()
        {
            string conString = @"Data Source=(LocalDB)\yapi_market;AttachDbFilename=|DataDirectory|\App_Data\yapi_market.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            SqlDataAdapter da = new SqlDataAdapter("Select * From urun where adet<=kritik_stok", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "urun");
            dataGridView1.DataSource = ds.Tables["urun"];
            con.Close();
        }
        private void stok_bilgisi_Load(object sender, EventArgs e)
        {
            try
            {
                griddoldur();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu");
            }
        }
    }
}
