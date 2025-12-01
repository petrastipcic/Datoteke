namespace Datoteke
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblBrojIndeksa = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIndeks = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.lstStudenti = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(29, 26);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(29, 71);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime";
            this.lblPrezime.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblBrojIndeksa
            // 
            this.lblBrojIndeksa.AutoSize = true;
            this.lblBrojIndeksa.Location = new System.Drawing.Point(29, 118);
            this.lblBrojIndeksa.Name = "lblBrojIndeksa";
            this.lblBrojIndeksa.Size = new System.Drawing.Size(65, 13);
            this.lblBrojIndeksa.TabIndex = 2;
            this.lblBrojIndeksa.Text = "Broj indeksa";
            this.lblBrojIndeksa.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(59, 19);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 3;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(79, 64);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 4;
            // 
            // txtIndeks
            // 
            this.txtIndeks.Location = new System.Drawing.Point(100, 111);
            this.txtIndeks.Name = "txtIndeks";
            this.txtIndeks.Size = new System.Drawing.Size(100, 20);
            this.txtIndeks.TabIndex = 5;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(32, 174);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(169, 174);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 7;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // lstStudenti
            // 
            this.lstStudenti.FormattingEnabled = true;
            this.lstStudenti.Location = new System.Drawing.Point(272, 12);
            this.lstStudenti.Name = "lstStudenti";
            this.lstStudenti.Size = new System.Drawing.Size(188, 160);
            this.lstStudenti.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstStudenti);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtIndeks);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblBrojIndeksa);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblBrojIndeksa;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIndeks;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.ListBox lstStudenti;
    }
}

