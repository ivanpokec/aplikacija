namespace aplikacija
{
    partial class FrmGlavna
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
            this.IbIPolumjer = new System.Windows.Forms.Label();
            this.IbIPovršina = new System.Windows.Forms.Label();
            this.IbIOpseg = new System.Windows.Forms.Label();
            this.txtPolumjer = new System.Windows.Forms.TextBox();
            this.txtPovršina = new System.Windows.Forms.TextBox();
            this.txtOpseg = new System.Windows.Forms.TextBox();
            this.chkSpremi = new System.Windows.Forms.CheckBox();
            this.IstRezultati = new System.Windows.Forms.ListBox();
            this.btIzracunaj = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IbIPolumjer
            // 
            this.IbIPolumjer.AutoSize = true;
            this.IbIPolumjer.Location = new System.Drawing.Point(22, 33);
            this.IbIPolumjer.Name = "IbIPolumjer";
            this.IbIPolumjer.Size = new System.Drawing.Size(47, 13);
            this.IbIPolumjer.TabIndex = 0;
            this.IbIPolumjer.Text = "Polumjer";
            this.IbIPolumjer.Click += new System.EventHandler(this.label1_Click);
            // 
            // IbIPovršina
            // 
            this.IbIPovršina.AutoSize = true;
            this.IbIPovršina.Location = new System.Drawing.Point(10, 62);
            this.IbIPovršina.Name = "IbIPovršina";
            this.IbIPovršina.Size = new System.Drawing.Size(48, 13);
            this.IbIPovršina.TabIndex = 1;
            this.IbIPovršina.Text = "Površina";
            // 
            // IbIOpseg
            // 
            this.IbIOpseg.AutoSize = true;
            this.IbIOpseg.Location = new System.Drawing.Point(16, 106);
            this.IbIOpseg.Name = "IbIOpseg";
            this.IbIOpseg.Size = new System.Drawing.Size(38, 13);
            this.IbIOpseg.TabIndex = 2;
            this.IbIOpseg.Text = "Opseg";
            // 
            // txtPolumjer
            // 
            this.txtPolumjer.Location = new System.Drawing.Point(75, 30);
            this.txtPolumjer.Name = "txtPolumjer";
            this.txtPolumjer.Size = new System.Drawing.Size(176, 20);
            this.txtPolumjer.TabIndex = 3;
            this.txtPolumjer.Text = "0,00";
            this.txtPolumjer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPovršina
            // 
            this.txtPovršina.Location = new System.Drawing.Point(65, 63);
            this.txtPovršina.Name = "txtPovršina";
            this.txtPovršina.ReadOnly = true;
            this.txtPovršina.Size = new System.Drawing.Size(185, 20);
            this.txtPovršina.TabIndex = 4;
            this.txtPovršina.Text = "0,00";
            this.txtPovršina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpseg
            // 
            this.txtOpseg.Location = new System.Drawing.Point(59, 103);
            this.txtOpseg.Name = "txtOpseg";
            this.txtOpseg.ReadOnly = true;
            this.txtOpseg.Size = new System.Drawing.Size(191, 20);
            this.txtOpseg.TabIndex = 5;
            this.txtOpseg.Text = "0,00";
            this.txtOpseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkSpremi
            // 
            this.chkSpremi.AutoSize = true;
            this.chkSpremi.Location = new System.Drawing.Point(64, 160);
            this.chkSpremi.Name = "chkSpremi";
            this.chkSpremi.Size = new System.Drawing.Size(88, 17);
            this.chkSpremi.TabIndex = 6;
            this.chkSpremi.Text = "Spremi u listu";
            this.chkSpremi.UseVisualStyleBackColor = true;
            // 
            // IstRezultati
            // 
            this.IstRezultati.FormattingEnabled = true;
            this.IstRezultati.Location = new System.Drawing.Point(290, 28);
            this.IstRezultati.Name = "IstRezultati";
            this.IstRezultati.Size = new System.Drawing.Size(147, 342);
            this.IstRezultati.TabIndex = 7;
            this.IstRezultati.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.IstRezultati_MouseDoubleClick);
            // 
            // btIzracunaj
            // 
            this.btIzracunaj.Location = new System.Drawing.Point(53, 206);
            this.btIzracunaj.Name = "btIzracunaj";
            this.btIzracunaj.Size = new System.Drawing.Size(163, 32);
            this.btIzracunaj.TabIndex = 8;
            this.btIzracunaj.Text = "Izračunaj";
            this.btIzracunaj.UseVisualStyleBackColor = true;
            this.btIzracunaj.Click += new System.EventHandler(this.btIzracunaj_Click);
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(51, 262);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(164, 28);
            this.btnOcisti.TabIndex = 9;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 431);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btIzracunaj);
            this.Controls.Add(this.IstRezultati);
            this.Controls.Add(this.chkSpremi);
            this.Controls.Add(this.txtOpseg);
            this.Controls.Add(this.txtPovršina);
            this.Controls.Add(this.txtPolumjer);
            this.Controls.Add(this.IbIOpseg);
            this.Controls.Add(this.IbIPovršina);
            this.Controls.Add(this.IbIPolumjer);
            this.Name = "FrmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavna forma aplikacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IbIPolumjer;
        private System.Windows.Forms.Label IbIPovršina;
        private System.Windows.Forms.Label IbIOpseg;
        private System.Windows.Forms.TextBox txtPolumjer;
        private System.Windows.Forms.TextBox txtPovršina;
        private System.Windows.Forms.TextBox txtOpseg;
        private System.Windows.Forms.CheckBox chkSpremi;
        private System.Windows.Forms.ListBox IstRezultati;
        private System.Windows.Forms.Button btIzracunaj;
        private System.Windows.Forms.Button btnOcisti;
    }
}

