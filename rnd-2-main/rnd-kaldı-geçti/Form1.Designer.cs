namespace rnd_kaldı_geçti
{
    partial class Form1
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
            this.lbNotlar = new System.Windows.Forms.ListBox();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblGecen = new System.Windows.Forms.Label();
            this.lblTesekkur = new System.Windows.Forms.Label();
            this.lblTakdir = new System.Windows.Forms.Label();
            this.btnUret = new System.Windows.Forms.Button();
            this.btnDurum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNotlar
            // 
            this.lbNotlar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbNotlar.FormattingEnabled = true;
            this.lbNotlar.Location = new System.Drawing.Point(12, 12);
            this.lbNotlar.Name = "lbNotlar";
            this.lbNotlar.Size = new System.Drawing.Size(129, 277);
            this.lbNotlar.TabIndex = 0;
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKalan.Location = new System.Drawing.Point(188, 20);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(63, 29);
            this.lblKalan.TabIndex = 1;
            this.lblKalan.Text = "KALDI:";
            // 
            // lblGecen
            // 
            this.lblGecen.AutoSize = true;
            this.lblGecen.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGecen.Location = new System.Drawing.Point(188, 61);
            this.lblGecen.Name = "lblGecen";
            this.lblGecen.Size = new System.Drawing.Size(61, 29);
            this.lblGecen.TabIndex = 2;
            this.lblGecen.Text = "GEÇTİ:";
            // 
            // lblTesekkur
            // 
            this.lblTesekkur.AutoSize = true;
            this.lblTesekkur.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesekkur.Location = new System.Drawing.Point(188, 104);
            this.lblTesekkur.Name = "lblTesekkur";
            this.lblTesekkur.Size = new System.Drawing.Size(139, 29);
            this.lblTesekkur.TabIndex = 3;
            this.lblTesekkur.Text = "TEŞEKKÜR ALDI:";
            // 
            // lblTakdir
            // 
            this.lblTakdir.AutoSize = true;
            this.lblTakdir.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTakdir.Location = new System.Drawing.Point(188, 146);
            this.lblTakdir.Name = "lblTakdir";
            this.lblTakdir.Size = new System.Drawing.Size(114, 29);
            this.lblTakdir.TabIndex = 4;
            this.lblTakdir.Text = "TAKDİR ALDI:";
            // 
            // btnUret
            // 
            this.btnUret.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUret.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUret.Location = new System.Drawing.Point(147, 229);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(114, 45);
            this.btnUret.TabIndex = 5;
            this.btnUret.Text = "ÜRET";
            this.btnUret.UseVisualStyleBackColor = false;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // btnDurum
            // 
            this.btnDurum.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDurum.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDurum.Location = new System.Drawing.Point(287, 229);
            this.btnDurum.Name = "btnDurum";
            this.btnDurum.Size = new System.Drawing.Size(114, 45);
            this.btnDurum.TabIndex = 6;
            this.btnDurum.Text = "ORTALAMA";
            this.btnDurum.UseVisualStyleBackColor = false;
            this.btnDurum.Click += new System.EventHandler(this.btnDurum_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(608, 324);
            this.Controls.Add(this.btnDurum);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.lblTakdir);
            this.Controls.Add(this.lblTesekkur);
            this.Controls.Add(this.lblGecen);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.lbNotlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNotlar;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label lblGecen;
        private System.Windows.Forms.Label lblTesekkur;
        private System.Windows.Forms.Label lblTakdir;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Button btnDurum;
    }
}

