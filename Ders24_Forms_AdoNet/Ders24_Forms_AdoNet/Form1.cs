using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders24_Forms_AdoNet
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection($"Server=DESKTOP-TG02SQ0;Database=DB_Test;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OgrenciListUpdate();
            
        }

        private void OgrenciListUpdate()
        {
            //SqlDataAdapter tablo olarak veri çekmemizi sağlar.
            SqlDataAdapter adpOgrenci = new SqlDataAdapter
                ("SELECT ID, Concat (ad,' ',Soyad) As [Ad Soyad], " +
                "telefon AS Telefon, tc AS [TC K. Nu.], ad,soyad " +
                "FROM tb_ogrenci ORDER BY ad,soyad", baglanti);
            DataTable dtOgrenci = new DataTable();
            adpOgrenci.Fill(dtOgrenci);
            data_ogrenciler.DataSource = dtOgrenci;
            data_ogrenciler.Columns["ID"].Visible = false;
            data_ogrenciler.Columns["ad"].Visible = false;
            data_ogrenciler.Columns["soyad"].Visible = false;

            //Silme combobox'ı doldurduk.
            //Öğrenci ad soyad gösterilecek.
            //Seçilen ogrencinin ID si tutulacak.
            cmb_sil_liste.DataSource = dtOgrenci;
            cmb_sil_liste.DisplayMember = "Ad Soyad";
            cmb_sil_liste.ValueMember = "ID";

            //Düzenleme Sekmesi
            cmb_Guncelle.DataSource = dtOgrenci;
            cmb_Guncelle.DisplayMember = "Ad Soyad";
            cmb_Guncelle.ValueMember = "ID";

        }
       

        private void DbConnect()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
            }
            catch
            {
                MessageBox.Show("Bağlantı Başarısız !!!");
            }
        }

        private void DBDisconnect()
        {
            try
            {
                if (baglanti.State != ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }
            catch
            {
                MessageBox.Show("Bağlantı kapatma Başarısız !!!");
            }
        }



        private void btn_sil_Click(object sender, EventArgs e)
        {
            int silinecekID = int.Parse(cmb_sil_liste.SelectedValue.ToString());

            SqlCommand silCommand = new
                SqlCommand("DELETE FROM tb_ogrenci WHERE ID=@id;", baglanti);
            silCommand.Parameters.Clear();
            silCommand.Parameters.AddWithValue("@id", silinecekID);

            string adSoyad = GetOgrenciAd(silinecekID);
            DialogResult cevap = MessageBox.Show(adSoyad +
                $" Silmek istediğinizden emin misiniz?", "SİLME ONAYI",
                MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                DbConnect();
                int etkilenenSatirSayisi = silCommand.ExecuteNonQuery();
                if (etkilenenSatirSayisi > 0)
                    MessageBox.Show("Silme işlemi tamamlandı.");
                else
                    MessageBox.Show("Herhangi bir kayıt silinmedi.");
                DBDisconnect();

                OgrenciListUpdate();
            }
        }

        private string GetOgrenciAd(int id)
        {
            DbConnect();
            SqlCommand sorgu = new
                SqlCommand($"SELECT Concat(ad,' ', soyad) as adSoyad FROM tb_ogrenci " +
                           $"WHERE ID={id};", baglanti);
            SqlDataReader dr = sorgu.ExecuteReader();
            string adSoyad = "";
            while (dr.Read())
            {
                adSoyad = dr.GetString(0);
            }
            DBDisconnect();
            return adSoyad;

        }

        private void btc_guncelle_Click(object sender, EventArgs e)
        {

        }

     
        private void btn_eklee_Click(object sender, EventArgs e)
        {
            SqlCommand insertCommand = new SqlCommand("SP_OgrenciEkle", baglanti);
            insertCommand.CommandType = CommandType.StoredProcedure;
            insertCommand.Parameters.AddWithValue("@ad", txt_ad.Text);
            insertCommand.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            insertCommand.Parameters.AddWithValue("@telefon", txt_telefon.Text);
            insertCommand.Parameters.AddWithValue("@tc", txt_tc.Text);

            DbConnect();
            //Eklemeden sonra ilk satırın ilk kolonu nu döndürür.
            int sonID = Convert.ToInt32(insertCommand.ExecuteScalar());
            MessageBox.Show(sonID.ToString());
            DBDisconnect();
        }
    }
}
