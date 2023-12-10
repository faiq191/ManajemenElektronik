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
    public partial class KategoriElektronik : Form
    {
        AddKategoriElektronik form;
        public KategoriElektronik()
        {
            InitializeComponent();
            form = new AddKategoriElektronik(this);
        }

        public void Display()
        {
            DbMasipon.DisplayAndSearch("SELECT id_kategori, nama_kategori, nama_penanggung_jawab FROM kategori_elektronik", dataGridView1);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newKatElektronik_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }

        private void KategoriElektronik_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbMasipon.DisplayAndSearch("SELECT id_kategori, nama_kategori, nama_penanggung_jawab FROM kategori_elektronik WHERE nama_kategori LIKE '%" + txtSearch.Text + "%' OR nama_penanggung_jawab LIKE '%" + txtSearch.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                // Edit
                form.Clear();
                form.id_kategori = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.nama_kategori = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.nama_penanggung_jawab = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                // Delete
                if(MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbMasipon.DeleteKategori(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homepage = new HomePage();
            homepage.ShowDialog();
        }
    }
}
