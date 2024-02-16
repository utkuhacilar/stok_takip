
namespace giyim
{
    partial class frmsatis
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsatis));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.txtSatışFiyatı = new System.Windows.Forms.TextBox();
            this.txtÜrünMiktarı = new System.Windows.Forms.TextBox();
            this.txtÜrünAdı = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuThinButton211 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton27 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton210 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton26 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton29 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton28 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuBtnEkle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuBtnSatısYap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuBtnSil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuBtnSatısİptal = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(228, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(662, 265);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci İşlemleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ad Soyad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "TC";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(86, 76);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 23);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(86, 48);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 23);
            this.txtAdSoyad.TabIndex = 1;
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(86, 20);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 23);
            this.txtTc.TabIndex = 0;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtToplamFiyat);
            this.groupBox2.Controls.Add(this.txtSatışFiyatı);
            this.groupBox2.Controls.Add(this.txtÜrünMiktarı);
            this.groupBox2.Controls.Add(this.txtÜrünAdı);
            this.groupBox2.Controls.Add(this.txtBarkodNo);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 161);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Toplam Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Satış Fiyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ürün Miktarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ürün Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Barkod No";
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Location = new System.Drawing.Point(101, 124);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(100, 23);
            this.txtToplamFiyat.TabIndex = 5;
            // 
            // txtSatışFiyatı
            // 
            this.txtSatışFiyatı.Location = new System.Drawing.Point(101, 98);
            this.txtSatışFiyatı.Name = "txtSatışFiyatı";
            this.txtSatışFiyatı.Size = new System.Drawing.Size(100, 23);
            this.txtSatışFiyatı.TabIndex = 4;
            this.txtSatışFiyatı.TextChanged += new System.EventHandler(this.txtSatışFiyatı_TextChanged);
            // 
            // txtÜrünMiktarı
            // 
            this.txtÜrünMiktarı.Location = new System.Drawing.Point(101, 72);
            this.txtÜrünMiktarı.Name = "txtÜrünMiktarı";
            this.txtÜrünMiktarı.Size = new System.Drawing.Size(100, 23);
            this.txtÜrünMiktarı.TabIndex = 3;
            this.txtÜrünMiktarı.Text = "1";
            this.txtÜrünMiktarı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtÜrünMiktarı.TextChanged += new System.EventHandler(this.txtÜrünMiktarı_TextChanged);
            // 
            // txtÜrünAdı
            // 
            this.txtÜrünAdı.Location = new System.Drawing.Point(101, 46);
            this.txtÜrünAdı.Name = "txtÜrünAdı";
            this.txtÜrünAdı.Size = new System.Drawing.Size(100, 23);
            this.txtÜrünAdı.TabIndex = 2;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(101, 20);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 23);
            this.txtBarkodNo.TabIndex = 1;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Genel Toplam";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(591, 394);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(0, 13);
            this.lblGenelToplam.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuThinButton211);
            this.panel1.Controls.Add(this.bunifuThinButton27);
            this.panel1.Controls.Add(this.bunifuThinButton210);
            this.panel1.Controls.Add(this.bunifuThinButton26);
            this.panel1.Controls.Add(this.bunifuThinButton29);
            this.panel1.Controls.Add(this.bunifuThinButton28);
            this.panel1.Controls.Add(this.bunifuThinButton25);
            this.panel1.Controls.Add(this.bunifuThinButton24);
            this.panel1.Controls.Add(this.bunifuThinButton23);
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 102);
            this.panel1.TabIndex = 9;
            // 
            // bunifuThinButton211
            // 
            this.bunifuThinButton211.ActiveBorderThickness = 1;
            this.bunifuThinButton211.ActiveCornerRadius = 20;
            this.bunifuThinButton211.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton211.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton211.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton211.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton211.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton211.BackgroundImage")));
            this.bunifuThinButton211.ButtonText = "Satış İptal";
            this.bunifuThinButton211.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton211.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton211.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton211.IdleBorderThickness = 1;
            this.bunifuThinButton211.IdleCornerRadius = 20;
            this.bunifuThinButton211.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton211.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton211.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton211.Location = new System.Drawing.Point(898, 172);
            this.bunifuThinButton211.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton211.Name = "bunifuThinButton211";
            this.bunifuThinButton211.Size = new System.Drawing.Size(94, 36);
            this.bunifuThinButton211.TabIndex = 20;
            this.bunifuThinButton211.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton211.Click += new System.EventHandler(this.bunifuThinButton29_Click);
            // 
            // bunifuThinButton27
            // 
            this.bunifuThinButton27.ActiveBorderThickness = 1;
            this.bunifuThinButton27.ActiveCornerRadius = 20;
            this.bunifuThinButton27.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton27.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton27.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton27.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton27.BackgroundImage")));
            this.bunifuThinButton27.ButtonText = "Müşteri Ekleme";
            this.bunifuThinButton27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton27.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton27.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton27.IdleBorderThickness = 1;
            this.bunifuThinButton27.IdleCornerRadius = 20;
            this.bunifuThinButton27.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton27.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton27.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton27.Location = new System.Drawing.Point(27, 24);
            this.bunifuThinButton27.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton27.Name = "bunifuThinButton27";
            this.bunifuThinButton27.Size = new System.Drawing.Size(124, 51);
            this.bunifuThinButton27.TabIndex = 16;
            this.bunifuThinButton27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton27.Click += new System.EventHandler(this.bunifuThinButton27_Click);
            // 
            // bunifuThinButton210
            // 
            this.bunifuThinButton210.ActiveBorderThickness = 1;
            this.bunifuThinButton210.ActiveCornerRadius = 20;
            this.bunifuThinButton210.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton210.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton210.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton210.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton210.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton210.BackgroundImage")));
            this.bunifuThinButton210.ButtonText = "Sil";
            this.bunifuThinButton210.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton210.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton210.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton210.IdleBorderThickness = 1;
            this.bunifuThinButton210.IdleCornerRadius = 20;
            this.bunifuThinButton210.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton210.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton210.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton210.Location = new System.Drawing.Point(898, 137);
            this.bunifuThinButton210.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton210.Name = "bunifuThinButton210";
            this.bunifuThinButton210.Size = new System.Drawing.Size(94, 36);
            this.bunifuThinButton210.TabIndex = 19;
            this.bunifuThinButton210.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton210.Click += new System.EventHandler(this.bunifuThinButton28_Click);
            // 
            // bunifuThinButton26
            // 
            this.bunifuThinButton26.ActiveBorderThickness = 1;
            this.bunifuThinButton26.ActiveCornerRadius = 20;
            this.bunifuThinButton26.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton26.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton26.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton26.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton26.BackgroundImage")));
            this.bunifuThinButton26.ButtonText = "Müşteri Listele";
            this.bunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton26.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton26.IdleBorderThickness = 1;
            this.bunifuThinButton26.IdleCornerRadius = 20;
            this.bunifuThinButton26.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton26.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton26.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton26.Location = new System.Drawing.Point(161, 24);
            this.bunifuThinButton26.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton26.Name = "bunifuThinButton26";
            this.bunifuThinButton26.Size = new System.Drawing.Size(124, 51);
            this.bunifuThinButton26.TabIndex = 15;
            this.bunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton26.Click += new System.EventHandler(this.bunifuThinButton26_Click);
            // 
            // bunifuThinButton29
            // 
            this.bunifuThinButton29.ActiveBorderThickness = 1;
            this.bunifuThinButton29.ActiveCornerRadius = 20;
            this.bunifuThinButton29.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton29.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton29.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton29.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton29.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton29.BackgroundImage")));
            this.bunifuThinButton29.ButtonText = "Satış Yap";
            this.bunifuThinButton29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton29.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton29.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton29.IdleBorderThickness = 1;
            this.bunifuThinButton29.IdleCornerRadius = 20;
            this.bunifuThinButton29.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton29.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton29.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton29.Location = new System.Drawing.Point(787, 387);
            this.bunifuThinButton29.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton29.Name = "bunifuThinButton29";
            this.bunifuThinButton29.Size = new System.Drawing.Size(103, 33);
            this.bunifuThinButton29.TabIndex = 18;
            this.bunifuThinButton29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton29.Click += new System.EventHandler(this.bunifuBtnSatısYap_Click);
            // 
            // bunifuThinButton28
            // 
            this.bunifuThinButton28.ActiveBorderThickness = 1;
            this.bunifuThinButton28.ActiveCornerRadius = 20;
            this.bunifuThinButton28.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton28.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton28.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton28.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton28.BackgroundImage")));
            this.bunifuThinButton28.ButtonText = "Ekle";
            this.bunifuThinButton28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton28.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton28.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton28.IdleBorderThickness = 1;
            this.bunifuThinButton28.IdleCornerRadius = 20;
            this.bunifuThinButton28.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton28.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton28.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton28.Location = new System.Drawing.Point(228, 387);
            this.bunifuThinButton28.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton28.Name = "bunifuThinButton28";
            this.bunifuThinButton28.Size = new System.Drawing.Size(105, 33);
            this.bunifuThinButton28.TabIndex = 17;
            this.bunifuThinButton28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton28.Click += new System.EventHandler(this.bunifuBtnEkle_Click);
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton25.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "Ürün Ekleme";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton25.Location = new System.Drawing.Point(295, 24);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(124, 51);
            this.bunifuThinButton25.TabIndex = 14;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Ürün Listele";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton24.Location = new System.Drawing.Point(429, 24);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(124, 51);
            this.bunifuThinButton24.TabIndex = 13;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Satışları Listele";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton23.Location = new System.Drawing.Point(563, 24);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(124, 51);
            this.bunifuThinButton23.TabIndex = 12;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Kategori";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton22.Location = new System.Drawing.Point(704, 24);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(124, 51);
            this.bunifuThinButton22.TabIndex = 11;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Marka";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(838, 24);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(124, 51);
            this.bunifuThinButton21.TabIndex = 10;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuBtnEkle
            // 
            this.bunifuBtnEkle.ActiveBorderThickness = 1;
            this.bunifuBtnEkle.ActiveCornerRadius = 20;
            this.bunifuBtnEkle.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuBtnEkle.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuBtnEkle.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuBtnEkle.BackColor = System.Drawing.Color.Black;
            this.bunifuBtnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuBtnEkle.BackgroundImage")));
            this.bunifuBtnEkle.ButtonText = "Ekle";
            this.bunifuBtnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuBtnEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuBtnEkle.ForeColor = System.Drawing.Color.White;
            this.bunifuBtnEkle.IdleBorderThickness = 1;
            this.bunifuBtnEkle.IdleCornerRadius = 20;
            this.bunifuBtnEkle.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuBtnEkle.IdleForecolor = System.Drawing.Color.White;
            this.bunifuBtnEkle.IdleLineColor = System.Drawing.Color.White;
            this.bunifuBtnEkle.Location = new System.Drawing.Point(228, 383);
            this.bunifuBtnEkle.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuBtnEkle.Name = "bunifuBtnEkle";
            this.bunifuBtnEkle.Size = new System.Drawing.Size(105, 33);
            this.bunifuBtnEkle.TabIndex = 17;
            this.bunifuBtnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuBtnEkle.Click += new System.EventHandler(this.bunifuBtnEkle_Click);
            // 
            // bunifuBtnSatısYap
            // 
            this.bunifuBtnSatısYap.ActiveBorderThickness = 1;
            this.bunifuBtnSatısYap.ActiveCornerRadius = 20;
            this.bunifuBtnSatısYap.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuBtnSatısYap.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuBtnSatısYap.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuBtnSatısYap.BackColor = System.Drawing.Color.Black;
            this.bunifuBtnSatısYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuBtnSatısYap.BackgroundImage")));
            this.bunifuBtnSatısYap.ButtonText = "Satış Yap";
            this.bunifuBtnSatısYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuBtnSatısYap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuBtnSatısYap.ForeColor = System.Drawing.Color.White;
            this.bunifuBtnSatısYap.IdleBorderThickness = 1;
            this.bunifuBtnSatısYap.IdleCornerRadius = 20;
            this.bunifuBtnSatısYap.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuBtnSatısYap.IdleForecolor = System.Drawing.Color.White;
            this.bunifuBtnSatısYap.IdleLineColor = System.Drawing.Color.White;
            this.bunifuBtnSatısYap.Location = new System.Drawing.Point(787, 383);
            this.bunifuBtnSatısYap.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuBtnSatısYap.Name = "bunifuBtnSatısYap";
            this.bunifuBtnSatısYap.Size = new System.Drawing.Size(103, 33);
            this.bunifuBtnSatısYap.TabIndex = 18;
            this.bunifuBtnSatısYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuBtnSatısYap.Click += new System.EventHandler(this.bunifuBtnSatısYap_Click);
            // 
            // bunifuBtnSil
            // 
            this.bunifuBtnSil.ActiveBorderThickness = 1;
            this.bunifuBtnSil.ActiveCornerRadius = 20;
            this.bunifuBtnSil.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuBtnSil.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuBtnSil.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuBtnSil.BackColor = System.Drawing.Color.Black;
            this.bunifuBtnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuBtnSil.BackgroundImage")));
            this.bunifuBtnSil.ButtonText = "Sil";
            this.bunifuBtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuBtnSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuBtnSil.ForeColor = System.Drawing.Color.White;
            this.bunifuBtnSil.IdleBorderThickness = 1;
            this.bunifuBtnSil.IdleCornerRadius = 20;
            this.bunifuBtnSil.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuBtnSil.IdleForecolor = System.Drawing.Color.White;
            this.bunifuBtnSil.IdleLineColor = System.Drawing.Color.White;
            this.bunifuBtnSil.Location = new System.Drawing.Point(898, 133);
            this.bunifuBtnSil.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuBtnSil.Name = "bunifuBtnSil";
            this.bunifuBtnSil.Size = new System.Drawing.Size(94, 36);
            this.bunifuBtnSil.TabIndex = 19;
            this.bunifuBtnSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuBtnSil.Click += new System.EventHandler(this.bunifuThinButton28_Click);
            // 
            // bunifuBtnSatısİptal
            // 
            this.bunifuBtnSatısİptal.ActiveBorderThickness = 1;
            this.bunifuBtnSatısİptal.ActiveCornerRadius = 20;
            this.bunifuBtnSatısİptal.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuBtnSatısİptal.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuBtnSatısİptal.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuBtnSatısİptal.BackColor = System.Drawing.Color.Black;
            this.bunifuBtnSatısİptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuBtnSatısİptal.BackgroundImage")));
            this.bunifuBtnSatısİptal.ButtonText = "Satış İptal";
            this.bunifuBtnSatısİptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuBtnSatısİptal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuBtnSatısİptal.ForeColor = System.Drawing.Color.White;
            this.bunifuBtnSatısİptal.IdleBorderThickness = 1;
            this.bunifuBtnSatısİptal.IdleCornerRadius = 20;
            this.bunifuBtnSatısİptal.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuBtnSatısİptal.IdleForecolor = System.Drawing.Color.White;
            this.bunifuBtnSatısİptal.IdleLineColor = System.Drawing.Color.White;
            this.bunifuBtnSatısİptal.Location = new System.Drawing.Point(898, 168);
            this.bunifuBtnSatısİptal.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuBtnSatısİptal.Name = "bunifuBtnSatısİptal";
            this.bunifuBtnSatısİptal.Size = new System.Drawing.Size(94, 36);
            this.bunifuBtnSatısİptal.TabIndex = 20;
            this.bunifuBtnSatısİptal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuBtnSatısİptal.Click += new System.EventHandler(this.bunifuThinButton29_Click);
            // 
            // frmsatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(992, 521);
            this.Controls.Add(this.bunifuBtnSatısİptal);
            this.Controls.Add(this.bunifuBtnSil);
            this.Controls.Add(this.bunifuBtnSatısYap);
            this.Controls.Add(this.bunifuBtnEkle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmsatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmsatis_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmsatis_FormClosed);
            this.Load += new System.EventHandler(this.frmsatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.TextBox txtSatışFiyatı;
        private System.Windows.Forms.TextBox txtÜrünMiktarı;
        private System.Windows.Forms.TextBox txtÜrünAdı;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton26;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton27;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuBtnEkle;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuBtnSatısYap;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuBtnSil;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuBtnSatısİptal;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton211;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton210;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton29;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton28;
    }
}

