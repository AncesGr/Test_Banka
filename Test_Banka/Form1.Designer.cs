
namespace Test_Banka
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
            this.lblAktualniLimit = new System.Windows.Forms.Label();
            this.lblCastkaLimit = new System.Windows.Forms.Label();
            this.textBoxLimit = new System.Windows.Forms.TextBox();
            this.buttonLimit = new System.Windows.Forms.Button();
            this.labelVyberLimit = new System.Windows.Forms.Label();
            this.labelCastkaVyber = new System.Windows.Forms.Label();
            this.btnLimitPlatba = new System.Windows.Forms.Button();
            this.txtLimitPlatba = new System.Windows.Forms.TextBox();
            this.lblZadejHodnotu = new System.Windows.Forms.Label();
            this.textBoxHodnota = new System.Windows.Forms.TextBox();
            this.buttonVybrat = new System.Windows.Forms.Button();
            this.buttonVložit = new System.Windows.Forms.Button();
            this.lblHodnotaPlatby = new System.Windows.Forms.Label();
            this.textBoxPlatba = new System.Windows.Forms.TextBox();
            this.labelCisloUctu = new System.Windows.Forms.Label();
            this.txtPlatbaCisloUctu = new System.Windows.Forms.TextBox();
            this.buttonZaplatit = new System.Windows.Forms.Button();
            this.lblKontokorent = new System.Windows.Forms.Label();
            this.txtKontokorent = new System.Windows.Forms.TextBox();
            this.lblKontokorentCastka = new System.Windows.Forms.Label();
            this.buttonKontokorent = new System.Windows.Forms.Button();
            this.lblJmenoPrijmeni = new System.Windows.Forms.Label();
            this.lblUctu = new System.Windows.Forms.Label();
            this.lblZustatek = new System.Windows.Forms.Label();
            this.lblJmeno = new System.Windows.Forms.Label();
            this.lblCisloUctu = new System.Windows.Forms.Label();
            this.lblAktualniZustatek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAktualniLimit
            // 
            this.lblAktualniLimit.AutoSize = true;
            this.lblAktualniLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAktualniLimit.Location = new System.Drawing.Point(12, 48);
            this.lblAktualniLimit.Name = "lblAktualniLimit";
            this.lblAktualniLimit.Size = new System.Drawing.Size(153, 20);
            this.lblAktualniLimit.TabIndex = 0;
            this.lblAktualniLimit.Text = "Aktuální limit platby";
            // 
            // lblCastkaLimit
            // 
            this.lblCastkaLimit.AutoSize = true;
            this.lblCastkaLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCastkaLimit.Location = new System.Drawing.Point(39, 68);
            this.lblCastkaLimit.Name = "lblCastkaLimit";
            this.lblCastkaLimit.Size = new System.Drawing.Size(45, 20);
            this.lblCastkaLimit.TabIndex = 1;
            this.lblCastkaLimit.Text = "7500";
            // 
            // textBoxLimit
            // 
            this.textBoxLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLimit.Location = new System.Drawing.Point(198, 51);
            this.textBoxLimit.Name = "textBoxLimit";
            this.textBoxLimit.Size = new System.Drawing.Size(100, 27);
            this.textBoxLimit.TabIndex = 2;
            // 
            // buttonLimit
            // 
            this.buttonLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLimit.Location = new System.Drawing.Point(312, 48);
            this.buttonLimit.Name = "buttonLimit";
            this.buttonLimit.Size = new System.Drawing.Size(115, 40);
            this.buttonLimit.TabIndex = 3;
            this.buttonLimit.Text = "Změnit limit";
            this.buttonLimit.UseVisualStyleBackColor = true;
            this.buttonLimit.Click += new System.EventHandler(this.buttonLimit_Click);
            // 
            // labelVyberLimit
            // 
            this.labelVyberLimit.AutoSize = true;
            this.labelVyberLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVyberLimit.Location = new System.Drawing.Point(21, 136);
            this.labelVyberLimit.Name = "labelVyberLimit";
            this.labelVyberLimit.Size = new System.Drawing.Size(96, 20);
            this.labelVyberLimit.TabIndex = 4;
            this.labelVyberLimit.Text = "Limit vybrat";
            // 
            // labelCastkaVyber
            // 
            this.labelCastkaVyber.AutoSize = true;
            this.labelCastkaVyber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCastkaVyber.Location = new System.Drawing.Point(36, 156);
            this.labelCastkaVyber.Name = "labelCastkaVyber";
            this.labelCastkaVyber.Size = new System.Drawing.Size(54, 20);
            this.labelCastkaVyber.TabIndex = 5;
            this.labelCastkaVyber.Text = "10000";
            // 
            // btnLimitPlatba
            // 
            this.btnLimitPlatba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLimitPlatba.Location = new System.Drawing.Point(243, 136);
            this.btnLimitPlatba.Name = "btnLimitPlatba";
            this.btnLimitPlatba.Size = new System.Drawing.Size(87, 40);
            this.btnLimitPlatba.TabIndex = 6;
            this.btnLimitPlatba.Text = "Výběr";
            this.btnLimitPlatba.UseVisualStyleBackColor = true;
            this.btnLimitPlatba.Click += new System.EventHandler(this.btnLimitPlatba_Click);
            // 
            // txtLimitPlatba
            // 
            this.txtLimitPlatba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLimitPlatba.Location = new System.Drawing.Point(137, 143);
            this.txtLimitPlatba.Name = "txtLimitPlatba";
            this.txtLimitPlatba.Size = new System.Drawing.Size(100, 27);
            this.txtLimitPlatba.TabIndex = 7;
            // 
            // lblZadejHodnotu
            // 
            this.lblZadejHodnotu.AutoSize = true;
            this.lblZadejHodnotu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZadejHodnotu.Location = new System.Drawing.Point(21, 223);
            this.lblZadejHodnotu.Name = "lblZadejHodnotu";
            this.lblZadejHodnotu.Size = new System.Drawing.Size(132, 20);
            this.lblZadejHodnotu.TabIndex = 8;
            this.lblZadejHodnotu.Text = "Zadejte hodnotu:";
            // 
            // textBoxHodnota
            // 
            this.textBoxHodnota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHodnota.Location = new System.Drawing.Point(25, 248);
            this.textBoxHodnota.Name = "textBoxHodnota";
            this.textBoxHodnota.Size = new System.Drawing.Size(100, 27);
            this.textBoxHodnota.TabIndex = 9;
            // 
            // buttonVybrat
            // 
            this.buttonVybrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVybrat.Location = new System.Drawing.Point(227, 242);
            this.buttonVybrat.Name = "buttonVybrat";
            this.buttonVybrat.Size = new System.Drawing.Size(91, 38);
            this.buttonVybrat.TabIndex = 10;
            this.buttonVybrat.Text = "Vybrat";
            this.buttonVybrat.UseVisualStyleBackColor = true;
            this.buttonVybrat.Click += new System.EventHandler(this.buttonVybrat_Click);
            // 
            // buttonVložit
            // 
            this.buttonVložit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVložit.Location = new System.Drawing.Point(137, 243);
            this.buttonVložit.Name = "buttonVložit";
            this.buttonVložit.Size = new System.Drawing.Size(84, 37);
            this.buttonVložit.TabIndex = 11;
            this.buttonVložit.Text = "Vložit";
            this.buttonVložit.UseVisualStyleBackColor = true;
            this.buttonVložit.Click += new System.EventHandler(this.buttonVložit_Click);
            // 
            // lblHodnotaPlatby
            // 
            this.lblHodnotaPlatby.AutoSize = true;
            this.lblHodnotaPlatby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHodnotaPlatby.Location = new System.Drawing.Point(21, 323);
            this.lblHodnotaPlatby.Name = "lblHodnotaPlatby";
            this.lblHodnotaPlatby.Size = new System.Drawing.Size(184, 20);
            this.lblHodnotaPlatby.TabIndex = 12;
            this.lblHodnotaPlatby.Text = "Platba: Zadejte hodnotu";
            this.lblHodnotaPlatby.Click += new System.EventHandler(this.lblHodnotaPlatby_Click);
            // 
            // textBoxPlatba
            // 
            this.textBoxPlatba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPlatba.Location = new System.Drawing.Point(72, 346);
            this.textBoxPlatba.Name = "textBoxPlatba";
            this.textBoxPlatba.Size = new System.Drawing.Size(100, 27);
            this.textBoxPlatba.TabIndex = 13;
            // 
            // labelCisloUctu
            // 
            this.labelCisloUctu.AutoSize = true;
            this.labelCisloUctu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCisloUctu.Location = new System.Drawing.Point(68, 389);
            this.labelCisloUctu.Name = "labelCisloUctu";
            this.labelCisloUctu.Size = new System.Drawing.Size(84, 20);
            this.labelCisloUctu.TabIndex = 14;
            this.labelCisloUctu.Text = "Číslo účtu";
            // 
            // txtPlatbaCisloUctu
            // 
            this.txtPlatbaCisloUctu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPlatbaCisloUctu.Location = new System.Drawing.Point(71, 412);
            this.txtPlatbaCisloUctu.Name = "txtPlatbaCisloUctu";
            this.txtPlatbaCisloUctu.Size = new System.Drawing.Size(100, 27);
            this.txtPlatbaCisloUctu.TabIndex = 15;
            // 
            // buttonZaplatit
            // 
            this.buttonZaplatit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZaplatit.Location = new System.Drawing.Point(71, 456);
            this.buttonZaplatit.Name = "buttonZaplatit";
            this.buttonZaplatit.Size = new System.Drawing.Size(100, 33);
            this.buttonZaplatit.TabIndex = 16;
            this.buttonZaplatit.Text = "Zaplatit";
            this.buttonZaplatit.UseVisualStyleBackColor = true;
            this.buttonZaplatit.Click += new System.EventHandler(this.buttonZaplatit_Click);
            // 
            // lblKontokorent
            // 
            this.lblKontokorent.AutoSize = true;
            this.lblKontokorent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKontokorent.Location = new System.Drawing.Point(280, 323);
            this.lblKontokorent.Name = "lblKontokorent";
            this.lblKontokorent.Size = new System.Drawing.Size(98, 20);
            this.lblKontokorent.TabIndex = 17;
            this.lblKontokorent.Text = "Kontokorent";
            // 
            // txtKontokorent
            // 
            this.txtKontokorent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKontokorent.Location = new System.Drawing.Point(283, 353);
            this.txtKontokorent.Name = "txtKontokorent";
            this.txtKontokorent.Size = new System.Drawing.Size(100, 27);
            this.txtKontokorent.TabIndex = 18;
            // 
            // lblKontokorentCastka
            // 
            this.lblKontokorentCastka.AutoSize = true;
            this.lblKontokorentCastka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKontokorentCastka.Location = new System.Drawing.Point(280, 389);
            this.lblKontokorentCastka.Name = "lblKontokorentCastka";
            this.lblKontokorentCastka.Size = new System.Drawing.Size(18, 20);
            this.lblKontokorentCastka.TabIndex = 19;
            this.lblKontokorentCastka.Text = "0";
            // 
            // buttonKontokorent
            // 
            this.buttonKontokorent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKontokorent.Location = new System.Drawing.Point(283, 426);
            this.buttonKontokorent.Name = "buttonKontokorent";
            this.buttonKontokorent.Size = new System.Drawing.Size(144, 31);
            this.buttonKontokorent.TabIndex = 20;
            this.buttonKontokorent.Text = "Kontokorent";
            this.buttonKontokorent.UseVisualStyleBackColor = true;
            this.buttonKontokorent.Click += new System.EventHandler(this.buttonKontokorent_Click);
            // 
            // lblJmenoPrijmeni
            // 
            this.lblJmenoPrijmeni.AutoSize = true;
            this.lblJmenoPrijmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJmenoPrijmeni.Location = new System.Drawing.Point(483, 51);
            this.lblJmenoPrijmeni.Name = "lblJmenoPrijmeni";
            this.lblJmenoPrijmeni.Size = new System.Drawing.Size(143, 20);
            this.lblJmenoPrijmeni.TabIndex = 21;
            this.lblJmenoPrijmeni.Text = "Jméno a příjmení:";
            // 
            // lblUctu
            // 
            this.lblUctu.AutoSize = true;
            this.lblUctu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUctu.Location = new System.Drawing.Point(483, 115);
            this.lblUctu.Name = "lblUctu";
            this.lblUctu.Size = new System.Drawing.Size(89, 20);
            this.lblUctu.TabIndex = 22;
            this.lblUctu.Text = "Číslo účtu:";
            this.lblUctu.Click += new System.EventHandler(this.lblUctu_Click);
            // 
            // lblZustatek
            // 
            this.lblZustatek.AutoSize = true;
            this.lblZustatek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZustatek.Location = new System.Drawing.Point(485, 185);
            this.lblZustatek.Name = "lblZustatek";
            this.lblZustatek.Size = new System.Drawing.Size(141, 20);
            this.lblZustatek.TabIndex = 23;
            this.lblZustatek.Text = "Aktuální zůstatek:";
            // 
            // lblJmeno
            // 
            this.lblJmeno.AutoSize = true;
            this.lblJmeno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblJmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJmeno.Location = new System.Drawing.Point(632, 51);
            this.lblJmeno.Name = "lblJmeno";
            this.lblJmeno.Size = new System.Drawing.Size(15, 20);
            this.lblJmeno.TabIndex = 24;
            this.lblJmeno.Text = "-";
            this.lblJmeno.Click += new System.EventHandler(this.lblJmeno_Click);
            // 
            // lblCisloUctu
            // 
            this.lblCisloUctu.AutoSize = true;
            this.lblCisloUctu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCisloUctu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCisloUctu.Location = new System.Drawing.Point(578, 115);
            this.lblCisloUctu.Name = "lblCisloUctu";
            this.lblCisloUctu.Size = new System.Drawing.Size(15, 20);
            this.lblCisloUctu.TabIndex = 25;
            this.lblCisloUctu.Text = "-";
            // 
            // lblAktualniZustatek
            // 
            this.lblAktualniZustatek.AutoSize = true;
            this.lblAktualniZustatek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblAktualniZustatek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAktualniZustatek.Location = new System.Drawing.Point(632, 185);
            this.lblAktualniZustatek.Name = "lblAktualniZustatek";
            this.lblAktualniZustatek.Size = new System.Drawing.Size(15, 20);
            this.lblAktualniZustatek.TabIndex = 26;
            this.lblAktualniZustatek.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(791, 522);
            this.Controls.Add(this.lblAktualniZustatek);
            this.Controls.Add(this.lblCisloUctu);
            this.Controls.Add(this.lblJmeno);
            this.Controls.Add(this.lblZustatek);
            this.Controls.Add(this.lblUctu);
            this.Controls.Add(this.lblJmenoPrijmeni);
            this.Controls.Add(this.buttonKontokorent);
            this.Controls.Add(this.lblKontokorentCastka);
            this.Controls.Add(this.txtKontokorent);
            this.Controls.Add(this.lblKontokorent);
            this.Controls.Add(this.buttonZaplatit);
            this.Controls.Add(this.txtPlatbaCisloUctu);
            this.Controls.Add(this.labelCisloUctu);
            this.Controls.Add(this.textBoxPlatba);
            this.Controls.Add(this.lblHodnotaPlatby);
            this.Controls.Add(this.buttonVložit);
            this.Controls.Add(this.buttonVybrat);
            this.Controls.Add(this.textBoxHodnota);
            this.Controls.Add(this.lblZadejHodnotu);
            this.Controls.Add(this.txtLimitPlatba);
            this.Controls.Add(this.btnLimitPlatba);
            this.Controls.Add(this.labelCastkaVyber);
            this.Controls.Add(this.labelVyberLimit);
            this.Controls.Add(this.buttonLimit);
            this.Controls.Add(this.textBoxLimit);
            this.Controls.Add(this.lblCastkaLimit);
            this.Controls.Add(this.lblAktualniLimit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAktualniLimit;
        private System.Windows.Forms.Label lblCastkaLimit;
        private System.Windows.Forms.TextBox textBoxLimit;
        private System.Windows.Forms.Button buttonLimit;
        private System.Windows.Forms.Label labelVyberLimit;
        private System.Windows.Forms.Label labelCastkaVyber;
        private System.Windows.Forms.Button btnLimitPlatba;
        private System.Windows.Forms.TextBox txtLimitPlatba;
        private System.Windows.Forms.Label lblZadejHodnotu;
        private System.Windows.Forms.TextBox textBoxHodnota;
        private System.Windows.Forms.Button buttonVybrat;
        private System.Windows.Forms.Button buttonVložit;
        private System.Windows.Forms.Label lblHodnotaPlatby;
        private System.Windows.Forms.TextBox textBoxPlatba;
        private System.Windows.Forms.Label labelCisloUctu;
        private System.Windows.Forms.TextBox txtPlatbaCisloUctu;
        private System.Windows.Forms.Button buttonZaplatit;
        private System.Windows.Forms.Label lblKontokorent;
        private System.Windows.Forms.TextBox txtKontokorent;
        private System.Windows.Forms.Label lblKontokorentCastka;
        private System.Windows.Forms.Button buttonKontokorent;
        private System.Windows.Forms.Label lblJmenoPrijmeni;
        private System.Windows.Forms.Label lblUctu;
        private System.Windows.Forms.Label lblZustatek;
        private System.Windows.Forms.Label lblJmeno;
        private System.Windows.Forms.Label lblCisloUctu;
        private System.Windows.Forms.Label lblAktualniZustatek;
    }
}

