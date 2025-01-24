namespace OtelRezervasyonSistemi.UI
{
    partial class RezervasyonIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonIslemleri));
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.giristarDTP = new System.Windows.Forms.DateTimePicker();
            this.cikistarDTP = new System.Windows.Forms.DateTimePicker();
            this.RezervasyondataGrid = new System.Windows.Forms.DataGridView();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.musteritc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBoxOdaid = new System.Windows.Forms.ComboBox();
            this.comboBoxMusteritc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RezervasyondataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Oda ID Seç";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giriş Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Çıkış Tarihi:";
            // 
            // giristarDTP
            // 
            this.giristarDTP.Location = new System.Drawing.Point(612, 77);
            this.giristarDTP.Name = "giristarDTP";
            this.giristarDTP.Size = new System.Drawing.Size(200, 22);
            this.giristarDTP.TabIndex = 12;
            // 
            // cikistarDTP
            // 
            this.cikistarDTP.Location = new System.Drawing.Point(612, 134);
            this.cikistarDTP.Name = "cikistarDTP";
            this.cikistarDTP.Size = new System.Drawing.Size(200, 22);
            this.cikistarDTP.TabIndex = 13;
            // 
            // RezervasyondataGrid
            // 
            this.RezervasyondataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RezervasyondataGrid.Location = new System.Drawing.Point(12, 237);
            this.RezervasyondataGrid.Name = "RezervasyondataGrid";
            this.RezervasyondataGrid.RowHeadersWidth = 51;
            this.RezervasyondataGrid.RowTemplate.Height = 24;
            this.RezervasyondataGrid.Size = new System.Drawing.Size(1042, 300);
            this.RezervasyondataGrid.TabIndex = 14;
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Location = new System.Drawing.Point(612, 191);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetBtn.TabIndex = 15;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(722, 190);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(75, 23);
            this.silBtn.TabIndex = 16;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(847, 191);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(75, 23);
            this.guncelleBtn.TabIndex = 17;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            // 
            // musteritc
            // 
            this.musteritc.AutoSize = true;
            this.musteritc.Location = new System.Drawing.Point(126, 93);
            this.musteritc.Name = "musteritc";
            this.musteritc.Size = new System.Drawing.Size(71, 16);
            this.musteritc.TabIndex = 18;
            this.musteritc.Text = "Müşteri TC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1014, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // comboBoxOdaid
            // 
            this.comboBoxOdaid.FormattingEnabled = true;
            this.comboBoxOdaid.Location = new System.Drawing.Point(251, 132);
            this.comboBoxOdaid.Name = "comboBoxOdaid";
            this.comboBoxOdaid.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOdaid.TabIndex = 24;
            // 
            // comboBoxMusteritc
            // 
            this.comboBoxMusteritc.FormattingEnabled = true;
            this.comboBoxMusteritc.Location = new System.Drawing.Point(251, 85);
            this.comboBoxMusteritc.Name = "comboBoxMusteritc";
            this.comboBoxMusteritc.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMusteritc.TabIndex = 25;
            this.comboBoxMusteritc.SelectedIndexChanged += new System.EventHandler(this.comboBoxMusteritc_SelectedIndexChanged);
            // 
            // RezervasyonIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1066, 549);
            this.Controls.Add(this.comboBoxMusteritc);
            this.Controls.Add(this.comboBoxOdaid);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.musteritc);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.RezervasyondataGrid);
            this.Controls.Add(this.cikistarDTP);
            this.Controls.Add(this.giristarDTP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Name = "RezervasyonIslemleri";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RezervasyonIslemleri";
            this.Load += new System.EventHandler(this.RezervasyonIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RezervasyondataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker giristarDTP;
        private System.Windows.Forms.DateTimePicker cikistarDTP;
        private System.Windows.Forms.DataGridView RezervasyondataGrid;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Label musteritc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBoxOdaid;
        private System.Windows.Forms.ComboBox comboBoxMusteritc;
    }
}