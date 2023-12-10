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
    public partial class Pegawai : Form
    {

        FormPegawai form;
        public Pegawai()
        {
            InitializeComponent();
            form = new FormPegawai(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void Display()
        {
            DbMasipon.DisplayAndSearch("SELECT id_pegawai, nama, alamat, tanggal_lahir, no_telp FROM pegawai", dataGridView1);
        }

        private void Pegawai_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void newKatBuku_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbMasipon.DisplayAndSearch("SELECT id_pegawai, nama, alamat, tanggal_lahir, no_telp FROM pegawai WHERE nama LIKE '%" + txtSearch.Text + "%' OR alamat LIKE '%" + txtSearch.Text + "%' OR tanggal_lahir LIKE '%" + txtSearch.Text + "%' OR no_telp LIKE '%" + txtSearch.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                // Edit
                form.Clear();
                form.id_pegawai = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.nama = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.alamat = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                DateTime tanggal = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                form.tanggal_lahir = tanggal;
                /*if (dataGridView1.Rows[e.RowIndex].Cells[5].Value is DateTime tanggal)
                {
                    // Mengatur nilai tanggal ke properti nama pada objek form
                    form.tanggal_lahir = tanggal;
                    MessageBox.Show("Bnar " + tanggal + ". Tipe Data : " + tanggal.GetType());
                }
                else
                {
                    // Handle jika nilai sel bukan objek DateTime
                    MessageBox.Show("Nilai sel bukan objek DateTime.");
                }*/

                form.no_telp = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                // Delete
                if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbMasipon.DeletePegawai(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
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
