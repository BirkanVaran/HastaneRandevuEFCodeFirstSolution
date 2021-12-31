
namespace HastaneRandevuEFCF_WinFormUI
{
    partial class UC_RandevuSaat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxSaatler = new System.Windows.Forms.ComboBox();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn45 = new System.Windows.Forms.Button();
            this.tableLayoutPanelRandevuButtonlar = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelRandevuButtonlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saat Seç:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSaatler, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(49, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.68085F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.31915F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxSaatler
            // 
            this.comboBoxSaatler.FormattingEnabled = true;
            this.comboBoxSaatler.Location = new System.Drawing.Point(4, 29);
            this.comboBoxSaatler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSaatler.Name = "comboBoxSaatler";
            this.comboBoxSaatler.Size = new System.Drawing.Size(288, 24);
            this.comboBoxSaatler.TabIndex = 0;
            this.comboBoxSaatler.SelectedIndexChanged += new System.EventHandler(this.comboBoxSaatler_SelectedIndexChanged);
            // 
            // btn00
            // 
            this.btn00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn00.Location = new System.Drawing.Point(4, 4);
            this.btn00.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(142, 67);
            this.btn00.TabIndex = 0;
            this.btn00.Text = "button1";
            this.btn00.UseVisualStyleBackColor = true;
            // 
            // btn30
            // 
            this.btn30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn30.Location = new System.Drawing.Point(4, 79);
            this.btn30.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(142, 67);
            this.btn30.TabIndex = 2;
            this.btn30.Text = "button3";
            this.btn30.UseVisualStyleBackColor = true;
            // 
            // btn15
            // 
            this.btn15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn15.Location = new System.Drawing.Point(154, 4);
            this.btn15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(143, 67);
            this.btn15.TabIndex = 1;
            this.btn15.Text = "button2";
            this.btn15.UseVisualStyleBackColor = true;
            // 
            // btn45
            // 
            this.btn45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn45.Location = new System.Drawing.Point(154, 79);
            this.btn45.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn45.Name = "btn45";
            this.btn45.Size = new System.Drawing.Size(143, 67);
            this.btn45.TabIndex = 3;
            this.btn45.Text = "button4";
            this.btn45.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelRandevuButtonlar
            // 
            this.tableLayoutPanelRandevuButtonlar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tableLayoutPanelRandevuButtonlar.ColumnCount = 2;
            this.tableLayoutPanelRandevuButtonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButtonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButtonlar.Controls.Add(this.btn00, 0, 0);
            this.tableLayoutPanelRandevuButtonlar.Controls.Add(this.btn15, 1, 0);
            this.tableLayoutPanelRandevuButtonlar.Controls.Add(this.btn45, 1, 1);
            this.tableLayoutPanelRandevuButtonlar.Controls.Add(this.btn30, 0, 1);
            this.tableLayoutPanelRandevuButtonlar.Location = new System.Drawing.Point(45, 89);
            this.tableLayoutPanelRandevuButtonlar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelRandevuButtonlar.Name = "tableLayoutPanelRandevuButtonlar";
            this.tableLayoutPanelRandevuButtonlar.RowCount = 2;
            this.tableLayoutPanelRandevuButtonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButtonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButtonlar.Size = new System.Drawing.Size(301, 150);
            this.tableLayoutPanelRandevuButtonlar.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_RandevuSaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.tableLayoutPanelRandevuButtonlar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_RandevuSaat";
            this.Size = new System.Drawing.Size(388, 266);
            this.Load += new System.EventHandler(this.UC_RandevuSaat_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelRandevuButtonlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn45;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRandevuButtonlar;
        private System.Windows.Forms.ComboBox comboBoxSaatler;
        private System.Windows.Forms.Timer timer1;
    }
}
