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
    public partial class InvElektronik : Form
    {
        FormInvElektronik form;

        public FormInvElektronik Form { get => form; set => form = value; }

        public InvElektronik()
        {
            InitializeComponent();
            Form = new FormInvElektronik(this);
        }

        public void Display()
        {
            DbMasipon.DisplayAndSearch("SELECT id_elektronik, judul_elektronik, kategori_elektronik, cabang, tahun_rilis FROM inv_elektronik", dataGridView1);
        }

        private void InvElektronik_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void newKatElektronik_Click(object sender, EventArgs e)
        {
            Form.Clear();
            Form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hp = new HomePage();
            hp.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbMasipon.DisplayAndSearch("SELECT id_elektronik, judul_elektronik, kategori_elektronik, penerbit, tahun_terbit FROM inv_elektronik WHERE judul_elektronik LIKE '%" + txtSearch.Text + "%' OR kategori_elektronik LIKE '%" + txtSearch.Text + "%' OR cabang LIKE '%" + txtSearch.Text + "%' OR tahun_rilis LIKE '%" + txtSearch.Text + "%'", dataGridView1);
        }

        private FormInvElektronik GetForm()
        {
            return Form;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e, FormInvElektronik form)
        {
            
        }

        private void InvElektronik_Load(object sender, EventArgs e)
        {
            //Display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                // Edit
                form.Clear();
                form.id_elektronik = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.judul_elektronik = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.kategori_elektronik = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.cabang = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.tahun_rilis = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                // Delete
                if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbMasipon.DeleteElektronik(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
