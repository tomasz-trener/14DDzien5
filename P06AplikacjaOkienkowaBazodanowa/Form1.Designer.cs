namespace P06AplikacjaOkienkowaBazodanowa
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
            this.dgvDane = new System.Windows.Forms.DataGridView();
            this.btnWyslij = new System.Windows.Forms.Button();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdresSerwera = new System.Windows.Forms.TextBox();
            this.txtNazwaBazyDanych = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNazwaUzytkownika = new System.Windows.Forms.TextBox();
            this.lblNazwaUzytkownika = new System.Windows.Forms.Label();
            this.txtHaslo = new System.Windows.Forms.TextBox();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbSql = new System.Windows.Forms.RadioButton();
            this.rbWindows = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDane)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDane
            // 
            this.dgvDane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDane.Location = new System.Drawing.Point(12, 87);
            this.dgvDane.Name = "dgvDane";
            this.dgvDane.Size = new System.Drawing.Size(702, 497);
            this.dgvDane.TabIndex = 0;
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(444, 58);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(75, 23);
            this.btnWyslij.TabIndex = 1;
            this.btnWyslij.Text = "Wyślij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // txtSql
            // 
            this.txtSql.Location = new System.Drawing.Point(97, 60);
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(344, 20);
            this.txtSql.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Polecenie SQL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adres Serwera";
            // 
            // txtAdresSerwera
            // 
            this.txtAdresSerwera.Location = new System.Drawing.Point(16, 29);
            this.txtAdresSerwera.Name = "txtAdresSerwera";
            this.txtAdresSerwera.Size = new System.Drawing.Size(170, 20);
            this.txtAdresSerwera.TabIndex = 5;
            this.txtAdresSerwera.Text = ".";
            // 
            // txtNazwaBazyDanych
            // 
            this.txtNazwaBazyDanych.Location = new System.Drawing.Point(192, 29);
            this.txtNazwaBazyDanych.Name = "txtNazwaBazyDanych";
            this.txtNazwaBazyDanych.Size = new System.Drawing.Size(170, 20);
            this.txtNazwaBazyDanych.TabIndex = 7;
            this.txtNazwaBazyDanych.Text = "a_zawodnicy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nazwa Bazy danych";
            // 
            // txtNazwaUzytkownika
            // 
            this.txtNazwaUzytkownika.Location = new System.Drawing.Point(368, 29);
            this.txtNazwaUzytkownika.Name = "txtNazwaUzytkownika";
            this.txtNazwaUzytkownika.Size = new System.Drawing.Size(170, 20);
            this.txtNazwaUzytkownika.TabIndex = 9;
            this.txtNazwaUzytkownika.Text = "sa";
            this.txtNazwaUzytkownika.Visible = false;
            // 
            // lblNazwaUzytkownika
            // 
            this.lblNazwaUzytkownika.AutoSize = true;
            this.lblNazwaUzytkownika.Location = new System.Drawing.Point(365, 13);
            this.lblNazwaUzytkownika.Name = "lblNazwaUzytkownika";
            this.lblNazwaUzytkownika.Size = new System.Drawing.Size(104, 13);
            this.lblNazwaUzytkownika.TabIndex = 8;
            this.lblNazwaUzytkownika.Text = "Nazwa Użytkownika";
            this.lblNazwaUzytkownika.Visible = false;
            // 
            // txtHaslo
            // 
            this.txtHaslo.Location = new System.Drawing.Point(544, 29);
            this.txtHaslo.Name = "txtHaslo";
            this.txtHaslo.PasswordChar = '*';
            this.txtHaslo.Size = new System.Drawing.Size(170, 20);
            this.txtHaslo.TabIndex = 11;
            this.txtHaslo.Text = "alx";
            this.txtHaslo.Visible = false;
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Location = new System.Drawing.Point(541, 13);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(36, 13);
            this.lblHaslo.TabIndex = 10;
            this.lblHaslo.Text = "Hasło";
            this.lblHaslo.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Autentykacja";
            // 
            // rbSql
            // 
            this.rbSql.AutoSize = true;
            this.rbSql.Location = new System.Drawing.Point(593, 60);
            this.rbSql.Name = "rbSql";
            this.rbSql.Size = new System.Drawing.Size(46, 17);
            this.rbSql.TabIndex = 13;
            this.rbSql.Text = "SQL";
            this.rbSql.UseVisualStyleBackColor = true;
            this.rbSql.CheckedChanged += new System.EventHandler(this.rbSql_CheckedChanged);
            // 
            // rbWindows
            // 
            this.rbWindows.AutoSize = true;
            this.rbWindows.Checked = true;
            this.rbWindows.Location = new System.Drawing.Point(645, 61);
            this.rbWindows.Name = "rbWindows";
            this.rbWindows.Size = new System.Drawing.Size(69, 17);
            this.rbWindows.TabIndex = 14;
            this.rbWindows.TabStop = true;
            this.rbWindows.Text = "Windows";
            this.rbWindows.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 593);
            this.Controls.Add(this.rbWindows);
            this.Controls.Add(this.rbSql);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHaslo);
            this.Controls.Add(this.lblHaslo);
            this.Controls.Add(this.txtNazwaUzytkownika);
            this.Controls.Add(this.lblNazwaUzytkownika);
            this.Controls.Add(this.txtNazwaBazyDanych);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdresSerwera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.btnWyslij);
            this.Controls.Add(this.dgvDane);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDane;
        private System.Windows.Forms.Button btnWyslij;
        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdresSerwera;
        private System.Windows.Forms.TextBox txtNazwaBazyDanych;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNazwaUzytkownika;
        private System.Windows.Forms.Label lblNazwaUzytkownika;
        private System.Windows.Forms.TextBox txtHaslo;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbSql;
        private System.Windows.Forms.RadioButton rbWindows;
    }
}

