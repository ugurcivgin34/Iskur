
namespace Ders24_Forms_AdoNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEkle = new System.Windows.Forms.TabPage();
            this.btn_eklee = new System.Windows.Forms.Button();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabSil = new System.Windows.Forms.TabPage();
            this.btn_sil = new System.Windows.Forms.Button();
            this.cmb_sil_liste = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabListele = new System.Windows.Forms.TabPage();
            this.data_ogrenciler = new System.Windows.Forms.DataGridView();
            this.tabDüzenle = new System.Windows.Forms.TabPage();
            this.btc_guncelle = new System.Windows.Forms.Button();
            this.txt_tc_guncelle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_telefon_guncelle = new System.Windows.Forms.TextBox();
            this.txt_soyad_guncelle = new System.Windows.Forms.TextBox();
            this.txt_ad_guncelle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Guncelle = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabEkle.SuspendLayout();
            this.tabSil.SuspendLayout();
            this.tabListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ogrenciler)).BeginInit();
            this.tabDüzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(181, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRENCİ EKLE";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEkle);
            this.tabControl1.Controls.Add(this.tabSil);
            this.tabControl1.Controls.Add(this.tabListele);
            this.tabControl1.Controls.Add(this.tabDüzenle);
            this.tabControl1.Location = new System.Drawing.Point(118, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(997, 526);
            this.tabControl1.TabIndex = 1;
            // 
            // tabEkle
            // 
            this.tabEkle.BackColor = System.Drawing.Color.Bisque;
            this.tabEkle.Controls.Add(this.btn_eklee);
            this.tabEkle.Controls.Add(this.txt_tc);
            this.tabEkle.Controls.Add(this.label5);
            this.tabEkle.Controls.Add(this.txt_telefon);
            this.tabEkle.Controls.Add(this.label4);
            this.tabEkle.Controls.Add(this.txt_soyad);
            this.tabEkle.Controls.Add(this.label3);
            this.tabEkle.Controls.Add(this.txt_ad);
            this.tabEkle.Controls.Add(this.label2);
            this.tabEkle.Controls.Add(this.label1);
            this.tabEkle.Location = new System.Drawing.Point(4, 46);
            this.tabEkle.Name = "tabEkle";
            this.tabEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabEkle.Size = new System.Drawing.Size(989, 476);
            this.tabEkle.TabIndex = 0;
            this.tabEkle.Text = "Ekle";
            // 
            // btn_eklee
            // 
            this.btn_eklee.Location = new System.Drawing.Point(242, 360);
            this.btn_eklee.Name = "btn_eklee";
            this.btn_eklee.Size = new System.Drawing.Size(373, 48);
            this.btn_eklee.TabIndex = 9;
            this.btn_eklee.Text = "Ekle";
            this.btn_eklee.UseVisualStyleBackColor = true;
            this.btn_eklee.Click += new System.EventHandler(this.btn_eklee_Click);
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(242, 279);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(373, 43);
            this.txt_tc.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "TC Kim. No :";
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(242, 216);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(373, 43);
            this.txt_telefon.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefon :";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(242, 153);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(373, 43);
            this.txt_soyad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyad :";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(242, 77);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(373, 43);
            this.txt_ad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // tabSil
            // 
            this.tabSil.BackColor = System.Drawing.Color.Silver;
            this.tabSil.Controls.Add(this.btn_sil);
            this.tabSil.Controls.Add(this.cmb_sil_liste);
            this.tabSil.Controls.Add(this.label6);
            this.tabSil.Location = new System.Drawing.Point(4, 46);
            this.tabSil.Name = "tabSil";
            this.tabSil.Padding = new System.Windows.Forms.Padding(3);
            this.tabSil.Size = new System.Drawing.Size(989, 476);
            this.tabSil.TabIndex = 1;
            this.tabSil.Text = "Sil";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(201, 265);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(458, 54);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "ÖĞRENCİ SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // cmb_sil_liste
            // 
            this.cmb_sil_liste.FormattingEnabled = true;
            this.cmb_sil_liste.Location = new System.Drawing.Point(201, 140);
            this.cmb_sil_liste.Name = "cmb_sil_liste";
            this.cmb_sil_liste.Size = new System.Drawing.Size(458, 45);
            this.cmb_sil_liste.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(458, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Silinecek Öğrenciyi Listeden Seçiniz";
            // 
            // tabListele
            // 
            this.tabListele.Controls.Add(this.data_ogrenciler);
            this.tabListele.Location = new System.Drawing.Point(4, 46);
            this.tabListele.Name = "tabListele";
            this.tabListele.Size = new System.Drawing.Size(989, 476);
            this.tabListele.TabIndex = 2;
            this.tabListele.Text = "Listele";
            this.tabListele.UseVisualStyleBackColor = true;
            // 
            // data_ogrenciler
            // 
            this.data_ogrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ogrenciler.Location = new System.Drawing.Point(47, 36);
            this.data_ogrenciler.Name = "data_ogrenciler";
            this.data_ogrenciler.RowHeadersWidth = 51;
            this.data_ogrenciler.RowTemplate.Height = 29;
            this.data_ogrenciler.Size = new System.Drawing.Size(920, 423);
            this.data_ogrenciler.TabIndex = 0;
            // 
            // tabDüzenle
            // 
            this.tabDüzenle.BackColor = System.Drawing.Color.Maroon;
            this.tabDüzenle.Controls.Add(this.btc_guncelle);
            this.tabDüzenle.Controls.Add(this.txt_tc_guncelle);
            this.tabDüzenle.Controls.Add(this.label11);
            this.tabDüzenle.Controls.Add(this.label10);
            this.tabDüzenle.Controls.Add(this.label9);
            this.tabDüzenle.Controls.Add(this.txt_telefon_guncelle);
            this.tabDüzenle.Controls.Add(this.txt_soyad_guncelle);
            this.tabDüzenle.Controls.Add(this.txt_ad_guncelle);
            this.tabDüzenle.Controls.Add(this.label8);
            this.tabDüzenle.Controls.Add(this.label7);
            this.tabDüzenle.Controls.Add(this.cmb_Guncelle);
            this.tabDüzenle.Location = new System.Drawing.Point(4, 46);
            this.tabDüzenle.Name = "tabDüzenle";
            this.tabDüzenle.Size = new System.Drawing.Size(989, 476);
            this.tabDüzenle.TabIndex = 3;
            this.tabDüzenle.Text = "Düzenle";
            // 
            // btc_guncelle
            // 
            this.btc_guncelle.Location = new System.Drawing.Point(289, 430);
            this.btc_guncelle.Name = "btc_guncelle";
            this.btc_guncelle.Size = new System.Drawing.Size(344, 43);
            this.btc_guncelle.TabIndex = 12;
            this.btc_guncelle.Text = "GÜNCELLE";
            this.btc_guncelle.UseVisualStyleBackColor = true;
            this.btc_guncelle.Click += new System.EventHandler(this.btc_guncelle_Click);
            // 
            // txt_tc_guncelle
            // 
            this.txt_tc_guncelle.Location = new System.Drawing.Point(289, 380);
            this.txt_tc_guncelle.Name = "txt_tc_guncelle";
            this.txt_tc_guncelle.Size = new System.Drawing.Size(344, 43);
            this.txt_tc_guncelle.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 38);
            this.label11.TabIndex = 10;
            this.label11.Text = "TCKN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 38);
            this.label10.TabIndex = 9;
            this.label10.Text = "Telefon:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 38);
            this.label9.TabIndex = 8;
            this.label9.Text = "Soyad:";
            // 
            // txt_telefon_guncelle
            // 
            this.txt_telefon_guncelle.Location = new System.Drawing.Point(289, 310);
            this.txt_telefon_guncelle.Name = "txt_telefon_guncelle";
            this.txt_telefon_guncelle.Size = new System.Drawing.Size(344, 43);
            this.txt_telefon_guncelle.TabIndex = 7;
            // 
            // txt_soyad_guncelle
            // 
            this.txt_soyad_guncelle.Location = new System.Drawing.Point(289, 249);
            this.txt_soyad_guncelle.Name = "txt_soyad_guncelle";
            this.txt_soyad_guncelle.Size = new System.Drawing.Size(344, 43);
            this.txt_soyad_guncelle.TabIndex = 6;
            // 
            // txt_ad_guncelle
            // 
            this.txt_ad_guncelle.Location = new System.Drawing.Point(289, 181);
            this.txt_ad_guncelle.Name = "txt_ad_guncelle";
            this.txt_ad_guncelle.Size = new System.Drawing.Size(344, 43);
            this.txt_ad_guncelle.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 38);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(479, 38);
            this.label7.TabIndex = 3;
            this.label7.Text = "Düzenlecek öğrenciyi listeden seçiniz";
            // 
            // cmb_Guncelle
            // 
            this.cmb_Guncelle.FormattingEnabled = true;
            this.cmb_Guncelle.Location = new System.Drawing.Point(208, 117);
            this.cmb_Guncelle.Name = "cmb_Guncelle";
            this.cmb_Guncelle.Size = new System.Drawing.Size(392, 45);
            this.cmb_Guncelle.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 832);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Öğrenci Bilgi Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEkle.ResumeLayout(false);
            this.tabEkle.PerformLayout();
            this.tabSil.ResumeLayout(false);
            this.tabSil.PerformLayout();
            this.tabListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_ogrenciler)).EndInit();
            this.tabDüzenle.ResumeLayout(false);
            this.tabDüzenle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEkle;
       
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabSil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.ComboBox cmb_sil_liste;
        private System.Windows.Forms.TabPage tabListele;
        private System.Windows.Forms.DataGridView data_ogrenciler;
        private System.Windows.Forms.TabPage tabDüzenle;
        private System.Windows.Forms.Button btc_guncelle;
        private System.Windows.Forms.TextBox txt_tc_guncelle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_telefon_guncelle;
        private System.Windows.Forms.TextBox txt_soyad_guncelle;
        private System.Windows.Forms.TextBox txt_ad_guncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Guncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_eklee;
    }
}

