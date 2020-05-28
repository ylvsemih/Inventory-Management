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
    public partial class urun_listesi : Form
    {
        public urun_listesi()
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
        private void urun_listesi_Load(object sender, EventArgs e)
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
    }
}
