namespace OtelRezervasyonSistemi.UI
{
    partial class MusteriIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriIslemleri));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.musteriIsimtxt = new System.Windows.Forms.TextBox();
            this.musteriSoyisimtxt = new System.Windows.Forms.TextBox();
            this.musteriTCtxt = new System.Windows.Forms.TextBox();
            this.musteriGridView = new System.Windows.Forms.DataGridView();
            this.musteriTeltxt = new System.Windows.Forms.TextBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.pictureBoxGeri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.musteriGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri İsim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Müşteri Soyisim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Müşteri TC Kimlik:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Müşteri Telefon No:";
            // 
            // musteriIsimtxt
            // 
            this.musteriIsimtxt.Location = new System.Drawing.Point(221, 60);
            this.musteriIsimtxt.Name = "musteriIsimtxt";
            this.musteriIsimtxt.Size = new System.Drawing.Size(100, 22);
            this.musteriIsimtxt.TabIndex = 7;
            this.musteriIsimtxt.TextChanged += new System.EventHandler(this.musteriIsimtxt_TextChanged);
            // 
            // musteriSoyisimtxt
            // 
            this.musteriSoyisimtxt.Location = new System.Drawing.Point(221, 123);
            this.musteriSoyisimtxt.Name = "musteriSoyisimtxt";
            this.musteriSoyisimtxt.Size = new System.Drawing.Size(100, 22);
            this.musteriSoyisimtxt.TabIndex = 8;
            this.musteriSoyisimtxt.TextChanged += new System.EventHandler(this.musteriSoyisimtxt_TextChanged);
            // 
            // musteriTCtxt
            // 
            this.musteriTCtxt.Location = new System.Drawing.Point(651, 60);
            this.musteriTCtxt.Name = "musteriTCtxt";
            this.musteriTCtxt.Size = new System.Drawing.Size(100, 22);
            this.musteriTCtxt.TabIndex = 9;
            this.musteriTCtxt.TextChanged += new System.EventHandler(this.musteriTCtxt_TextChanged);
            // 
            // musteriGridView
            // 
            this.musteriGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriGridView.Location = new System.Drawing.Point(79, 269);
            this.musteriGridView.Name = "musteriGridView";
            this.musteriGridView.RowHeadersWidth = 51;
            this.musteriGridView.RowTemplate.Height = 24;
            this.musteriGridView.Size = new System.Drawing.Size(892, 268);
            this.musteriGridView.TabIndex = 11;
            this.musteriGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriGridView_CellContentClick);
            // 
            // musteriTeltxt
            // 
            this.musteriTeltxt.Location = new System.Drawing.Point(651, 120);
            this.musteriTeltxt.Name = "musteriTeltxt";
            this.musteriTeltxt.Size = new System.Drawing.Size(100, 22);
            this.musteriTeltxt.TabIndex = 12;
            this.musteriTeltxt.TextChanged += new System.EventHandler(this.musteriTeltxt_TextChanged);
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(173, 209);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(148, 27);
            this.ekleBtn.TabIndex = 13;
            this.ekleBtn.Text = "Kaydet";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(402, 213);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(148, 27);
            this.silBtn.TabIndex = 14;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(651, 217);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(148, 23);
            this.guncelleBtn.TabIndex = 15;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // pictureBoxGeri
            // 
            this.pictureBoxGeri.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGeri.Image")));
            this.pictureBoxGeri.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxGeri.Name = "pictureBoxGeri";
            this.pictureBoxGeri.Size = new System.Drawing.Size(40, 38);
            this.pictureBoxGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGeri.TabIndex = 16;
            this.pictureBoxGeri.TabStop = false;
            this.pictureBoxGeri.Click += new System.EventHandler(this.pictureBoxGeri_Click);
            // 
            // MusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1066, 549);
            this.Controls.Add(this.pictureBoxGeri);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.musteriTeltxt);
            this.Controls.Add(this.musteriGridView);
            this.Controls.Add(this.musteriTCtxt);
            this.Controls.Add(this.musteriSoyisimtxt);
            this.Controls.Add(this.musteriIsimtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MusteriIslemleri";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MusteriIslemleri";
            this.Load += new System.EventHandler(this.MusteriIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox musteriIsimtxt;
        private System.Windows.Forms.TextBox musteriSoyisimtxt;
        private System.Windows.Forms.TextBox musteriTCtxt;
        private System.Windows.Forms.DataGridView musteriGridView;
        private System.Windows.Forms.TextBox musteriTeltxt;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.PictureBox pictureBoxGeri;
    }
}