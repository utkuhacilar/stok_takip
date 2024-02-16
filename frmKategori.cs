﻿using System;
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
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;
        private void kategorikontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text==read["kategori"].ToString() ||textBox1.Text=="")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            kategorikontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori)values('" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kategori Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle Bir Kategori Bulunmaktadır", "uyarı");
            }
            textBox1.Clear();
        }

        private void frmKategori_Load(object sender, EventArgs e)
        {

        }
    }
}
