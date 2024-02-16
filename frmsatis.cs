using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace giyim
{
    public partial class frmsatis : Form
    {
        public frmsatis()
        {
            InitializeComponent();
          
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();


        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter ("select * from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        
        private void frmsatis_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
             
            if (txtTc.Text=="")
            {
                label3.Text = "";
                txtTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from müşteri where tc like '"+txtTc.Text+"'  ",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                temizle();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from urun where barkodno  like '" + txtBarkodNo.Text + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txtÜrünAdı.Text = read["urunnadi"].ToString();
                    txtSatışFiyatı.Text = read["satisfiyati"].ToString();

                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Boşluklarını Doldurunuz");
                
            }
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtÜrünMiktarı)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }

        private void txtÜrünMiktarı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (decimal.Parse(txtÜrünMiktarı.Text) * decimal.Parse(txtSatışFiyatı.Text)).ToString();
            }
            catch (Exception)
            {
                ;
                
            }
        }

        private void txtSatışFiyatı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (decimal.Parse(txtÜrünMiktarı.Text) * decimal.Parse(txtSatışFiyatı.Text)).ToString();
            }
            catch (Exception)
            {
                ;

            }
        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true; 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text==read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           

        }

        private void btnSatışİptal_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {

           
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet",baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();
            }
            catch (Exception)
            {            }
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            frmSatışListele listele = new frmSatışListele();
            listele.ShowDialog();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            frmurunlistele listele = new frmurunlistele();
            listele.ShowDialog();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            frmÜrünEkle ekle = new frmÜrünEkle();
            ekle.ShowDialog();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele = new frmMusteriListele();
            listele.ShowDialog();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            FrmMşteri ekle = new FrmMşteri();
            ekle.ShowDialog();
        }

        private void bunifuBtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                barkodkontrol();
                if (durum == true)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                    komut.Parameters.AddWithValue("@tc", txtTc.Text);
                    komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                    komut.Parameters.AddWithValue("telefon", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                    komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
                    komut.Parameters.AddWithValue("@miktari", int.Parse(txtÜrünMiktarı.Text));
                    komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatışFiyatı.Text));
                    komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplamFiyat.Text));
                    komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update sepet miktari=miktari-'" + int.Parse(txtÜrünMiktarı.Text) + "' where barkodno='" + txtBarkodNo.Text + "')", baglanti);
                    komut2.ExecuteNonQuery();
                    SqlCommand komut3 = new SqlCommand("update sepet toplamfiyati=miktari*satisfiyati where barkodno='" + txtBarkodNo.Text + "')", baglanti);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                }

                txtÜrünMiktarı.Text = "1";
                daset.Tables["sepet"].Clear();
                sepetlistele();
                hesapla();
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtÜrünMiktarı)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Boşlukları doldurunuz");
            }
           
        }

        private void bunifuBtnSatısYap_Click(object sender, EventArgs e)
        {
            
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into satis(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values (@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                    komut.Parameters.AddWithValue("@tc", txtTc.Text);
                    komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                    komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                    komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                    komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                    komut.Parameters.AddWithValue("@satisfiyati", decimal.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                    komut.Parameters.AddWithValue("@toplamfiyati", decimal.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                    komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                    SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkodno= '" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "' ", baglanti);
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                }
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("delete from sepet ", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                daset.Tables["sepet"].Clear();
                sepetlistele();
                hesapla();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ürünler sepetten çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış İptal Edildi");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void frmsatis_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Programdan Çıkmak İstediğinzden Emin Misiniz?", "Çıkış Mesaji", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                
                Environment.Exit(0);
            }
            else if (x == DialogResult.No)
            {
                e.Cancel=true;
            }
        }

        private void frmsatis_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
