using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Mysql
{
    public partial class FormInvElektronik : Form
    {
        private readonly InvElektronik _parent;
        public string id_elektronik, judul_elektronik, kategori_elektronik, cabang, tahun_rilis;

        public FormInvElektronik(InvElektronik parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void judulForm_Click(object sender, EventArgs e)
        {

        }

        public void UpdateInfo()
        {
            judulForm.Text = "Update Data Elektronik";
            btnCreateKat.Text = "Update";
            txtJudulElektronik.Text = judul_elektronik;
            txtCabang.Text = cabang;
            txtTahunRilis.Text = tahun_rilis;
        }
        private void FormInvElektronik_Load(object sender, EventArgs e)
        {
            DbMasipon.LoadComboBox("SELECT * FROM kategori_elektronik", "kategori_elektronik", "nama_kategori", cmbKategoriElektronik);
            cmbKategoriElektronik.Text = kategori_elektronik;
        }

        public void Clear()
        {
            txtJudulElektronik.Text = cmbKategoriElektronik.Text = txtTahunRilis.Text = string.Empty;
            judulForm.Text = "Tambah Data Elektronik";
            btnCreateKat.Text = "Simpan";
            cmbKategoriElektronik.Text = "";
        }

        private void btnCreateKat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJudulElektronik.Text) || string.IsNullOrEmpty(cmbKategoriElektronik.Text) || string.IsNullOrEmpty(txtCabang.Text) || string.IsNullOrEmpty(txtTahunRilis.Text))
            {
                MessageBox.Show("Isi semua kolom dengan benar!");
                return;
            }

            if (btnCreateKat.Text == "Simpan")
            {
                Inven std = new Inven(txtJudulElektronik.Text.Trim(), cmbKategoriElektronik.Text.Trim(), txtCabang.Text.Trim(), txtTahunRilis.Text.Trim());
                DbMasipon.AddElektronik(std);
                Clear();
            }
            if (btnCreateKat.Text == "Update")
            {
                Inven std = new Inven(txtJudulElektronik.Text.Trim(), cmbKategoriElektronik.Text.Trim(), txtCabang.Text.Trim(), txtTahunRilis.Text.Trim());
                DbMasipon.UpdateElektronik(std, id_elektronik);
            }
            _parent.Display();
        }
    }
}
