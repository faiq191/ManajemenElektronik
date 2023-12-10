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
    public partial class FormPegawai : Form
    {
        private readonly Pegawai _parent;
        public string id_pegawai, nama, alamat, no_telp;
        public DateTime tanggal_lahir;

        public FormPegawai(Pegawai parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void FormPegawai_Load(object sender, EventArgs e)
        {
            
        }

        private void FormPegawai_Shown(object sender, EventArgs e)
        {
            if(judulForm.Text == "Update Data Pegawai")
            {
                tanggalLahir.Value = tanggal_lahir;
            } else
            {
                return;
            }
        }

        public void UpdateInfo()
        {
            judulForm.Text = "Update Data Pegawai";
            btnCreateKat.Text = "Update";
            txtNama.Text = nama;
            txtAlamat.Text = alamat;
            txtNoTelp.Text = no_telp;
        }
        private void btnCreateKat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNama.Text) || string.IsNullOrEmpty(txtAlamat.Text) || string.IsNullOrEmpty(txtNoTelp.Text))
            {
                MessageBox.Show("Isi semua kolom dengan benar!");
                return;
            }

            if (btnCreateKat.Text == "Simpan")
            {
                PegawaiPerp std = new PegawaiPerp(txtNama.Text.Trim(), txtAlamat.Text.Trim(), tanggalLahir.Value, txtNoTelp.Text);
                DbMasipon.AddPegawai(std);
                Clear();
            }
            if (btnCreateKat.Text == "Update")
            {
                PegawaiPerp std = new PegawaiPerp(txtNama.Text.Trim(), txtAlamat.Text.Trim(), tanggalLahir.Value, txtNoTelp.Text);
                DbMasipon.UpdatePegawai(std, id_pegawai);
            }
            _parent.Display();
        }

        public void Clear()
        {
            txtNama.Text = txtAlamat.Text = tanggalLahir.Text = txtNoTelp.Text = string.Empty;
            judulForm.Text = "Tambah Data Pegawai";
            btnCreateKat.Text = "Simpan";
        }
    }
}
