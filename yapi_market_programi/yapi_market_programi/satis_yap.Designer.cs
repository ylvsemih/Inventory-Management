namespace yapi_market_programi
{
    partial class satis_yap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satis_yap));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urun_adi = new System.Windows.Forms.Label();
            this.urun_markasi_text = new System.Windows.Forms.Label();
            this.adet_text = new System.Windows.Forms.Label();
            this.satis_fiyati_text = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toplam_fiyat_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(395, 349);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 44);
            this.button2.TabIndex = 77;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(157, 358);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(230, 26);
            this.textBox7.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 362);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 19);
            this.label6.TabIndex = 75;
            this.label6.Text = "Ürün Adına Göre Ara";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(904, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 44);
            this.button1.TabIndex = 79;
            this.button1.Text = "Seçili Ürünü Sat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(666, 64);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 26);
            this.textBox1.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 80;
            this.label1.Text = "Seçili Ürün Adı :";
            // 
            // urun_adi
            // 
            this.urun_adi.AutoSize = true;
            this.urun_adi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_adi.Location = new System.Drawing.Point(770, 24);
            this.urun_adi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urun_adi.Name = "urun_adi";
            this.urun_adi.Size = new System.Drawing.Size(14, 19);
            this.urun_adi.TabIndex = 81;
            this.urun_adi.Text = "-";
            // 
            // urun_markasi_text
            // 
            this.urun_markasi_text.AutoSize = true;
            this.urun_markasi_text.Location = new System.Drawing.Point(662, 169);
            this.urun_markasi_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urun_markasi_text.Name = "urun_markasi_text";
            this.urun_markasi_text.Size = new System.Drawing.Size(86, 19);
            this.urun_markasi_text.TabIndex = 82;
            this.urun_markasi_text.Text = "urun markası";
            this.urun_markasi_text.Visible = false;
            // 
            // adet_text
            // 
            this.adet_text.AutoSize = true;
            this.adet_text.Location = new System.Drawing.Point(662, 202);
            this.adet_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adet_text.Name = "adet_text";
            this.adet_text.Size = new System.Drawing.Size(35, 19);
            this.adet_text.TabIndex = 83;
            this.adet_text.Text = "adet";
            this.adet_text.Visible = false;
            // 
            // satis_fiyati_text
            // 
            this.satis_fiyati_text.AutoSize = true;
            this.satis_fiyati_text.Location = new System.Drawing.Point(662, 237);
            this.satis_fiyati_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.satis_fiyati_text.Name = "satis_fiyati_text";
            this.satis_fiyati_text.Size = new System.Drawing.Size(67, 19);
            this.satis_fiyati_text.TabIndex = 85;
            this.satis_fiyati_text.Text = "satis fiyati";
            this.satis_fiyati_text.Visible = false;
            // 
            // id_text
            // 
            this.id_text.AutoSize = true;
            this.id_text.Location = new System.Drawing.Point(660, 140);
            this.id_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(20, 19);
            this.id_text.TabIndex = 86;
            this.id_text.Text = "id";
            this.id_text.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(666, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 87;
            // 
            // toplam_fiyat_text
            // 
            this.toplam_fiyat_text.AutoSize = true;
            this.toplam_fiyat_text.Location = new System.Drawing.Point(662, 277);
            this.toplam_fiyat_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toplam_fiyat_text.Name = "toplam_fiyat_text";
            this.toplam_fiyat_text.Size = new System.Drawing.Size(79, 19);
            this.toplam_fiyat_text.TabIndex = 88;
            this.toplam_fiyat_text.Text = "toplam fiyat";
            this.toplam_fiyat_text.Visible = false;
            // 
            // satis_yap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1074, 406);
            this.Controls.Add(this.toplam_fiyat_text);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.satis_fiyati_text);
            this.Controls.Add(this.adet_text);
            this.Controls.Add(this.urun_markasi_text);
            this.Controls.Add(this.urun_adi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "satis_yap";
            this.Text = "Satış Yap";
            this.Load += new System.EventHandler(this.satis_yap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label urun_adi;
        private System.Windows.Forms.Label urun_markasi_text;
        private System.Windows.Forms.Label adet_text;
        private System.Windows.Forms.Label satis_fiyati_text;
        private System.Windows.Forms.Label id_text;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label toplam_fiyat_text;
    }
}