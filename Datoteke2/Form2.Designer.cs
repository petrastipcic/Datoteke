namespace Datoteke2
{
    partial class Form2
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
            this.lblRazred = new System.Windows.Forms.Label();
            this.lblUspjeh = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.cbRazred = new System.Windows.Forms.ComboBox();
            this.cbUspjeh = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 9);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(12, 50);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblRazred
            // 
            this.lblRazred.AutoSize = true;
            this.lblRazred.Location = new System.Drawing.Point(12, 91);
            this.lblRazred.Name = "lblRazred";
            this.lblRazred.Size = new System.Drawing.Size(41, 13);
            this.lblRazred.TabIndex = 2;
            this.lblRazred.Text = "Razred";
            // 
            // lblUspjeh
            // 
            this.lblUspjeh.AutoSize = true;
            this.lblUspjeh.Location = new System.Drawing.Point(12, 134);
            this.lblUspjeh.Name = "lblUspjeh";
            this.lblUspjeh.Size = new System.Drawing.Size(40, 13);
            this.lblUspjeh.TabIndex = 3;
            this.lblUspjeh.Text = "Uspjeh";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(42, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 4;
            this.txtIme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(62, 43);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 5;
            // 
            // cbRazred
            // 
            this.cbRazred.FormattingEnabled = true;
            this.cbRazred.Items.AddRange(new object[] {
            "1.A",
            "1.B",
            "1.C",
            "1.D",
            "1.E",
            "1.F",
            "2.A",
            "2.B",
            "2.C",
            "2.D",
            "2.E",
            "2.F",
            "3.A",
            "3.B",
            "3.C",
            "3.D",
            "3.E",
            "3.F",
            "4.A",
            "4.B",
            "4.C",
            "4.D",
            "4.E",
            "4.F"});
            this.cbRazred.Location = new System.Drawing.Point(59, 83);
            this.cbRazred.Name = "cbRazred";
            this.cbRazred.Size = new System.Drawing.Size(125, 21);
            this.cbRazred.TabIndex = 6;
            // 
            // cbUspjeh
            // 
            this.cbUspjeh.FormattingEnabled = true;
            this.cbUspjeh.Items.AddRange(new object[] {
            "Nedovoljan",
            "Dovoljan",
            "Dobar",
            "Vrlo dobar",
            "Odličan"});
            this.cbUspjeh.Location = new System.Drawing.Point(58, 126);
            this.cbUspjeh.Name = "cbUspjeh";
            this.cbUspjeh.Size = new System.Drawing.Size(125, 21);
            this.cbUspjeh.TabIndex = 7;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(12, 176);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 8;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(148, 176);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 9;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cbUspjeh);
            this.Controls.Add(this.cbRazred);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblUspjeh);
            this.Controls.Add(this.lblRazred);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblRazred;
        private System.Windows.Forms.Label lblUspjeh;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.ComboBox cbRazred;
        private System.Windows.Forms.ComboBox cbUspjeh;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnZatvori;
    }
}