namespace OtelRezervasyonSistemi.UI
{
    partial class OdaIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaIslemleri));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.odaisimtxt = new System.Windows.Forms.TextBox();
            this.odafiyattxt = new System.Windows.Forms.TextBox();
            this.odatiptxt = new System.Windows.Forms.TextBox();
            this.dataGridViewoda = new System.Windows.Forms.DataGridView();
            this.odasilbtn = new System.Windows.Forms.Button();
            this.odaguncellebtn = new System.Windows.Forms.Button();
            this.odakaydetbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oda İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oda Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Oda Tip";
            // 
            // odaisimtxt
            // 
            this.odaisimtxt.Location = new System.Drawing.Point(235, 71);
            this.odaisimtxt.Name = "odaisimtxt";
            this.odaisimtxt.Size = new System.Drawing.Size(100, 22);
            this.odaisimtxt.TabIndex = 6;
            // 
            // odafiyattxt
            // 
            this.odafiyattxt.Location = new System.Drawing.Point(504, 71);
            this.odafiyattxt.Name = "odafiyattxt";
            this.odafiyattxt.Size = new System.Drawing.Size(100, 22);
            this.odafiyattxt.TabIndex = 7;
            // 
            // odatiptxt
            // 
            this.odatiptxt.Location = new System.Drawing.Point(760, 71);
            this.odatiptxt.Name = "odatiptxt";
            this.odatiptxt.Size = new System.Drawing.Size(100, 22);
            this.odatiptxt.TabIndex = 8;
            // 
            // dataGridViewoda
            // 
            this.dataGridViewoda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewoda.Location = new System.Drawing.Point(120, 210);
            this.dataGridViewoda.Name = "dataGridViewoda";
            this.dataGridViewoda.RowHeadersWidth = 51;
            this.dataGridViewoda.RowTemplate.Height = 24;
            this.dataGridViewoda.Size = new System.Drawing.Size(740, 283);
            this.dataGridViewoda.TabIndex = 9;
            // 
            // odasilbtn
            // 
            this.odasilbtn.Location = new System.Drawing.Point(412, 142);
            this.odasilbtn.Name = "odasilbtn";
            this.odasilbtn.Size = new System.Drawing.Size(148, 27);
            this.odasilbtn.TabIndex = 10;
            this.odasilbtn.Text = "Sil";
            this.odasilbtn.UseVisualStyleBackColor = true;
            this.odasilbtn.Click += new System.EventHandler(this.odasilbtn_Click);
            // 
            // odaguncellebtn
            // 
            this.odaguncellebtn.Location = new System.Drawing.Point(652, 142);
            this.odaguncellebtn.Name = "odaguncellebtn";
            this.odaguncellebtn.Size = new System.Drawing.Size(148, 27);
            this.odaguncellebtn.TabIndex = 11;
            this.odaguncellebtn.Text = "Güncelle";
            this.odaguncellebtn.UseVisualStyleBackColor = true;
            this.odaguncellebtn.Click += new System.EventHandler(this.odaguncellebtn_Click);
            // 
            // odakaydetbtn
            // 
            this.odakaydetbtn.Location = new System.Drawing.Point(187, 142);
            this.odakaydetbtn.Name = "odakaydetbtn";
            this.odakaydetbtn.Size = new System.Drawing.Size(148, 27);
            this.odakaydetbtn.TabIndex = 12;
            this.odakaydetbtn.Text = "Kaydet";
            this.odakaydetbtn.UseVisualStyleBackColor = true;
            this.odakaydetbtn.Click += new System.EventHandler(this.odakaydetbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OdaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1066, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewoda);
            this.Controls.Add(this.odakaydetbtn);
            this.Controls.Add(this.odaguncellebtn);
            this.Controls.Add(this.odasilbtn);
            this.Controls.Add(this.odatiptxt);
            this.Controls.Add(this.odafiyattxt);
            this.Controls.Add(this.odaisimtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OdaIslemleri";
            this.Text = "OdaIslemleri";
            this.Load += new System.EventHandler(this.OdaIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox odaisimtxt;
        private System.Windows.Forms.TextBox odafiyattxt;
        private System.Windows.Forms.TextBox odatiptxt;
        private System.Windows.Forms.DataGridView dataGridViewoda;
        private System.Windows.Forms.Button odasilbtn;
        private System.Windows.Forms.Button odaguncellebtn;
        private System.Windows.Forms.Button odakaydetbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}