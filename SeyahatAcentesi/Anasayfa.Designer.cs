namespace SeyahatAcentesi
{
    partial class Giris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_UyeGirisi = new System.Windows.Forms.Button();
            this.btn_AdminGirisi = new System.Windows.Forms.Button();
            this.btn_KayitOl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(315, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turkuaz Seyahat\'e Hoşgeldiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_UyeGirisi
            // 
            this.btn_UyeGirisi.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_UyeGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UyeGirisi.Font = new System.Drawing.Font("Yanone Kaffeesatz", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_UyeGirisi.ForeColor = System.Drawing.Color.White;
            this.btn_UyeGirisi.Location = new System.Drawing.Point(211, 13);
            this.btn_UyeGirisi.Name = "btn_UyeGirisi";
            this.btn_UyeGirisi.Size = new System.Drawing.Size(202, 64);
            this.btn_UyeGirisi.TabIndex = 1;
            this.btn_UyeGirisi.Text = "Üye Girişi";
            this.btn_UyeGirisi.UseVisualStyleBackColor = false;
            this.btn_UyeGirisi.Click += new System.EventHandler(this.btn_UyeGirisi_Click);
            // 
            // btn_AdminGirisi
            // 
            this.btn_AdminGirisi.BackColor = System.Drawing.Color.Khaki;
            this.btn_AdminGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AdminGirisi.Font = new System.Drawing.Font("Yanone Kaffeesatz", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AdminGirisi.ForeColor = System.Drawing.Color.White;
            this.btn_AdminGirisi.Location = new System.Drawing.Point(420, 13);
            this.btn_AdminGirisi.Name = "btn_AdminGirisi";
            this.btn_AdminGirisi.Size = new System.Drawing.Size(202, 64);
            this.btn_AdminGirisi.TabIndex = 2;
            this.btn_AdminGirisi.Text = "Admin Girişi";
            this.btn_AdminGirisi.UseVisualStyleBackColor = false;
            this.btn_AdminGirisi.Click += new System.EventHandler(this.btn_AdminGirisi_Click);
            // 
            // btn_KayitOl
            // 
            this.btn_KayitOl.BackColor = System.Drawing.Color.Brown;
            this.btn_KayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KayitOl.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_KayitOl.Font = new System.Drawing.Font("Yanone Kaffeesatz", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KayitOl.ForeColor = System.Drawing.Color.White;
            this.btn_KayitOl.Location = new System.Drawing.Point(3, 13);
            this.btn_KayitOl.Name = "btn_KayitOl";
            this.btn_KayitOl.Size = new System.Drawing.Size(202, 64);
            this.btn_KayitOl.TabIndex = 3;
            this.btn_KayitOl.Text = "Kayıt Ol";
            this.btn_KayitOl.UseVisualStyleBackColor = false;
            this.btn_KayitOl.Click += new System.EventHandler(this.btn_KayitOl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_AdminGirisi);
            this.panel1.Controls.Add(this.btn_KayitOl);
            this.panel1.Controls.Add(this.btn_UyeGirisi);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 94);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::SeyahatAcentesi.Properties.Resources.galeri2;
            this.pictureBox1.Location = new System.Drawing.Point(319, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_UyeGirisi;
        private System.Windows.Forms.Button btn_AdminGirisi;
        private System.Windows.Forms.Button btn_KayitOl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

