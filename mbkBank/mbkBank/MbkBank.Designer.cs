namespace mbkBank
{
    partial class MbkBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MbkBank));
            this.cbBozukPara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kalanHacim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbKagitPara = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonKatla = new System.Windows.Forms.Button();
            this.buttonKir = new System.Windows.Forms.Button();
            this.buttonParaAt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.toplamPara = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBozukPara
            // 
            this.cbBozukPara.DropDownHeight = 100;
            this.cbBozukPara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBozukPara.DropDownWidth = 150;
            this.cbBozukPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBozukPara.FormattingEnabled = true;
            this.cbBozukPara.IntegralHeight = false;
            this.cbBozukPara.Location = new System.Drawing.Point(124, 212);
            this.cbBozukPara.Name = "cbBozukPara";
            this.cbBozukPara.Size = new System.Drawing.Size(118, 28);
            this.cbBozukPara.TabIndex = 1;
            this.cbBozukPara.SelectedIndexChanged += new System.EventHandler(this.cbBozukPara_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "MbkBank\'a Hoşgeldiniz.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(911, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklamalar";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(915, 543);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 200);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // kalanHacim
            // 
            this.kalanHacim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kalanHacim.Location = new System.Drawing.Point(591, 145);
            this.kalanHacim.Name = "kalanHacim";
            this.kalanHacim.ReadOnly = true;
            this.kalanHacim.Size = new System.Drawing.Size(100, 26);
            this.kalanHacim.TabIndex = 5;
            this.kalanHacim.TextChanged += new System.EventHandler(this.kalanHacim_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(471, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kalan Hacim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bozuk Para:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbKagitPara
            // 
            this.cbKagitPara.DropDownHeight = 100;
            this.cbKagitPara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKagitPara.DropDownWidth = 150;
            this.cbKagitPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKagitPara.FormattingEnabled = true;
            this.cbKagitPara.IntegralHeight = false;
            this.cbKagitPara.Location = new System.Drawing.Point(124, 266);
            this.cbKagitPara.Name = "cbKagitPara";
            this.cbKagitPara.Size = new System.Drawing.Size(118, 28);
            this.cbKagitPara.TabIndex = 8;
            this.cbKagitPara.SelectedIndexChanged += new System.EventHandler(this.cbKagitPara_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kağıt Para:";
            // 
            // buttonKatla
            // 
            this.buttonKatla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKatla.Location = new System.Drawing.Point(254, 265);
            this.buttonKatla.Name = "buttonKatla";
            this.buttonKatla.Size = new System.Drawing.Size(100, 28);
            this.buttonKatla.TabIndex = 10;
            this.buttonKatla.Text = "Katla";
            this.buttonKatla.UseVisualStyleBackColor = true;
            this.buttonKatla.Click += new System.EventHandler(this.buttonKatla_Click);
            // 
            // buttonKir
            // 
            this.buttonKir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKir.Location = new System.Drawing.Point(523, 657);
            this.buttonKir.Name = "buttonKir";
            this.buttonKir.Size = new System.Drawing.Size(150, 30);
            this.buttonKir.TabIndex = 11;
            this.buttonKir.Text = "Kumbarayı Kır";
            this.buttonKir.UseVisualStyleBackColor = true;
            this.buttonKir.Click += new System.EventHandler(this.buttonKir_Click);
            // 
            // buttonParaAt
            // 
            this.buttonParaAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonParaAt.Location = new System.Drawing.Point(124, 320);
            this.buttonParaAt.Name = "buttonParaAt";
            this.buttonParaAt.Size = new System.Drawing.Size(100, 28);
            this.buttonParaAt.TabIndex = 12;
            this.buttonParaAt.Text = "Para At";
            this.buttonParaAt.UseVisualStyleBackColor = true;
            this.buttonParaAt.Click += new System.EventHandler(this.buttonParaAt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(471, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Toplam Para:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // toplamPara
            // 
            this.toplamPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamPara.Location = new System.Drawing.Point(591, 107);
            this.toplamPara.Name = "toplamPara";
            this.toplamPara.ReadOnly = true;
            this.toplamPara.Size = new System.Drawing.Size(100, 26);
            this.toplamPara.TabIndex = 14;
            this.toplamPara.TextChanged += new System.EventHandler(this.toplamPara_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(502, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Kumbarayı Salla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSalla_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Para Seçin:";
            // 
            // MbkBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::mbkBank.Properties.Resources.banka1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1218, 755);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toplamPara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonParaAt);
            this.Controls.Add(this.buttonKir);
            this.Controls.Add(this.buttonKatla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbKagitPara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kalanHacim);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBozukPara);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MbkBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MbkBank";
            this.Load += new System.EventHandler(this.MbkBank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbBozukPara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox kalanHacim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbKagitPara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonKatla;
        private System.Windows.Forms.Button buttonKir;
        private System.Windows.Forms.Button buttonParaAt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox toplamPara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}

