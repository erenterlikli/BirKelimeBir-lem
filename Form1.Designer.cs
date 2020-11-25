namespace BirKelimeBirİşlem
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnHarf1 = new System.Windows.Forms.Button();
            this.BtnHarf2 = new System.Windows.Forms.Button();
            this.BtnHarf3 = new System.Windows.Forms.Button();
            this.BtnHarf4 = new System.Windows.Forms.Button();
            this.BtnHarf5 = new System.Windows.Forms.Button();
            this.BtnHarf6 = new System.Windows.Forms.Button();
            this.BtnHarf7 = new System.Windows.Forms.Button();
            this.BtnHarf8 = new System.Windows.Forms.Button();
            this.BtnSoru = new System.Windows.Forms.Button();
            this.BtnEsittir = new System.Windows.Forms.Button();
            this.BtnSayı5 = new System.Windows.Forms.Button();
            this.BtnSayı4 = new System.Windows.Forms.Button();
            this.BtnSayı3 = new System.Windows.Forms.Button();
            this.BtnSayı2 = new System.Windows.Forms.Button();
            this.BtnSayı1 = new System.Windows.Forms.Button();
            this.BtnHarfUret = new System.Windows.Forms.Button();
            this.BtnSayıÜret = new System.Windows.Forms.Button();
            this.BtnJoker = new System.Windows.Forms.Button();
            this.BtnSayı6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.BtnJoker);
            this.groupBox1.Controls.Add(this.BtnHarfUret);
            this.groupBox1.Controls.Add(this.BtnHarf8);
            this.groupBox1.Controls.Add(this.BtnHarf7);
            this.groupBox1.Controls.Add(this.BtnHarf6);
            this.groupBox1.Controls.Add(this.BtnHarf5);
            this.groupBox1.Controls.Add(this.BtnHarf4);
            this.groupBox1.Controls.Add(this.BtnHarf3);
            this.groupBox1.Controls.Add(this.BtnHarf2);
            this.groupBox1.Controls.Add(this.BtnHarf1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(27, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bir Kelime";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.BtnSayı6);
            this.groupBox2.Controls.Add(this.BtnSayıÜret);
            this.groupBox2.Controls.Add(this.BtnSoru);
            this.groupBox2.Controls.Add(this.BtnEsittir);
            this.groupBox2.Controls.Add(this.BtnSayı5);
            this.groupBox2.Controls.Add(this.BtnSayı4);
            this.groupBox2.Controls.Add(this.BtnSayı3);
            this.groupBox2.Controls.Add(this.BtnSayı2);
            this.groupBox2.Controls.Add(this.BtnSayı1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(26, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bir İşlem";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(314, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yeni Oyun Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnHarf1
            // 
            this.BtnHarf1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHarf1.Location = new System.Drawing.Point(19, 67);
            this.BtnHarf1.Name = "BtnHarf1";
            this.BtnHarf1.Size = new System.Drawing.Size(64, 52);
            this.BtnHarf1.TabIndex = 0;
            this.BtnHarf1.UseVisualStyleBackColor = true;
            this.BtnHarf1.Visible = false;
            // 
            // BtnHarf2
            // 
            this.BtnHarf2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHarf2.Location = new System.Drawing.Point(99, 67);
            this.BtnHarf2.Name = "BtnHarf2";
            this.BtnHarf2.Size = new System.Drawing.Size(64, 52);
            this.BtnHarf2.TabIndex = 1;
            this.BtnHarf2.UseVisualStyleBackColor = true;
            this.BtnHarf2.Visible = false;
            // 
            // BtnHarf3
            // 
            this.BtnHarf3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHarf3.Location = new System.Drawing.Point(179, 67);
            this.BtnHarf3.Name = "BtnHarf3";
            this.BtnHarf3.Size = new System.Drawing.Size(64, 52);
            this.BtnHarf3.TabIndex = 2;
            this.BtnHarf3.UseVisualStyleBackColor = true;
            this.BtnHarf3.Visible = false;
            // 
            // BtnHarf4
            // 
            this.BtnHarf4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHarf4.Location = new System.Drawing.Point(259, 67);
            this.BtnHarf4.Name = "BtnHarf4";
            this.BtnHarf4.Size = new System.Drawing.Size(64, 52);
            this.BtnHarf4.TabIndex = 3;
            this.BtnHarf4.UseVisualStyleBackColor = true;
            this.BtnHarf4.Visible = false;
            // 
            // BtnHarf5
            // 
            this.BtnHarf5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHarf5.Location = new System.Drawing.Point(339, 67);
            this.BtnHarf5.Name = "BtnHarf5";
            this.BtnHarf5.Size = new System.Drawing.Size(64, 52);
            this.BtnHarf5.TabIndex = 4;
            this.BtnHarf5.UseVisualStyleBackColor = true;
            this.BtnHarf5.Visible = false;
            // 
            // BtnHarf6
            // 
            this.BtnHarf6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHarf6.Location = new System.Drawing.Point(419, 67);
            this.BtnHarf6.Name = "BtnHarf6";
            this.BtnHarf6.Size = new System.Drawing.Size(64, 52);
            this.BtnHarf6.TabIndex = 5;
            this.BtnHarf6.UseVisualStyleBackColor = true;
            this.BtnHarf6.Visible = false;
            // 
            // BtnHarf7
            // 
            this.BtnHarf7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHarf7.Location = new System.Drawing.Point(504, 67);
            this.BtnHarf7.Name = "BtnHarf7";
            this.BtnHarf7.Size = new System.Drawing.Size(64, 52);
            this.BtnHarf7.TabIndex = 6;
            this.BtnHarf7.UseVisualStyleBackColor = true;
            this.BtnHarf7.Visible = false;
            // 
            // BtnHarf8
            // 
            this.BtnHarf8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHarf8.Location = new System.Drawing.Point(589, 67);
            this.BtnHarf8.Name = "BtnHarf8";
            this.BtnHarf8.Size = new System.Drawing.Size(64, 52);
            this.BtnHarf8.TabIndex = 7;
            this.BtnHarf8.UseVisualStyleBackColor = true;
            this.BtnHarf8.Visible = false;
            // 
            // BtnSoru
            // 
            this.BtnSoru.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSoru.Location = new System.Drawing.Point(587, 77);
            this.BtnSoru.Name = "BtnSoru";
            this.BtnSoru.Size = new System.Drawing.Size(149, 52);
            this.BtnSoru.TabIndex = 14;
            this.BtnSoru.UseVisualStyleBackColor = true;
            this.BtnSoru.Visible = false;
            // 
            // BtnEsittir
            // 
            this.BtnEsittir.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEsittir.Location = new System.Drawing.Point(505, 77);
            this.BtnEsittir.Name = "BtnEsittir";
            this.BtnEsittir.Size = new System.Drawing.Size(64, 52);
            this.BtnEsittir.TabIndex = 13;
            this.BtnEsittir.Text = "=";
            this.BtnEsittir.UseVisualStyleBackColor = true;
            this.BtnEsittir.Visible = false;
            // 
            // BtnSayı5
            // 
            this.BtnSayı5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSayı5.Location = new System.Drawing.Point(342, 77);
            this.BtnSayı5.Name = "BtnSayı5";
            this.BtnSayı5.Size = new System.Drawing.Size(64, 52);
            this.BtnSayı5.TabIndex = 12;
            this.BtnSayı5.UseVisualStyleBackColor = true;
            this.BtnSayı5.Visible = false;
            // 
            // BtnSayı4
            // 
            this.BtnSayı4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSayı4.Location = new System.Drawing.Point(262, 77);
            this.BtnSayı4.Name = "BtnSayı4";
            this.BtnSayı4.Size = new System.Drawing.Size(64, 52);
            this.BtnSayı4.TabIndex = 11;
            this.BtnSayı4.UseVisualStyleBackColor = true;
            this.BtnSayı4.Visible = false;
            // 
            // BtnSayı3
            // 
            this.BtnSayı3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSayı3.Location = new System.Drawing.Point(182, 77);
            this.BtnSayı3.Name = "BtnSayı3";
            this.BtnSayı3.Size = new System.Drawing.Size(64, 52);
            this.BtnSayı3.TabIndex = 10;
            this.BtnSayı3.UseVisualStyleBackColor = true;
            this.BtnSayı3.Visible = false;
            // 
            // BtnSayı2
            // 
            this.BtnSayı2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSayı2.Location = new System.Drawing.Point(102, 77);
            this.BtnSayı2.Name = "BtnSayı2";
            this.BtnSayı2.Size = new System.Drawing.Size(64, 52);
            this.BtnSayı2.TabIndex = 9;
            this.BtnSayı2.UseVisualStyleBackColor = true;
            this.BtnSayı2.Visible = false;
            // 
            // BtnSayı1
            // 
            this.BtnSayı1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSayı1.Location = new System.Drawing.Point(22, 77);
            this.BtnSayı1.Name = "BtnSayı1";
            this.BtnSayı1.Size = new System.Drawing.Size(64, 52);
            this.BtnSayı1.TabIndex = 8;
            this.BtnSayı1.UseVisualStyleBackColor = true;
            this.BtnSayı1.Visible = false;
            // 
            // BtnHarfUret
            // 
            this.BtnHarfUret.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHarfUret.Location = new System.Drawing.Point(303, 142);
            this.BtnHarfUret.Name = "BtnHarfUret";
            this.BtnHarfUret.Size = new System.Drawing.Size(140, 36);
            this.BtnHarfUret.TabIndex = 8;
            this.BtnHarfUret.Text = "Harf Üret";
            this.BtnHarfUret.UseVisualStyleBackColor = true;
            this.BtnHarfUret.Click += new System.EventHandler(this.BtnHarfUret_Click);
            // 
            // BtnSayıÜret
            // 
            this.BtnSayıÜret.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSayıÜret.Location = new System.Drawing.Point(304, 150);
            this.BtnSayıÜret.Name = "BtnSayıÜret";
            this.BtnSayıÜret.Size = new System.Drawing.Size(140, 36);
            this.BtnSayıÜret.TabIndex = 9;
            this.BtnSayıÜret.Text = "Sayı Üret";
            this.BtnSayıÜret.UseVisualStyleBackColor = true;
            this.BtnSayıÜret.Click += new System.EventHandler(this.BtnSayıÜret_Click);
            // 
            // BtnJoker
            // 
            this.BtnJoker.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnJoker.Location = new System.Drawing.Point(671, 67);
            this.BtnJoker.Name = "BtnJoker";
            this.BtnJoker.Size = new System.Drawing.Size(64, 52);
            this.BtnJoker.TabIndex = 9;
            this.BtnJoker.UseVisualStyleBackColor = true;
            this.BtnJoker.Visible = false;
            // 
            // BtnSayı6
            // 
            this.BtnSayı6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSayı6.Location = new System.Drawing.Point(420, 77);
            this.BtnSayı6.Name = "BtnSayı6";
            this.BtnSayı6.Size = new System.Drawing.Size(64, 52);
            this.BtnSayı6.TabIndex = 15;
            this.BtnSayı6.UseVisualStyleBackColor = true;
            this.BtnSayı6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(803, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Bir Kelime Bir İşlem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnHarfUret;
        private System.Windows.Forms.Button BtnHarf8;
        private System.Windows.Forms.Button BtnHarf7;
        private System.Windows.Forms.Button BtnHarf6;
        private System.Windows.Forms.Button BtnHarf5;
        private System.Windows.Forms.Button BtnHarf4;
        private System.Windows.Forms.Button BtnHarf3;
        private System.Windows.Forms.Button BtnHarf2;
        private System.Windows.Forms.Button BtnHarf1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSayıÜret;
        private System.Windows.Forms.Button BtnSoru;
        private System.Windows.Forms.Button BtnEsittir;
        private System.Windows.Forms.Button BtnSayı5;
        private System.Windows.Forms.Button BtnSayı4;
        private System.Windows.Forms.Button BtnSayı3;
        private System.Windows.Forms.Button BtnSayı2;
        private System.Windows.Forms.Button BtnSayı1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnJoker;
        private System.Windows.Forms.Button BtnSayı6;
    }
}

