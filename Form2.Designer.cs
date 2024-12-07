namespace Emlak_Kayıt_Programı
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
            this.btnList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbSıte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMetre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFıyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.cmbSat = new System.Windows.Forms.ComboBox();
            this.cmbOda = new System.Windows.Forms.ComboBox();
            this.cmbBlok = new System.Windows.Forms.ComboBox();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKardelen = new System.Windows.Forms.Button();
            this.btnElit = new System.Windows.Forms.Button();
            this.btnDoga = new System.Windows.Forms.Button();
            this.btnNatura = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(26, 379);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(170, 59);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "LİSTELE";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "GAYRIMENKUL KAYIT BİLGİLERİ";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(165, 91);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(222, 30);
            this.txtID.TabIndex = 2;
            // 
            // cmbSıte
            // 
            this.cmbSıte.FormattingEnabled = true;
            this.cmbSıte.Items.AddRange(new object[] {
            "ELİTKENT",
            "KARDELEN",
            "DOĞAŞEHİR",
            "NATURA"});
            this.cmbSıte.Location = new System.Drawing.Point(165, 131);
            this.cmbSıte.Name = "cmbSıte";
            this.cmbSıte.Size = new System.Drawing.Size(222, 33);
            this.cmbSıte.TabIndex = 3;
            this.cmbSıte.SelectedIndexChanged += new System.EventHandler(this.cmbSıte_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "SAT\\KİRA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "ODA SAYISI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "METREKARE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "SİTE:";
            // 
            // txtMetre
            // 
            this.txtMetre.Location = new System.Drawing.Point(165, 255);
            this.txtMetre.Name = "txtMetre";
            this.txtMetre.Size = new System.Drawing.Size(222, 30);
            this.txtMetre.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "FİYAT:";
            // 
            // txtFıyat
            // 
            this.txtFıyat.Location = new System.Drawing.Point(165, 294);
            this.txtFıyat.Name = "txtFıyat";
            this.txtFıyat.Size = new System.Drawing.Size(222, 30);
            this.txtFıyat.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "BLOK:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "NO:";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(327, 340);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(60, 30);
            this.txtNo.TabIndex = 17;
            // 
            // cmbSat
            // 
            this.cmbSat.FormattingEnabled = true;
            this.cmbSat.Items.AddRange(new object[] {
            "SATILIK",
            "KİRALIK"});
            this.cmbSat.Location = new System.Drawing.Point(165, 172);
            this.cmbSat.Name = "cmbSat";
            this.cmbSat.Size = new System.Drawing.Size(222, 33);
            this.cmbSat.TabIndex = 19;
            // 
            // cmbOda
            // 
            this.cmbOda.FormattingEnabled = true;
            this.cmbOda.Items.AddRange(new object[] {
            "1+1",
            "2+1",
            "3+1",
            "4+1"});
            this.cmbOda.Location = new System.Drawing.Point(165, 214);
            this.cmbOda.Name = "cmbOda";
            this.cmbOda.Size = new System.Drawing.Size(222, 33);
            this.cmbOda.TabIndex = 20;
            // 
            // cmbBlok
            // 
            this.cmbBlok.FormattingEnabled = true;
            this.cmbBlok.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.cmbBlok.Location = new System.Drawing.Point(165, 340);
            this.cmbBlok.Name = "cmbBlok";
            this.cmbBlok.Size = new System.Drawing.Size(62, 33);
            this.cmbBlok.TabIndex = 21;
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(202, 379);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(170, 59);
            this.btnKayıt.TabIndex = 22;
            this.btnKayıt.Text = "KAYIT";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(378, 379);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(170, 59);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(554, 379);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(170, 59);
            this.btnGuncelle.TabIndex = 24;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "AD\\SOYAD:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(625, 91);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(222, 30);
            this.txtAd.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(579, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(257, 29);
            this.label11.TabIndex = 25;
            this.label11.Text = "İLETİŞİM BİLGİLERİ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(500, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "TELEFON:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(625, 134);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(222, 30);
            this.txtTelefon.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(511, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "NOTLAR:";
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(625, 175);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(222, 149);
            this.txtNot.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 444);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1419, 228);
            this.dataGridView1.TabIndex = 32;
            // 
            // btnKardelen
            // 
            this.btnKardelen.Location = new System.Drawing.Point(1094, 221);
            this.btnKardelen.Name = "btnKardelen";
            this.btnKardelen.Size = new System.Drawing.Size(170, 59);
            this.btnKardelen.TabIndex = 36;
            this.btnKardelen.Text = "KARDELEN";
            this.btnKardelen.UseVisualStyleBackColor = true;
            // 
            // btnElit
            // 
            this.btnElit.Location = new System.Drawing.Point(924, 141);
            this.btnElit.Name = "btnElit";
            this.btnElit.Size = new System.Drawing.Size(170, 59);
            this.btnElit.TabIndex = 35;
            this.btnElit.Text = "ELİTKENT";
            this.btnElit.UseVisualStyleBackColor = true;
            // 
            // btnDoga
            // 
            this.btnDoga.Location = new System.Drawing.Point(1094, 62);
            this.btnDoga.Name = "btnDoga";
            this.btnDoga.Size = new System.Drawing.Size(170, 59);
            this.btnDoga.TabIndex = 34;
            this.btnDoga.Text = "DOĞAŞEHİR";
            this.btnDoga.UseVisualStyleBackColor = true;
            // 
            // btnNatura
            // 
            this.btnNatura.Location = new System.Drawing.Point(1260, 138);
            this.btnNatura.Name = "btnNatura";
            this.btnNatura.Size = new System.Drawing.Size(170, 59);
            this.btnNatura.TabIndex = 33;
            this.btnNatura.Text = "NATURA";
            this.btnNatura.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1153, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 25);
            this.label14.TabIndex = 37;
            this.label14.Text = "SİTE";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1433, 680);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnKardelen);
            this.Controls.Add(this.btnElit);
            this.Controls.Add(this.btnDoga);
            this.Controls.Add(this.btnNatura);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.cmbBlok);
            this.Controls.Add(this.cmbOda);
            this.Controls.Add(this.cmbSat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFıyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMetre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSıte);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbSıte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMetre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFıyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.ComboBox cmbSat;
        private System.Windows.Forms.ComboBox cmbOda;
        private System.Windows.Forms.ComboBox cmbBlok;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKardelen;
        private System.Windows.Forms.Button btnElit;
        private System.Windows.Forms.Button btnDoga;
        private System.Windows.Forms.Button btnNatura;
        private System.Windows.Forms.Label label14;
    }
}