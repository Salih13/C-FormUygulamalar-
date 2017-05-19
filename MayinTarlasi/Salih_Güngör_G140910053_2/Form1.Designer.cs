namespace Salih_Güngör_G140910053_2
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_yeniOyun = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_bombaSayisi = new System.Windows.Forms.NumericUpDown();
            this.txt_skor = new System.Windows.Forms.TextBox();
            this.txt_sure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num_mayinSayisi = new System.Windows.Forms.NumericUpDown();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer_sure = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_bombaSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_mayinSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.btn_cikis);
            this.panel2.Controls.Add(this.btn_yeniOyun);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.num_bombaSayisi);
            this.panel2.Controls.Add(this.txt_skor);
            this.panel2.Controls.Add(this.txt_sure);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.num_mayinSayisi);
            this.panel2.Controls.Add(this.btn_baslat);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(561, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 361);
            this.panel2.TabIndex = 0;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(86, 307);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(83, 37);
            this.btn_cikis.TabIndex = 11;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_yeniOyun
            // 
            this.btn_yeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeniOyun.Location = new System.Drawing.Point(42, 127);
            this.btn_yeniOyun.Name = "btn_yeniOyun";
            this.btn_yeniOyun.Size = new System.Drawing.Size(93, 37);
            this.btn_yeniOyun.TabIndex = 10;
            this.btn_yeniOyun.Text = "Yeni Oyun";
            this.btn_yeniOyun.UseVisualStyleBackColor = true;
            this.btn_yeniOyun.Click += new System.EventHandler(this.btn_yeniOyun_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(44, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bomba Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mayın Sayısı";
            // 
            // num_bombaSayisi
            // 
            this.num_bombaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.num_bombaSayisi.Location = new System.Drawing.Point(54, 268);
            this.num_bombaSayisi.Name = "num_bombaSayisi";
            this.num_bombaSayisi.Size = new System.Drawing.Size(71, 26);
            this.num_bombaSayisi.TabIndex = 3;
            this.num_bombaSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_skor
            // 
            this.txt_skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_skor.Location = new System.Drawing.Point(80, 73);
            this.txt_skor.Name = "txt_skor";
            this.txt_skor.ReadOnly = true;
            this.txt_skor.Size = new System.Drawing.Size(70, 27);
            this.txt_skor.TabIndex = 1;
            this.txt_skor.TabStop = false;
            this.txt_skor.Text = "0";
            this.txt_skor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_sure
            // 
            this.txt_sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sure.Location = new System.Drawing.Point(80, 28);
            this.txt_sure.Name = "txt_sure";
            this.txt_sure.ReadOnly = true;
            this.txt_sure.Size = new System.Drawing.Size(70, 27);
            this.txt_sure.TabIndex = 0;
            this.txt_sure.TabStop = false;
            this.txt_sure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Skor";
            // 
            // num_mayinSayisi
            // 
            this.num_mayinSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.num_mayinSayisi.Location = new System.Drawing.Point(54, 204);
            this.num_mayinSayisi.Name = "num_mayinSayisi";
            this.num_mayinSayisi.Size = new System.Drawing.Size(71, 26);
            this.num_mayinSayisi.TabIndex = 2;
            this.num_mayinSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_baslat
            // 
            this.btn_baslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_baslat.Location = new System.Drawing.Point(4, 307);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(83, 37);
            this.btn_baslat.TabIndex = 4;
            this.btn_baslat.Text = "Başlat";
            this.btn_baslat.UseVisualStyleBackColor = true;
            this.btn_baslat.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Süre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(560, 361);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // timer_sure
            // 
            this.timer_sure.Interval = 1000;
            this.timer_sure.Tick += new System.EventHandler(this.timer_sure_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Mayın Tarlası";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_bombaSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_mayinSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_baslat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txt_skor;
        private System.Windows.Forms.TextBox txt_sure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_sure;
        private System.Windows.Forms.NumericUpDown num_mayinSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_bombaSayisi;
        private System.Windows.Forms.Button btn_yeniOyun;
        private System.Windows.Forms.Button btn_cikis;
    }
}

