using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_Mysql
{
    
    public partial class AddKategoriElektronik : Form
    {
        private readonly KategoriElektronik _parent;
        public string id_kategori, nama_kategori, nama_penanggung_jawab;

        public AddKategoriElektronik(KategoriElektronik parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void AddKategoriElektronik_Load(object sender, EventArgs e)
        {
            DbMasipon.LoadComboBox("SELECT * FROM pegawai", "pegawai", "nama", cmbPenanggungJawab);
            cmbPenanggungJawab.Text = nama_penanggung_jawab;
        }

        public void UpdateInfo()
        {
            judulForm.Text = "Update Kategori";
            btnCreateKat.Text = "Update";
            txtNamaKat.Text = nama_kategori;
        }

        private void AddKategoriElektronik_Shown(object sender, EventArgs e)
        {
        }

        public void Clear()
        {
            txtNamaKat.Text = string.Empty;
            judulForm.Text = "Tambah Kategori Elektronik";
            btnCreateKat.Text = "Simpan";
            cmbPenanggungJawab.Text = "";
        }

        private void btnCreateKat_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNamaKat.Text) || string.IsNullOrEmpty(cmbPenanggungJawab.Text))
            {
                MessageBox.Show("Isi semua kolom dengan benar!");
                return;
            }

            if (btnCreateKat.Text == "Simpan")
            {
                KatElektronik std = new KatElektronik(txtNamaKat.Text.Trim(), cmbPenanggungJawab.Text.Trim());
                DbMasipon.AddKategori(std);
                Clear();
            }
            if (btnCreateKat.Text == "Update")
            {
                KatElektronik std = new KatElektronik(txtNamaKat.Text.Trim(), cmbPenanggungJawab.Text.Trim());
                DbMasipon.UpdateKategori(std, id_kategori);
            }
            // CheckSelectedValue();
            _parent.Display();
        }
    }
}
