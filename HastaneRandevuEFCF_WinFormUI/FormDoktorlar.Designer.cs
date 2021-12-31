
namespace HastaneRandevuEFCF_WinFormUI
{
    partial class FormDoktorlar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageListele = new System.Windows.Forms.TabPage();
            this.dataGridViewDoktor = new System.Windows.Forms.DataGridView();
            this.tabPageDrEkle = new System.Windows.Forms.TabPage();
            this.maskedTextBoxDrTel = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxDrBranslar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDrEkle = new System.Windows.Forms.Button();
            this.txtDrEmail = new System.Windows.Forms.TextBox();
            this.txtDrSoyad = new System.Windows.Forms.TextBox();
            this.txtDrAd = new System.Windows.Forms.TextBox();
            this.txtDrTC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).BeginInit();
            this.tabPageDrEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageListele);
            this.tabControl1.Controls.Add(this.tabPageDrEkle);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageListele
            // 
            this.tabPageListele.Controls.Add(this.dataGridViewDoktor);
            this.tabPageListele.Location = new System.Drawing.Point(4, 25);
            this.tabPageListele.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageListele.Name = "tabPageListele";
            this.tabPageListele.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageListele.Size = new System.Drawing.Size(617, 419);
            this.tabPageListele.TabIndex = 0;
            this.tabPageListele.Text = "Dr Listesi";
            this.tabPageListele.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDoktor
            // 
            this.dataGridViewDoktor.AllowUserToAddRows = false;
            this.dataGridViewDoktor.AllowUserToDeleteRows = false;
            this.dataGridViewDoktor.AllowUserToOrderColumns = true;
            this.dataGridViewDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoktor.Location = new System.Drawing.Point(26, 27);
            this.dataGridViewDoktor.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDoktor.Name = "dataGridViewDoktor";
            this.dataGridViewDoktor.ReadOnly = true;
            this.dataGridViewDoktor.Size = new System.Drawing.Size(565, 348);
            this.dataGridViewDoktor.TabIndex = 0;
            // 
            // tabPageDrEkle
            // 
            this.tabPageDrEkle.Controls.Add(this.maskedTextBoxDrTel);
            this.tabPageDrEkle.Controls.Add(this.comboBoxDrBranslar);
            this.tabPageDrEkle.Controls.Add(this.label6);
            this.tabPageDrEkle.Controls.Add(this.btnDrEkle);
            this.tabPageDrEkle.Controls.Add(this.txtDrEmail);
            this.tabPageDrEkle.Controls.Add(this.txtDrSoyad);
            this.tabPageDrEkle.Controls.Add(this.txtDrAd);
            this.tabPageDrEkle.Controls.Add(this.txtDrTC);
            this.tabPageDrEkle.Controls.Add(this.label5);
            this.tabPageDrEkle.Controls.Add(this.label4);
            this.tabPageDrEkle.Controls.Add(this.label3);
            this.tabPageDrEkle.Controls.Add(this.label2);
            this.tabPageDrEkle.Controls.Add(this.label1);
            this.tabPageDrEkle.Location = new System.Drawing.Point(4, 25);
            this.tabPageDrEkle.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageDrEkle.Name = "tabPageDrEkle";
            this.tabPageDrEkle.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageDrEkle.Size = new System.Drawing.Size(617, 419);
            this.tabPageDrEkle.TabIndex = 1;
            this.tabPageDrEkle.Text = "Dr Ekle";
            this.tabPageDrEkle.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxDrTel
            // 
            this.maskedTextBoxDrTel.Location = new System.Drawing.Point(206, 218);
            this.maskedTextBoxDrTel.Name = "maskedTextBoxDrTel";
            this.maskedTextBoxDrTel.Size = new System.Drawing.Size(299, 23);
            this.maskedTextBoxDrTel.TabIndex = 12;
            // 
            // comboBoxDrBranslar
            // 
            this.comboBoxDrBranslar.FormattingEnabled = true;
            this.comboBoxDrBranslar.Location = new System.Drawing.Point(206, 171);
            this.comboBoxDrBranslar.Name = "comboBoxDrBranslar";
            this.comboBoxDrBranslar.Size = new System.Drawing.Size(299, 24);
            this.comboBoxDrBranslar.TabIndex = 11;
            this.comboBoxDrBranslar.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrBranslar_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Branş:";
            // 
            // btnDrEkle
            // 
            this.btnDrEkle.Location = new System.Drawing.Point(125, 323);
            this.btnDrEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrEkle.Name = "btnDrEkle";
            this.btnDrEkle.Size = new System.Drawing.Size(383, 38);
            this.btnDrEkle.TabIndex = 9;
            this.btnDrEkle.Text = "YENİ DOKTOR EKLE";
            this.btnDrEkle.UseVisualStyleBackColor = true;
            this.btnDrEkle.Click += new System.EventHandler(this.btnDrEkle_Click);
            // 
            // txtDrEmail
            // 
            this.txtDrEmail.Location = new System.Drawing.Point(206, 264);
            this.txtDrEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtDrEmail.Name = "txtDrEmail";
            this.txtDrEmail.Size = new System.Drawing.Size(299, 23);
            this.txtDrEmail.TabIndex = 8;
            // 
            // txtDrSoyad
            // 
            this.txtDrSoyad.Location = new System.Drawing.Point(206, 125);
            this.txtDrSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtDrSoyad.Name = "txtDrSoyad";
            this.txtDrSoyad.Size = new System.Drawing.Size(299, 23);
            this.txtDrSoyad.TabIndex = 7;
            // 
            // txtDrAd
            // 
            this.txtDrAd.Location = new System.Drawing.Point(206, 79);
            this.txtDrAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDrAd.Name = "txtDrAd";
            this.txtDrAd.Size = new System.Drawing.Size(299, 23);
            this.txtDrAd.TabIndex = 6;
            // 
            // txtDrTC
            // 
            this.txtDrTC.Location = new System.Drawing.Point(206, 33);
            this.txtDrTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtDrTC.Name = "txtDrTC";
            this.txtDrTC.Size = new System.Drawing.Size(299, 23);
            this.txtDrTC.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // FormDoktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 448);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDoktorlar";
            this.Text = "DOKTOR İŞLEMLERİ FORMU";
            this.Load += new System.EventHandler(this.FormDoktorlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).EndInit();
            this.tabPageDrEkle.ResumeLayout(false);
            this.tabPageDrEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageListele;
        private System.Windows.Forms.DataGridView dataGridViewDoktor;
        private System.Windows.Forms.TabPage tabPageDrEkle;
        private System.Windows.Forms.ComboBox comboBoxDrBranslar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDrEkle;
        private System.Windows.Forms.TextBox txtDrEmail;
        private System.Windows.Forms.TextBox txtDrSoyad;
        private System.Windows.Forms.TextBox txtDrAd;
        private System.Windows.Forms.TextBox txtDrTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDrTel;
    }
}